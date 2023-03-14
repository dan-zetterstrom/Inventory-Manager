using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Inventory_Manager
{
    public partial class formSearch : Form
    {
        public SqlConnection Connection;
        public formMain MainForm;
        public List<String> closetColumns = new List<String> {"ID", "Description", "Quantity", "Category", "Location"};
        public List<String> devicesColumns = new List<String> { "ID", "SN", "SN_Type", "HostName", "Make", "Model", "Category", "AssignedTo", "Status", "ServiceStartDate", "AssignedDate"};
        public List<String> usersColumns = new List<String> { "ID", "FirstName", "LastName", "OfficeLocation", "Title", "StartDate", "TermDate" };
        public List<String> eventsColumns = new List<String> { "EventAction", "EventObject", "EventDescription", "TimeStamp"};
        public string selectedTable = "";
        public SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public DataSet resultsDataSet = new DataSet();
        public bool additionalTerm = false;
        public formSearch(SqlConnection connection, formMain mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            Connection = connection;
        }

        private void setColumns(List<String> list) 
        {
            //populates comboboxes with data from given list
            cbColumns.Items.Clear();
            cbColumns2.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                cbColumns.Items.Add(list[i]);
                cbColumns2.Items.Add(list[i]);
            }
        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Every time combobox index is changed, updates items
            switch (cbTables.Text) 
            {
                case "Closet Inventory":
                    setColumns(closetColumns);
                    selectedTable = "inventoryObjects";
                    break;
                case "Users":
                    setColumns(usersColumns);
                    selectedTable = "Users";
                    break;
                case "Change Log":
                    setColumns(eventsColumns);
                    selectedTable = "eventLog";
                    break;
                case "Devices":
                    setColumns(devicesColumns);
                    selectedTable = "devices";
                    break; 
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            string insertQuery = "";
            string deviceColumn = "";
            string likeEquals = radLike.Checked ? " LIKE " : " = ";
            string percentApos = radLike.Checked ? "%" : "";
            string additionalQuery = additionalTerm ? getSecondSearchQuery() : "";
            string checkUnassigned = txtSearchTerm.Text == "Unassigned" ? " IS NULL" : likeEquals + "'" + percentApos + txtSearchTerm.Text + percentApos + "'" + additionalQuery;
            bool secondColumns = true;

            if (chkMoreSearch.Checked && cbColumns2.Text == "") 
            {
                secondColumns = false;
            }

            if (cbColumns.Text != "" && secondColumns)
            {
                if (cbTables.Text == "Devices")
                {
                    deviceColumn = cbColumns.Text == "AssignedTo" ? "u.firstName + ' ' + u.lastName" : cbColumns.Text;
                    insertQuery = @"SELECT
	d.ID,
	d.category,
	d.hostName,
	d.make,
	d.model,
	CASE
		WHEN
			u.firstName + ' ' + u.lastName IS NULL
		THEN
			'Unassigned'
		ELSE
			u.firstName + ' ' + u.lastName
		END AS 'assignedTo',
	d.SN_Type,
	d.SN,
	d.status,
	d.serviceStartDate,
	d.assignedDate
FROM 
	[IT_Inventory].[dbo].devices d
LEFT JOIN
	[IT_Inventory].[dbo].Users u
	ON
	u.UserID = d.assignedTo
WHERE 
	" + deviceColumn + checkUnassigned;
                }
                else
                {
                    insertQuery = "SELECT * FROM [IT_Inventory].[dbo]." + selectedTable + " WHERE " + cbColumns.Text + likeEquals + "'" + percentApos + txtSearchTerm.Text + percentApos + "'" + additionalQuery;
                }
                //MessageBox.Show(insertQuery);
                SqlCommand cmd = new SqlCommand(insertQuery, Connection);
                cmd.Parameters.Add("@SearchTerm", SqlDbType.VarChar, 255);
                cmd.Parameters["@SearchTerm"].Value = txtSearchTerm.Text;
                cmd.Parameters.Add("@SecondTerm", SqlDbType.VarChar, 255);
                cmd.Parameters["@SecondTerm"].Value = txtSearchTerm2.Text;
                //MessageBox.Show(cmd.CommandText);
                dataAdapter.SelectCommand = cmd;
                resultsDataSet.Clear();
                //MessageBox.Show(insertQuery);
                dataAdapter.Fill(resultsDataSet);
                MainForm.displaySearchResults(resultsDataSet, cbTables.Text);
                this.Close();
            }
            else 
            {
                MessageBox.Show("Please ensure a column is selected for both fields!");
            }
        }

        private void chkMoreSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkMoreSearch.Checked)
            {
                radAnd.Enabled = false;
                radOr.Enabled = false;
                lblColumn2.Enabled = false;
                cbColumns2.Enabled = false;
                radLike2.Enabled = false;
                radEquals2.Enabled = false;
                lblTerm2.Enabled = false;
                txtSearchTerm2.Enabled = false;
                additionalTerm = false;
                cbColumns2.Text = "";
                txtSearchTerm2.Text = "";
            }
            else 
            {
                radAnd.Enabled = true;
                radOr.Enabled = true;
                lblColumn2.Enabled = true;
                cbColumns2.Enabled = true;
                radLike2.Enabled = true;
                radEquals2.Enabled = true;
                lblTerm2.Enabled = true;
                txtSearchTerm2.Enabled = true;
                additionalTerm = true;
            }
        }

        private string getSecondSearchQuery() 
        {
            string andOr = "";
            string likeEquals = "";
            string percentApos = "";

            andOr = radAnd.Checked ? " AND " : " OR ";
            likeEquals = radEquals2.Checked ? " = " : " LIKE ";
            percentApos = radEquals2.Checked ? "" : "%";

            return andOr + cbColumns2.Text + likeEquals + "'" + percentApos + txtSearchTerm2.Text + percentApos + "'";
        }
    }
}
