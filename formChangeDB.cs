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
using System.Collections;
using System.Resources;
using System.Configuration;

namespace Inventory_Manager
{
    public partial class formChangeDB : Form
    {
        public String newDB;
        public String newUN;
        public String newPass;
        public String newConnectionString;
        public SqlConnection connection;
        public formMain MainForm;

        public formChangeDB(formMain mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            txtCurrentDB.Text = mainForm.dbIP;
        }

        private void cmdTestConnection_Click(object sender, EventArgs e)
        {
            //Attempts to establish a connection to new DB provided the DB IP, UN, and PW are not blank
            //If connection is successful, the connection is opened and maintained
            //Else, the exception provided by the target DB is displayed to the user

            newDB = txtNewDB.Text;
            newUN = txtNewUN.Text;
            newPass = txtNewPass.Text;

            if (txtNewDB.Text != "") 
            {
                if (txtNewUN.Text != "") 
                {
                    if (txtNewPass.Text != "")
                    {
                        establishConnection();
                    }
                    else 
                    {
                        MessageBox.Show("Please fill in the password field!");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in the username field!");
                }
            }
            else
            {
                MessageBox.Show("Please fill in the database field!");
            }
        }

        private void cmdFinish_Click(object sender, EventArgs e)
        {
            //Checks if used tested connection beforehand, if not, then attempts to establish connection
            //If they have, sets MainForm variables and closes out
            if (connection != null)
            {
                if (connection.State != ConnectionState.Open)
                {
                    establishConnection();
                    setMainVariables();
                    MainForm.refreshDataGrid();
                    this.Close();
                }
                else
                {
                    setMainVariables();
                    MainForm.refreshDataGrid();
                    this.Close();
                }
            }
            else 
            {
                establishConnection();
                setMainVariables();
                MainForm.refreshDataGrid();
                this.Close();
            }
        }

        private void establishConnection() 
        {
            //Tries to open connection with user DB, if successful, leaves connection open,
            //Else, displays target DB exception to user
            try
            {
                newConnectionString = "Data Source = " + txtNewDB.Text + "; Initial Catalog = master; Persist Security Info = True; User ID = " + txtNewUN.Text + "; Password = " + txtNewPass.Text;
                connection = new SqlConnection(newConnectionString);
                connection.Open();
                MessageBox.Show("Connection Successful!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Connection Failed");
            }
        }

        private void setMainVariables() 
        {
            //Sets variables on MainForm
            MainForm.connection = connection;
            MainForm.dbIP = txtNewDB.Text;
            MainForm.dbUN = txtNewUN.Text;
            MainForm.dbPW = txtNewPass.Text;
        }
    }
}
