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

namespace Inventory_Manager
{
    public partial class formMain : Form
    {
        public SqlConnection connection;
        public SqlDataAdapter dataAdapter;
        public DataSet inventoryDataSet;
        public DataSet categoryDataSet;
        public DataSet idDataSet;
        public DataSet idDescDataSet;
        public String dbIP = "STNJ-LT37";
        public String dbUN = "inventory";
        public String dbPW = "1nventoryPass!";
        public String connectionString;
        public String selectString = "SELECT ID, description AS 'Description', quantity AS 'Quantity', category AS 'Cat' FROM inventoryObjects";
        public String searchString;
        public String addString;
        public String deleteString;
        public String modifyString;

        public formMain()
        {
            InitializeComponent();
            connectionString = "Data Source = " + dbIP + "; Initial Catalog = master; Persist Security Info = True; User ID = " + dbUN + "; Password = " + dbPW;
            getSQLData();

            foreach (DataGridViewColumn column in dgInventoryData.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void getSQLData() 
        {
            if (connection != null)
            {
                if (connection.State == ConnectionState.Open)
                {
                    dataAdapter = new SqlDataAdapter(selectString, connection);
                    inventoryDataSet.Clear();
                    dataAdapter.Fill(inventoryDataSet);
                    dgInventoryData.DataSource = inventoryDataSet.Tables[0];
                    dgInventoryData.Columns[1].Width = 275;
                    dgInventoryData.Update();
                }
                else
                {
                    try
                    {
                        connection.Open();
                        dataAdapter = new SqlDataAdapter(selectString, connection);
                        inventoryDataSet = new DataSet();
                        dataAdapter.Fill(inventoryDataSet);
                        dgInventoryData.DataSource = inventoryDataSet.Tables[0];
                        dgInventoryData.Columns[1].Width = 275;
                        dgInventoryData.Update();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Connection to inventory database failed!\n" + e.Message);
                    }
                }
            }
            else 
            {
                connection = new SqlConnection(connectionString);
                getSQLData();
            }

        }
        private void onClose(Object sender, EventArgs e)
        {
            connection.Close();
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            dataAdapter = new SqlDataAdapter("SELECT DISTINCT category FROM inventoryObjects", connection);
            categoryDataSet = new DataSet();
            categoryDataSet.Clear();
            dataAdapter.Fill(categoryDataSet);

            idDataSet = new DataSet();
            idDataSet.Clear();
            dataAdapter = new SqlDataAdapter("SELECT MAX(ID) FROM inventoryObjects GROUP BY category", connection);
            dataAdapter.Fill(idDataSet);
            formAdd addForm = new formAdd(connection, categoryDataSet, idDataSet);
            addForm.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgInventoryData.CurrentCell.OwningRow;
            formViewItem viewForm = new formViewItem(connection, (int)row.Cells[0].Value, row.Cells[1].Value.ToString(), (int)row.Cells[2].Value, row.Cells[3].Value.ToString());
            viewForm.Show();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            searchString = "SELECT ID, description AS 'Description', quantity AS 'Quantity', category AS 'Cat' FROM inventoryObjects WHERE description LIKE '%" + txtSearch.Text +"%'";
            dataAdapter = new SqlDataAdapter(searchString, connection);
            inventoryDataSet.Clear();
            dataAdapter.Fill(inventoryDataSet);
            dgInventoryData.DataSource = inventoryDataSet.Tables[0];
            dgInventoryData.Columns[1].Width = 275;
            dgInventoryData.Update();
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formChangeDB changeDBForm = new formChangeDB();
            if (changeDBForm.connection == null)
            {
                getSQLData();
                txtSearch.Text = "";
            }
            else 
            {
                connection = changeDBForm.connection;
                dbIP = changeDBForm.newDB;
                dbUN = changeDBForm.newUN;
                dbPW = changeDBForm.newPass;
                getSQLData();
                txtSearch.Text = "";
            }
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formChangeDB dbChangeForm = new formChangeDB();
            dbChangeForm.ShowDialog();
        }
    }
}
