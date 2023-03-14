using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Resources;
using System.Reflection;
using System.Configuration;
using System.Collections.Specialized;

namespace Inventory_Manager
{
    public partial class formMain : Form
    {
        public SqlConnection connection;
        public SqlDataAdapter dataAdapter;
        public DataSet inventoryDataSet;
        public DataSet categoryDataSet;
        public DataSet deviceDataSet = new DataSet();
        public DataSet usersDataSet = new DataSet();
        public DataSet changeLogDataSet = new DataSet();
        public DataSet searchResultsDataSet = new DataSet();
        public DataSet idDataSet;
        public DataSet idDescDataSet;
        public String dbIP = "192.168.200.31\\IGNITION";
        public String dbUN = "inventoryReader";
        public String dbPW = "1nventoryPass!";
        public String connectionString;
        public String selectString = "SELECT ID, description AS 'Description', quantity AS 'Quantity', category AS 'Cat', location AS 'Location' FROM [IT_Inventory].[dbo].inventoryObjects ORDER BY ID";
        public String deviceString;
        public String usersString; 
        public String changeLogString;
        public String searchString;
        public String addString;
        public String deleteString;
        public String modifyString;
        public bool deviceAdd = false;
        public bool deviceView = false;
        public bool userAdd = false;
        public bool userView = false;
        public bool emptyInventory = false;
        public Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

        public formMain()
        {
            InitializeComponent();
            this.MinimumSize = new Size(550,550);
            setStrings();
            connectionString = "Data Source = " + dbIP + "; Initial Catalog = master; Persist Security Info = True; User ID = " + dbUN + "; Password = " + dbPW;
            connection = new SqlConnection(connectionString); 
            deviceViewHandler();
            getSQLData();
            lblCurrentDB.Text = "Connected To: " + dbIP;
        }

        public void getSQLData() 
        {
            if (connection != null)
            {
                /*
                If the connection has not been initialized, connection is initialized and the method is called again recursively
                 */
                if (connection.State == ConnectionState.Open)
                {
                    /*
                    If the connection is already open, clear the inventory dataset
                    Else, open the connection and initialize the dataset
                     */
                    dataAdapter = new SqlDataAdapter(selectString, connection);
                    inventoryDataSet.Clear();
                    dataAdapter.Fill(inventoryDataSet);
                }
                else
                {
                    try
                    {
                        connection.Open();
                        dataAdapter = new SqlDataAdapter(selectString, connection);
                        inventoryDataSet = new DataSet();
                        dataAdapter.Fill(inventoryDataSet);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Connection to inventory database failed!\n" + e.Message);
                        formChangeDB dbChangeForm = new formChangeDB(this);
                        dbChangeForm.ShowDialog();
                    }
                }
            }
            else 
            {
                //Uses recursion. I know, impressive, awe inspiring even. A true model
                //of programming to aspire towards
                connection = new SqlConnection(connectionString);
                getSQLData();
            }

        }
        private void onClose(Object sender, EventArgs e)
        {
            /*
             Overrides the existing onClose method so that the SQL connection is closed when the user closes the form
             */
            connection.Close();
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            if (deviceAdd)
            {
                formDeviceAdd deviceAddForm = new formDeviceAdd(connection, this);
                deviceAddForm.Show();
            }
            else if (userAdd) 
            {
                formUserAdd userAddForm = new formUserAdd(connection, this);
                userAddForm.Show();
            }
            else
            {
                dataAdapter = new SqlDataAdapter("SELECT DISTINCT category FROM [IT_Inventory].[dbo].inventoryObjects", connection);
                categoryDataSet = new DataSet();
                categoryDataSet.Clear();
                dataAdapter.Fill(categoryDataSet);

                idDataSet = new DataSet();
                idDataSet.Clear();
                dataAdapter = new SqlDataAdapter("SELECT MAX(ID) FROM [IT_Inventory].[dbo].inventoryObjects GROUP BY category", connection);
                dataAdapter.Fill(idDataSet);
                formAdd addForm = new formAdd(connection, categoryDataSet, idDataSet, this);
                addForm.Show();
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row  = dgInventoryData.CurrentCell.OwningRow;

            if (deviceView)
                {/*
              startServiceDate = If serviceStartDate is NULL in SQL, pass the current time to the view form, else pass serviceStartDate
              dateAssigned = If dateAssigned is NULL in SQL, pass the current time to the view form, else pass dateAssigned
              */
                    DateTime startServiceDate = (row.Cells[9].Value.ToString() == "") ? DateTime.Now : DateTime.Parse(row.Cells[9].Value.ToString());
                    DateTime dateAssigned = (row.Cells[10].Value.ToString() == "") ? DateTime.Now : DateTime.Parse(row.Cells[10].Value.ToString());
                    formViewDevice deviceViewForm = new formViewDevice(connection, this, (int)row.Cells[0].Value, row.Cells[7].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[8].Value.ToString(), startServiceDate, dateAssigned);
                    deviceViewForm.Show();
                }
                else if (userView)
                {
                    formUserView userViewForm = new formUserView(connection, this, (int)row.Cells[0].Value, row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString());
                    userViewForm.Show();
                }
                else
                {
                    formViewItem viewForm = new formViewItem(connection, (int)row.Cells[0].Value, row.Cells[1].Value.ToString(), (int)row.Cells[2].Value, row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), this);
                    viewForm.Show();
                }
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            refreshDataGrid();
        }
        public void refreshDataGrid() 
        {
            formChangeDB changeDBForm = new formChangeDB(this);
            if (changeDBForm.connection == null)
            {
                deviceViewHandler();
                lblCurrentDB.Text = "Connected To: " + dbIP;
                //txtSearch.Text = "";
            }
            else
            {
                /*
                 If the user has just changed databases, connection must be redefined with new username, password, and IP
                 */
                connection = changeDBForm.connection;
                dbIP = changeDBForm.newDB;
                dbUN = changeDBForm.newUN;
                dbPW = changeDBForm.newPass;
                deviceViewHandler();
                lblCurrentDB.Text = "Connected To: " + dbIP;
                //txtSearch.Text = "";
            }
        }
        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formChangeDB dbChangeForm = new formChangeDB(this);
            dbChangeForm.ShowDialog();
        }

        private void setStrings() 
        {
            /*
             Sets public strings in a separate method 
             so as not to clutter the top of the page.
             Strings are set statically so subsequent
             calls to this method don't change the strings 
             */
            deviceString = @"SELECT 
    d.ID AS 'ID',
	d.category AS 'Category',
	d.hostName AS 'Host Name', 
	d.make AS 'Make',
	d.model AS 'Model',
	CASE 
		WHEN 
			d.assignedTo = 0
		THEN
			'Unassigned'
		ELSE
			u.firstName + ' ' + u.lastName 
		END AS 'Assigned To',
	d.SN_Type AS 'SN Type',
	d.SN AS 'Serial Number',
	d.status AS 'Status',
    d.serviceStartDate AS 'Service Start Date',
    d.assignedDate AS 'Date Assigned'
FROM
	[IT_Inventory].[dbo].devices d
LEFT JOIN
	[IT_Inventory].[dbo].users u
	ON
	d.assignedTo = u.userID
";
            usersString = "SELECT userID AS 'ID', firstName AS 'First Name', lastName AS 'Last Name', officeLocation AS 'Office', title AS 'Title', startDate AS 'Start Date', termDate AS 'Term Date' FROM [IT_Inventory].[dbo].Users";
            changeLogString = "SELECT * FROM [IT_Inventory].[dbo].eventLog ORDER BY id DESC";
        }

        public void switchView(string queryString, DataSet setOfData) 
        {
            /*
             Populates main data view with data from queryString and pretties up the resulting table
             */
            dataAdapter = new SqlDataAdapter(queryString, connection);
            setOfData.Clear();
            dataAdapter.Fill(setOfData);
            dgInventoryData.DataSource = setOfData.Tables[0];
            //dgInventoryData.Columns[1].Width = 275;
            dgInventoryData.AutoResizeColumns();
            dgInventoryData.Update();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (emptyInventory)
            {
                closetViewHandler(false);
            }
            else 
            {
                closetViewHandler();
            }
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (emptyInventory)
            {
                userViewHandler(false);
            }
            else
            {
                userViewHandler();
            }
        }

        private void changeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (emptyInventory)
            {
                changeLogViewHandler(false);
            }
            else
            {
                changeLogViewHandler();
            }
        }

        private void menuViewDevices_Click(object sender, EventArgs e)
        {

            if (emptyInventory)
            {
                deviceViewHandler(false);
            }
            else
            {
                deviceViewHandler();
            }
        }

        public void deviceViewHandler(bool setData = true) 
        {
        /*
         Changes what tabs are called and what tabs can be viewed depending on context. Also sets specific variable to indicate what tab the user is viewing
         */
            if (setData)
            { 
            /*
             If setData is true then the user has changed tab views so data needs to be set via switchView()
             Else, lblViewing is set to indicate search results and the data view is updated from the search form
             */
                switchView(deviceString, deviceDataSet);
                lblViewing.Text = "Viewing: Devices";
            }
            else
            {
                if (emptyInventory) 
                {
                    lblViewing.Text = "Viewing: Devices";
                }
                else
                {
                    lblViewing.Text = "Viewing: Search Results";
                }
            }
            
            deviceAdd = true;
            deviceView = true;
            userAdd = false;
            userView = false;
            menuItem.Visible = true;
            menuItem.Text = "Device";
            menuItemAdd.Visible = true;
            menuItemView.Visible = true;
        }

        public void userViewHandler(bool setData = true)
        {
        /*
         Changes what tabs are called and what tabs can be viewed depending on context. Also sets specific variable to indicate what tab the user is viewing
         */
            if (setData)
            {
                /*
                 If setData is true then the user has changed tab views so data needs to be set via switchView()
                 Else, lblViewing is set to indicate search results and the data view is updated from the search form
                 */
                switchView(usersString, usersDataSet);
                lblViewing.Text = "Viewing: Users";
            }
            else
            {                
                if (emptyInventory)
                {
                    lblViewing.Text = "Viewing: Users";
                }
                else
                {
                    lblViewing.Text = "Viewing: Search Results";
                }
            }
            deviceAdd = false;
            deviceView = false;
            userAdd = true;
            userView = true;
            menuItem.Visible = true;
            menuItem.Text = "User";
            menuItemAdd.Visible = true;
            menuItemView.Visible = true;
        }

        public void closetViewHandler(bool setData = true) 
        {
            /*
         Changes what tabs are called and what tabs can be viewed depending on context. Also sets specific variable to indicate what tab the user is viewing
         */
            if (setData)
            {
                /*
                 If setData is true then the user has changed tab views so data needs to be set via switchView()
                 Else, lblViewing is set to indicate search results and the data view is updated from the search form
                 */
                switchView(selectString, inventoryDataSet);
                lblViewing.Text = "Viewing: Closet Inventory";
            }
            else
            {
                if (emptyInventory)
                {
                    lblViewing.Text = "Viewing: Closet Inventory";
                }
                else
                {
                    lblViewing.Text = "Viewing: Search Results";
                }
            }
            deviceAdd = false;
            deviceView = false;
            userAdd = false;
            userView = false;
            menuItem.Visible = true;
            menuItem.Text = "Item";
            menuItemAdd.Visible = true;
            menuItemView.Visible = true;
        }

        public void changeLogViewHandler(bool setData = true) 
        {
            /*
            Changes what tabs are called and what tabs can be viewed depending on context. Also sets specific variable to indicate what tab the user is viewing
            */
            if (setData)
            {
                /*
                 If setData is true then the user has changed tab views so data needs to be set via switchView()
                 Else, lblViewing is set to indicate search results and the data view is updated from the search form
                 */
                switchView(changeLogString, changeLogDataSet);
                lblViewing.Text = "Viewing: Change Log";
            }
            else
            {
                if (emptyInventory)
                {
                    lblViewing.Text = "Viewing: Change Log";
                }
                else
                {
                    lblViewing.Text = "Viewing: Search Results";
                }
            }
            deviceAdd = false;
            deviceView = false;
            userAdd = false;
            userView = false;
            menuItem.Visible = false;
            menuItem.Text = "Item";
            menuItemAdd.Visible = true;
            menuItemView.Visible = true;
        }

        public void generateEvent(string eventAction, string eventObject, string eventDescription) 
        {
            /*
             Given an action (ADD, DELETE, MODIFY), an object, and a description, this will add an event into the event log
             */

            string eventQuery = "INSERT INTO [IT_Inventory].[dbo].eventLog(eventAction, eventObject, eventDescription, timeStamp) VALUES (@Action, @Object, @Description, @Time)";
            SqlCommand cmd = new SqlCommand(eventQuery, connection);
            cmd.Parameters.Add("@Action", SqlDbType.VarChar, 255);
            cmd.Parameters["@Action"].Value = eventAction;

            cmd.Parameters.Add("@Object", SqlDbType.VarChar, 255);
            cmd.Parameters["@Object"].Value = eventObject;

            cmd.Parameters.Add("@Description", SqlDbType.VarChar, 255);
            cmd.Parameters["@Description"].Value = eventDescription;

            cmd.Parameters.Add("@Time", SqlDbType.VarChar, 255);
            cmd.Parameters["@Time"].Value = DateTime.Now;
            cmd.ExecuteNonQuery();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSearch searchForm = new formSearch(connection, this);
            searchForm.Show();
        }

        public void displaySearchResults(DataSet setOfData, string table) 
        {
            dgInventoryData.DataSource = setOfData.Tables[0];
            dgInventoryData.AutoResizeColumns();
            dgInventoryData.Update();
            switch (table) 
            {
                case "Closet Inventory":
                    closetViewHandler(false);
                    break;
                case "Devices":
                    deviceViewHandler(false);
                    break;
                case "Users":
                    userViewHandler(false);
                    break;
                case "Change Log":
                    changeLogViewHandler(false);
                    break;
            }
        }

        public void setLoginInfo()
        {
            dbIP = ConfigurationManager.AppSettings.Get("defaultDB_IP");
            dbUN = ConfigurationManager.AppSettings.Get("defaultDB_UN");
            dbPW = ConfigurationManager.AppSettings.Get("defaultDB_PW");
        }

        private void menuDataBaseImportUsers_Click(object sender, EventArgs e)
        {
            /*
             * importIndex 0 = Users
             * importIndex 1 = Devices
             * importIndex 2 = Inventory Items
             */
            formImport importForm = new formImport(connection, this, 0);
            importForm.Show();
        }

        private void menuDataBaseImportDevices_Click(object sender, EventArgs e)
        {
            /*
             * importIndex 0 = Users
             * importIndex 1 = Devices
             * importIndex 2 = Inventory Items
             */
            formImport importForm = new formImport(connection, this, 1);
            importForm.Show();
        }

        private void menuDataBaseImportInventory_Click(object sender, EventArgs e)
        {
            /*
             * importIndex 0 = Users
             * importIndex 1 = Devices
             * importIndex 2 = Inventory Items
             */
            formImport importForm = new formImport(connection, this, 2);
            importForm.Show();
        }
    }
}
