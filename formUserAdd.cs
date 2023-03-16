using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class formUserAdd : Form
    {
        public SqlConnection Connection;
        public formMain MainForm;
        public SqlDataAdapter dataAdapter;

        public formUserAdd(SqlConnection connection, formMain mainForm, string name = "")
        {
            InitializeComponent();
            MainForm = mainForm;
            Connection = connection;
            if (name != "")
            {
                txtFirstName.Text = name.Split(' ')[0];
                txtLastName.Text = name.Split(' ')[1];
            }
        }

        private string getUniqueDeviceID()
        {
            string uniqueDeviceID = "99999";
            DataSet idSet = MainForm.getData("SELECT TOP 1 userID FROM [IT_Inventory].[dbo].users WHERE firstName + ' ' + lastName = '" + txtFirstName.Text + " " + txtLastName.Text + "' ORDER BY userID DESC");
            foreach (DataRow row in idSet.Tables[0].Rows)
            {
                foreach (Object item in row.ItemArray)
                {
                    uniqueDeviceID = item.ToString();
                }
            }
            return uniqueDeviceID;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO [IT_Inventory].[dbo].users(firstName, lastName, officeLocation, title, startDate) VALUES(@First, @Last, @Office, @Title, @Start)";
            SqlCommand cmd = new SqlCommand(insertQuery, Connection);
            cmd.Parameters.Add("@First", SqlDbType.VarChar, 255);
            cmd.Parameters["@First"].Value = txtFirstName.Text;

            cmd.Parameters.Add("@Last", SqlDbType.VarChar, 255);
            cmd.Parameters["@Last"].Value = txtLastName.Text;

            cmd.Parameters.Add("@Office", SqlDbType.VarChar, 255);
            cmd.Parameters["@Office"].Value = cbOfficeLocation.Text;

            cmd.Parameters.Add("@Title", SqlDbType.VarChar, 255);
            cmd.Parameters["@Title"].Value = txtTitle.Text;

            cmd.Parameters.Add("@Start", SqlDbType.DateTime);
            cmd.Parameters["@Start"].Value = dtStart.Text;

            cmd.ExecuteNonQuery();
            MainForm.generateEvent("ADD USER", getUniqueDeviceID(), "Added " + txtFirstName.Text + " " + txtLastName.Text + " to Users");
            MainForm.userViewHandler();
            this.Close();
        }
    }
}
