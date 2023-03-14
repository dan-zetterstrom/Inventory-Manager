using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class formMapExistingUser : Form
    {
        public formImport ImportForm;
        public formMapExistingUser(DataSet existingUsers, formImport importForm, string userToMap)
        {
            InitializeComponent();
            ImportForm = importForm;
            populateComboBox(cbUsers, existingUsers);
            lblUserToMap.Text = "User To Map: " + userToMap;
        }

        private void cmdMapUser_Click(object sender, EventArgs e)
        {
            //Confirms that the username selected by the user is correct
            //or if they really want to map a blank user to the device
            if (cbUsers.Text != "")
            {
                DialogResult result = MessageBox.Show("Map user: " + cbUsers.Text + " to import entry?", "Map User", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    ImportForm.userToMap = cbUsers.Text;
                    this.Close();
                }
            }
            else 
            {
                DialogResult result = MessageBox.Show("Really map blank user to import entry?", "Map Blank User", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK) 
                {
                    ImportForm.userToMap = "";
                    this.Close();
                }
            }
        }

        private void populateComboBox(ComboBox cb, DataSet setOfData)
        {
            //Self explanitory, iterates through dataset and populates combobox
            foreach (DataRow row in setOfData.Tables[0].Rows)
            {
                foreach (Object item in row.ItemArray)
                {
                    cb.Items.Add(item.ToString());
                }
            }
        }
    }
}
