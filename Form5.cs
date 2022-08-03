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
    public partial class formChangeDB : Form
    {
        public String newDB;
        public String newUN;
        public String newPass;
        public String newConnectionString;
        public SqlConnection connection;
        public formChangeDB()
        {
            InitializeComponent();
            formMain mainForm = new formMain();
            txtCurrentDB.Text = mainForm.dbIP;
        }

        private void cmdTestConnection_Click(object sender, EventArgs e)
        {
            newDB = txtNewDB.Text;
            newUN = txtNewUN.Text;
            newPass = txtNewPass.Text;

            if (txtNewDB.Text != "") 
            {
                if (txtNewUN.Text != "") 
                {
                    if (txtNewPass.Text != "")
                    {
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
            newDB = txtNewDB.Text;
            newUN = txtNewUN.Text;
            newPass = txtNewPass.Text;
            if (connection != null)
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        newConnectionString = "Data Source = " + txtNewDB.Text + "; Initial Catalog = master; Persist Security Info = True; User ID = " + txtNewUN.Text + "; Password = " + txtNewPass.Text;
                        connection = new SqlConnection(newConnectionString);
                        connection.Open();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Connection Failed");

                    }
                    txtCurrentDB.Text = "";
                    //this.Close();
                }
                else
                {
                    txtCurrentDB.Text = "";
                    //this.Close();
                }
            }
            else 
            {
                try
                {
                    newConnectionString = "Data Source = " + txtNewDB.Text + "; Initial Catalog = master; Persist Security Info = True; User ID = " + txtNewUN.Text + "; Password = " + txtNewPass.Text;
                    connection = new SqlConnection(newConnectionString);
                    connection.Open();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Connection Failed");

                }
                txtCurrentDB.Text = "";
                //this.Close();
            }
        }
    }
}
