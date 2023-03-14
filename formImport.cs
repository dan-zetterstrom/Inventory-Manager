using Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Inventory_Manager
{
    public partial class formImport : Form
    {
        public int ImportType;
        public SqlConnection Connection;
        public SqlDataAdapter dataAdapter;
        public formMain MainForm;
        public List<User> userList = new List<User>();
        public List<Device> deviceList = new List<Device>();
        public int columnCount;
        public DataSet activeUserList;
        public String userToMap;

        public formImport(SqlConnection connection, formMain mainForm, int importType)
        {
            //importType determines which type of data is being imported
            //0 = User Import
            //1 = Device Import
            InitializeComponent();
            Connection = connection;
            MainForm = mainForm;
            ImportType = importType;
            activeUserList = getData("SELECT firstName + ' ' + lastName FROM [IT_Inventory].[dbo].Users");
            switch (importType)
            {
                case 0:
                    this.Text = "User Import";
                    columnCount = 5;
                    lblFormat.Text = "Import data should be in the format: FirstName,LastName,Office,Title,StartDate.\nCSV file must include a header row at the top of the file!";
                    break;
                case 1:
                    this.Text = "Device Import";
                    columnCount = 8;
                    lblFormat.Text = "Import data should be in the format: Category, Host Name, Make, Model, Assigned To, SN Type, Serial Number.";
                    break;
            }
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpenDialog = new OpenFileDialog();
            fileOpenDialog.DefaultExt = ".csv";
            fileOpenDialog.Filter = "Comma Seperated Values | *.csv|All Files | *.*";
            DialogResult result = fileOpenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileName.Text = fileOpenDialog.FileName;
                txtFileName.Enabled = false;
                getCSVData();
            }
        }

        private void getCSVData()
        {
            //Reads in a csv file, verifies it's in the correct format (or at least has the
            //correct number of columns) and adds all entries to the appropriate lists
            string[] read;
            try
            {
                StreamReader sr = new StreamReader(txtFileName.Text);

                string data = sr.ReadLine();

                while ((data = sr.ReadLine()) != null)
                {
                    read = data.Split(',');
                    string userName = read[4];
                    if (read.Length == columnCount)
                    {
                        switch (ImportType)
                        {
                            case 0:
                                User tempUser = new User(read[0], read[1], read[2], read[3], read[4]);
                                userList.Add(tempUser);
                                break;
                            case 1:
                                if (!inDataSet(activeUserList, read[4]))
                                {
                                    //Checks if user in assignedTo column exists in the DB and if not, asks user to create a new user
                                    //or adds device with unassigned user
                                    DialogResult addResult = MessageBox.Show("User: " + read[4] + " was not found, would you like to add them as a new user?\nSelect \"No\" to map to existing user.\nSelect \"Cancel\" to leave \"Unassigned\".", "User Not Found", MessageBoxButtons.YesNoCancel);
                                    switch (addResult)
                                    {
                                        case DialogResult.Yes:
                                            formUserAdd addUserForm = new formUserAdd(Connection, MainForm, read[4]);
                                            addUserForm.ShowDialog();
                                            break;
                                        case DialogResult.No:
                                            formMapExistingUser mapExistingUserForm = new formMapExistingUser(getData("SELECT firstName + ' ' + lastName FROM [IT_Inventory].[dbo].Users ORDER BY firstName"), this, read[4]);
                                            mapExistingUserForm.ShowDialog();
                                            userName = userToMap;
                                            break;
                                    }
                                }
                                Device tempDevice = new Device(read[0], read[1], read[2], read[3], userName, read[5], read[6], "Active", read[7]);
                                deviceList.Add(tempDevice);
                                break;
                        }
                    }
                }
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
            }

            switch (ImportType) 
            {
                case 0:
                    if (userList.Count > 0)
                    {
                        MessageBox.Show(userList.Count.ToString() + " entries loaded and ready to import!");
                    }
                    else
                    {
                        MessageBox.Show("No entries loaded! Please choose a different file!");
                        txtFileName.Enabled = true;
                        txtFileName.Text = "";
                    }
                    break;
                case 1:
                    if (deviceList.Count > 0)
                    {
                        MessageBox.Show(deviceList.Count.ToString() + " entries loaded and ready to import!");
                    }
                    else
                    {
                        MessageBox.Show("No entries loaded! Please choose a different file!");
                        txtFileName.Enabled = true;
                        txtFileName.Text = "";
                    }
                    break;
            }
        }

        private void writeSQLData()
        {
            //Mostly self explanatory, switches on importType
            //Sanatizes user import so no funny business is conducted
            switch (ImportType) 
            {
                case 0:
                    foreach (User user in userList)
                    {
                        string insertQuery = "INSERT INTO [IT_Inventory].[dbo].users(firstName, lastName, officeLocation, title, startDate) VALUES(@First, @Last, @Office, @Title, @Start)";
                        SqlCommand cmd = new SqlCommand(insertQuery, Connection);
                        cmd.Parameters.Add("@First", SqlDbType.VarChar, 255);
                        cmd.Parameters["@First"].Value = user.FirstName;

                        cmd.Parameters.Add("@Last", SqlDbType.VarChar, 255);
                        cmd.Parameters["@Last"].Value = user.LastName;

                        cmd.Parameters.Add("@Office", SqlDbType.VarChar, 255);
                        cmd.Parameters["@Office"].Value = user.Office;

                        cmd.Parameters.Add("@Title", SqlDbType.VarChar, 255);
                        cmd.Parameters["@Title"].Value = user.Title;

                        cmd.Parameters.Add("@Start", SqlDbType.DateTime);
                        cmd.Parameters["@Start"].Value = user.StartDate;

                        cmd.ExecuteNonQuery();
                        MainForm.generateEvent("ADD USER", getUniqueDeviceID(user.FirstName, user.LastName, ""), "Added " + user.FirstName + " " + user.LastName + " to Users");
                    }
                    MainForm.userViewHandler();
                    break;
                case 1:
                    foreach (Device device in deviceList) 
                    {
                        string insertQuery = "INSERT INTO [IT_Inventory].[dbo].devices(SN, SN_Type, hostName, make, model, category, assignedTo, status, serviceStartDate) VALUES (@sn, @type, @hostName, @make, @model, @category, " + getUserID(device.AssignedTo) + ", 'Active', @startDate)";
                        SqlCommand cmd = new SqlCommand(insertQuery, Connection);
                        cmd.Parameters.Add("@sn", SqlDbType.VarChar, 255);
                        cmd.Parameters["@sn"].Value = device.SerialNumber;

                        cmd.Parameters.Add("@type", SqlDbType.VarChar, 255);
                        cmd.Parameters["@type"].Value = device.SNType;

                        cmd.Parameters.Add("@hostName", SqlDbType.VarChar, 255);
                        cmd.Parameters["@hostName"].Value = device.HostName;

                        cmd.Parameters.Add("@make", SqlDbType.VarChar, 255);
                        cmd.Parameters["@make"].Value = device.Make;

                        cmd.Parameters.Add("@model", SqlDbType.VarChar, 255);
                        cmd.Parameters["@model"].Value = device.Model;

                        cmd.Parameters.Add("@category", SqlDbType.VarChar, 255);
                        cmd.Parameters["@category"].Value = device.Category;

                        cmd.Parameters.Add("@startDate", SqlDbType.VarChar, 255);
                        cmd.Parameters["@StartDate"].Value = device.StartDate;

                        cmd.ExecuteNonQuery();
                        MainForm.generateEvent("ADD DEVICE", getUniqueDeviceID("","",cmd.Parameters["@SN"].Value.ToString()), "Added " + cmd.Parameters["@Type"].Value.ToString() + ": " + cmd.Parameters["@SN"].Value.ToString() + " to Devices");
                    }
                    MainForm.deviceViewHandler();
                    break;
            }
        }

        private string getUniqueDeviceID(string firstName, string lastName, string serialNumber)
        {
            //Gets primary key for event reporting
            string uniqueDeviceID = "99999";
            DataSet idSet = new DataSet();
            switch (ImportType) 
            {
                case 0:
                    idSet = getData("SELECT TOP 1 userID FROM [IT_Inventory].[dbo].users WHERE firstName + ' ' + lastName = '" + firstName + " " + lastName + "' ORDER BY userID DESC");
                    break;
                case 1:
                    idSet = getData("SELECT TOP 1 ID FROM [IT_Inventory].[dbo].devices WHERE SN = '" + serialNumber + "' ORDER BY ID DESC");
                    break;
            }
            foreach (DataRow row in idSet.Tables[0].Rows)
            {
                foreach (Object item in row.ItemArray)
                {
                    uniqueDeviceID = item.ToString();
                }
            }
            return uniqueDeviceID;
        }

        private DataSet getData(string queryString)
        {
            //Given a query string, returns dataset of results
            DataSet setOfData = new DataSet();
            dataAdapter = new SqlDataAdapter(queryString, Connection);
            setOfData = new DataSet();
            dataAdapter.Fill(setOfData);
            return setOfData;
        }

        private void cmdImport_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.None;
            switch (ImportType) 
            {
                case 0:
                    result = MessageBox.Show("About to commit " + userList.Count + " entries to user data base. \nContinue?", "Commit Entries", MessageBoxButtons.OKCancel);
                    break;
                case 1:
                    result = MessageBox.Show("About to commit " + deviceList.Count + " entries to device data base. \nContinue?", "Commit Entries", MessageBoxButtons.OKCancel);
                    break;
            }
            if (result == DialogResult.OK)
            {
                writeSQLData();
            }
        }

        private bool inDataSet(DataSet setOfData, string item) 
        {
            //Given a dataset and string, iterates through dataset and returns true if it finds a match, false otherwise
            foreach (DataRow row in setOfData.Tables[0].Rows)
            {
                foreach (object point in row.ItemArray) 
                {
                    if (point.ToString() == item) 
                    {
                        return true;
                    }
                }         
            }
            return false;
        }

        private string getUserID(string name) 
        {
            //Given a firstName + " " + lastName, returns userID
            string userID = "";
            DataSet idDataSet = getData("DECLARE @UserName AS VARCHAR(255) = '" + name + @"'
SELECT

    CASE

        WHEN

            EXISTS(SELECT userID FROM [IT_Inventory].[dbo].users WHERE firstName + ' ' + lastName = @UserName)

        THEN
            (SELECT userID FROM [IT_Inventory].[dbo].users WHERE firstName + ' ' + lastName = @UserName)

        ELSE

            '0'

    END");
            foreach (DataRow row in idDataSet.Tables[0].Rows)
            {
                foreach (object point in row.ItemArray)
                {
                    userID = point.ToString();
                }
            }
            //MessageBox.Show(userID);
            return userID;
        }
    }
}