using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class formViewDevice : Form
    {
        public string SN, Type, HostName, Make, Model, Category, AssignedTo, Status;
        public int ID;
        public SqlConnection Connection;
        public formMain MainForm;
        public DataSet typeDataSet, catDataSet, userDataSet, statusDataSet;
        public DataAdapter dataAdapter;
        public bool snUpdated, typeUpdated, hostUpdated, makeUpdated, modelUpdated, catUpdated, assignedUpdated, statusUpdated, serviceStartDateUpdated, dateAssignedUpdated, deviceChanged;

        public DateTime ServiceStartDate, DateAssigned;

        public formViewDevice(SqlConnection connection, formMain mainForm, int id, string sn, string type, string hostName, string make, string model, string category, string assignedTo, string status, DateTime serviceStartDate, DateTime dateAssigned)
        {
            InitializeComponent();
            Connection = connection;
            MainForm = mainForm;
            SN = sn;
            Type = type;
            HostName = hostName;
            Make = make;
            Model = model;
            Category = category;
            AssignedTo = assignedTo;
            Status = status;
            typeDataSet = getData("SELECT DISTINCT SN_Type FROM [IT_Inventory].[dbo].devices");
            catDataSet = getData("SELECT DISTINCT category FROM [IT_Inventory].[dbo].devices");
            userDataSet = getData("SELECT DISTINCT firstName + ' ' + lastName FROM [IT_Inventory].[dbo].users");
            ID = id;
            ServiceStartDate = serviceStartDate;
            DateAssigned = dateAssigned;
            populateComboBox(cbType, typeDataSet);
            populateComboBox(cbCat, catDataSet);
            populateComboBox(cbAssignedTo, userDataSet);
            setBoxes();
        }

        public DataSet getData(string queryString)
        {
            DataSet setOfData = new DataSet();
            dataAdapter = new SqlDataAdapter(queryString, Connection);
            setOfData = new DataSet();
            dataAdapter.Fill(setOfData);
            return setOfData;
        }

        public void populateComboBox(ComboBox cb, DataSet setOfData)
        {
            foreach (DataRow row in setOfData.Tables[0].Rows)
            {
                foreach (Object item in row.ItemArray)
                {
                    cb.Items.Add(item.ToString());
                }
            }
        }

        private void setBoxes() 
        {
            txtSN.Text = SN;
            cbType.Text = Type;
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            txtHostName.Text = HostName;
            txtMake.Text = Make;
            txtModel.Text = Model;
            cbCat.Text = Category;
            cbCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAssignedTo.Text = AssignedTo;
            cbAssignedTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Text = Status;
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            dtServiceStartDate.Value = ServiceStartDate;
            dtDateAssigned.Value = DateAssigned;
            snUpdated = false;
            typeUpdated = false;
            hostUpdated = false;
            makeUpdated = false;
            modelUpdated = false;
            catUpdated = false;
            assignedUpdated = false;
            statusUpdated = false;
            serviceStartDateUpdated = false;
            dateAssignedUpdated = false;
            deviceChanged = false;
        }
        private void itemDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + txtMake.Text + " " + txtModel.Text + "\nAssigned to " + cbAssignedTo.Text + "?", "Delete Inventory Item", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM [IT_Inventory].[dbo].devices WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(deleteQuery, Connection);
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = ID;
                cmd.ExecuteNonQuery();
                MainForm.generateEvent("DELETE DEVICE", cmd.Parameters["@ID"].Value.ToString(), "Item: " + cmd.Parameters["@ID"].Value.ToString() + " deleted");
                MainForm.deviceViewHandler();
                this.Close();
            }
        }

        private void itemSave_Click(object sender, EventArgs e)
        {
            string assignedToUser;
            if (cbAssignedTo.Text == "Unassigned")
            {
                assignedToUser = "0";
            }
            else 
            { 
                assignedToUser = "(SELECT userID FROM [IT_Inventory].[dbo].Users WHERE firstName + ' ' + lastName = '" + cbAssignedTo.Text + @"')";
            }
            string saveQuery = @"UPDATE 
	[IT_Inventory].[dbo].devices 
SET 
	SN = @SN, 
	SN_Type = @Type, 
	hostName = @Host, 
	make = @Make, 
	model = @Model, 
	category = @Cat, 
	assignedTo = " + assignedToUser + @", 
	status = @Status,
    serviceStartDate = @Service,
    assignedDate = @Assigned
WHERE 
	ID = @ID";
            SqlCommand cmd = new SqlCommand(saveQuery, Connection);

            cmd.Parameters.Add("@ID", SqlDbType.Int);
            cmd.Parameters["@ID"].Value = ID;

            cmd.Parameters.Add("@SN", SqlDbType.VarChar, 255);
            cmd.Parameters["@SN"].Value = txtSN.Text;

            cmd.Parameters.Add("@Type", SqlDbType.VarChar, 255);
            cmd.Parameters["@Type"].Value = cbType.Text;

            cmd.Parameters.Add("@Host", SqlDbType.VarChar, 255);
            cmd.Parameters["@Host"].Value = txtHostName.Text;

            cmd.Parameters.Add("@Make", SqlDbType.VarChar, 255);
            cmd.Parameters["@Make"].Value = txtMake.Text;

            cmd.Parameters.Add("@Model", SqlDbType.VarChar, 255);
            cmd.Parameters["@Model"].Value = txtModel.Text;

            cmd.Parameters.Add("@Cat", SqlDbType.VarChar, 255);
            cmd.Parameters["@Cat"].Value = cbCat.Text;

            cmd.Parameters.Add("@Status", SqlDbType.VarChar, 255);
            cmd.Parameters["@Status"].Value = cbStatus.Text;

            cmd.Parameters.Add("@Service", SqlDbType.DateTime);
            cmd.Parameters["@Service"].Value = dtServiceStartDate.Value;

            cmd.Parameters.Add("@Assigned", SqlDbType.DateTime);
            cmd.Parameters["@Assigned"].Value = dtDateAssigned.Value;

            if (deviceChanged)
            {
                MainForm.generateEvent("MODIFY DEVICE", cmd.Parameters["@ID"].Value.ToString(), setEventDescription());
            }

            cmd.ExecuteNonQuery();
            MainForm.deviceViewHandler();
            this.Close();
        }

        private void txtSN_TextChanged(object sender, EventArgs e)
        {
            snUpdated = true;
            deviceChanged = true;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeUpdated = true;
            deviceChanged = true;
        }
        private void txtHostName_TextChanged(object sender, EventArgs e)
        {
            hostUpdated = true;
            deviceChanged = true;
        }

        private void txtMake_TextChanged(object sender, EventArgs e)
        {
            makeUpdated = true;
            deviceChanged = true;
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            modelUpdated = true;
            deviceChanged = true;
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            catUpdated = true;
            deviceChanged = true;
        }

        private void cbAssignedTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            assignedUpdated = true;
            deviceChanged = true;
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusUpdated = true;
            deviceChanged = true;
        }
        private void dtDateAssigned_ValueChanged(object sender, EventArgs e)
        {
            dateAssignedUpdated = true;
            deviceChanged = true;
        }

        private void dtServiceStartDate_ValueChanged(object sender, EventArgs e)
        {
            serviceStartDateUpdated = true;
            deviceChanged = true;
        }

        private string setEventDescription() 
        {
            string snString = "", typeString = "", hostString = "", makeString = "", modelString = "", catString = "", assignedString = "", statusString = "", serviceStartString = "", dateAssignedString = "";
            if (snUpdated) 
            {
                snString = "Serial number changed from " + SN + " to " + txtSN.Text + "; ";
            }
            if (typeUpdated) 
            {
                typeString = "Serial number type changed from " + Type + " to " + cbType.Text + "; ";
            }
            if (hostUpdated) 
            {
                hostString = "Host name changed from " + HostName + " to " + txtHostName.Text + "; ";
            }
            if (makeUpdated) 
            {
                makeString = "Make changed from " + Make + " to " + txtMake.Text + "; ";
            }
            if (modelUpdated) 
            {
                modelString = "Model changed from " + Model + " to " + txtModel.Text + "; ";
            }
            if (catUpdated) 
            {
                catString = "Category changed from " + Category + " to " + cbCat.Text + "; ";
            }
            if (assignedUpdated) 
            {
                assignedString = "Assignment changed from " + AssignedTo + " to " + cbAssignedTo.Text + "; ";
            }
            if (statusUpdated) 
            {
                statusString = "Status changed from " + Status + " to " + cbStatus.Text + "; ";
            }
            if (serviceStartDateUpdated) 
            {
                serviceStartString = "Service Start Date changed from " + ServiceStartDate + " to " + dtServiceStartDate + "; ";
            }
            if (dateAssignedUpdated) 
            {
                dateAssignedString = "Date Assigned changed from " + DateAssigned + " to " + dtDateAssigned + "; ";
            }
            return snString + typeString + hostString + makeString + modelString + catString + assignedString + statusString + serviceStartString + dateAssignedString;
        }
    }
}
