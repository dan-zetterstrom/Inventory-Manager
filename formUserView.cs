using Microsoft.Win32;
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

namespace Inventory_Manager
{
    public partial class formUserView : Form
    {
        public SqlConnection Connection;
        public formMain MainForm;
        public int ID;
        public string FirstName, LastName, OfficeLocation, Title, StartDate, TermDate;
        public bool firstChanged, lastChanged, officeChanged, titleChanged, startChanged, termChanged, userChanged;

        public formUserView(SqlConnection connection, formMain mainForm, int id, string firstName, string lastName, string title, string officeLocation, string startDate, string termDate)
        {
            InitializeComponent();
            Connection = connection;
            MainForm = mainForm;
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            OfficeLocation = officeLocation;
            Title = title;
            StartDate = startDate;
            TermDate = termDate;
            setInfo();
        }

        private void setInfo() 
        {
            /*
             All "%Changed" variables must be set to false because they are set to true when the .Text attributes are changed per the below _OnTextChanged 
            methods. Even if the textboxes' text is change programatically, it still calls the corresponding _OnTextChanged method which updates the 
            "%Changed" variables to true. 
             */
            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;
            cbOfficeLocation.Text = OfficeLocation;
            cbOfficeLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTitle.Text = Title;
            dtStart.Text = StartDate;
            dtTerm.Text = TermDate;
            firstChanged = false;
            lastChanged = false;
            officeChanged = false;
            titleChanged = false;
            startChanged = false;
            termChanged = false;
            userChanged = false;
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            string saveQuery = @"UPDATE
	[IT_Inventory].[dbo].users
SET
	firstName = @First,
	lastName = @Last,
	officeLocation = @Office,
	title = @Title,
	startDate = @Start,
	termDate = @Term
WHERE
    userID = @ID";
            SqlCommand cmd = new SqlCommand(saveQuery, Connection);

            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters["@ID"].Value = ID;

            cmd.Parameters.Add("@First", SqlDbType.VarChar, 255);
            cmd.Parameters["@First"].Value = txtFirstName.Text;

            cmd.Parameters.Add("@Last", SqlDbType.VarChar, 255);
            cmd.Parameters["@Last"].Value = txtLastName.Text;

            cmd.Parameters.Add("@Office", SqlDbType.VarChar, 255);
            cmd.Parameters["@Office"].Value = cbOfficeLocation.Text;

            cmd.Parameters.Add("@Title", SqlDbType.VarChar, 255);
            cmd.Parameters["@Title"].Value = txtTitle.Text;

            cmd.Parameters.Add("@Start", SqlDbType.DateTime);
            cmd.Parameters["@Start"].Value = dtStart.Value;

            cmd.Parameters.Add("@Term", SqlDbType.DateTime);
            
            if (chkTerm.Checked)
            {
                cmd.Parameters["@Term"].Value = dtTerm.Value;
            }
            else 
            {
                cmd.Parameters["@Term"].Value = DBNull.Value;
            }
            if (userChanged)
            {
                MainForm.generateEvent("MODIFY USER", cmd.Parameters["@ID"].Value.ToString(), setEventDescription());
            }
            cmd.ExecuteNonQuery();
            MainForm.userViewHandler();
            this.Close();
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete user: " + txtFirstName.Text + " " + txtLastName.Text + "?", "Delete User", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM [IT_Inventory].[dbo].users WHERE userID = @ID";
                SqlCommand cmd = new SqlCommand(deleteQuery, Connection);
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = ID;
                cmd.ExecuteNonQuery();
                MainForm.generateEvent("DELETE USER", cmd.Parameters["@ID"].Value.ToString(), "User: " + cmd.Parameters["@ID"].Value.ToString() + " deleted");
                MainForm.userViewHandler();
                this.Close();
            }
        }

        private void chkTerm_CheckedChanged(object sender, EventArgs e)
        {
            if (dtTerm.Enabled)
            {
                dtTerm.Enabled = false;
            }
            else
            {
                dtTerm.Enabled = true;
            }
        }
        private void dtTerm_ValueChanged(object sender, EventArgs e)
        {
            termChanged = true;
            userChanged = true;
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            startChanged = true;
            userChanged = true;
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            titleChanged = true;
            userChanged = true;
        }

        private void cbOfficeLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            officeChanged = true;
            userChanged = true;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lastChanged = true;
            userChanged = true;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            firstChanged = true;
            userChanged = true;
        }

        private string setEventDescription() 
        {
            string firstString = "", lastString = "", officeString = "", titleString = "", startString = "", termString = "";
            if (firstChanged) 
            {
                firstString = "First name changed from " + FirstName + " to " + txtFirstName.Text + "; ";
            }
            if (lastChanged) 
            {
                lastString = "Last name changed from " + LastName + " to " + txtLastName.Text + "; ";
            }
            if (officeChanged) 
            {
                officeString = "Office changed from " + OfficeLocation + " to " + cbOfficeLocation.Text + "; ";            
            }
            if (titleChanged) 
            {
                titleString = "Title changed from " + Title + " to " + txtTitle.Text + "; ";
            }
            if (startChanged) 
            {
                startString = "Start date changed from " + StartDate + " to " + dtStart.Text + "; ";
            }
            if (termChanged) 
            {
                termString = "Term date changed from " + TermDate + " to " + dtTerm.Text + "; ";
            }
            return firstString + lastString + officeString + titleString + startString + termString;
        }

    }
}
