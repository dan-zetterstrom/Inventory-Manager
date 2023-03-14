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
    public partial class formViewItem : Form
    {
        public DataSet idDescDataSet;
        public SqlConnection Connection;
        public formMain MainForm;
        public bool descChanged, quantityChanged, itemChanged, locationChanged;
        public string Description;
        public string ItemLocation;
        public int Quantity;
        public formViewItem(SqlConnection connection, int ID, string description, int quantity, string category, string itemLocation, formMain mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;
            Connection = connection;
            Description = description;
            Quantity = quantity;
            ItemLocation = itemLocation;

            txtID.Text = ID.ToString();
            txtCategory.Text = category;

            setBoxes();
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text != "")
            {
                if (txtCategory.Text != "")
                {
                    string updateQuery = "UPDATE [IT_Inventory].[dbo].inventoryObjects SET description = @Description, quantity = @Quantity , location = @Location WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(updateQuery, Connection);
                    cmd.Parameters.Add("@Description", SqlDbType.VarChar, 255);
                    cmd.Parameters["@Description"].Value = txtDescription.Text;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int);
                    cmd.Parameters["@Quantity"].Value = numQuantity.Value;
                    cmd.Parameters.Add("@Location", SqlDbType.VarChar, 255);
                    cmd.Parameters["@Location"].Value = cbLocation.Text;
                    cmd.Parameters.Add("@ID", SqlDbType.Int);
                    cmd.Parameters["@ID"].Value = txtID.Text;
                    cmd.ExecuteNonQuery();
                    if (itemChanged) 
                    {
                        MainForm.generateEvent("MODIFY INV ITEM", cmd.Parameters["@ID"].Value.ToString(), setEventDescription());
                    }
                    MainForm.refreshDataGrid();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please fill in category box!");
                }
            }
            else 
            {
                MessageBox.Show("Please fill in description box!");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + txtDescription.Text + "?", "Delete Inventory Item", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM [IT_Inventory].[dbo].inventoryObjects WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(deleteQuery, Connection);
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = txtID.Text;
                cmd.ExecuteNonQuery();
                MainForm.refreshDataGrid();
                MainForm.generateEvent("DELETE INV ITEM", cmd.Parameters["@ID"].Value.ToString(), "Item: " + cmd.Parameters["@ID"].Value.ToString() +  " deleted");
                this.Close();
            }
        }

        private void setBoxes() 
        {
            txtDescription.Text = Description;
            numQuantity.Value = Quantity;
            cbLocation.Text = ItemLocation;
            cbLocation.DropDownStyle = ComboBoxStyle.DropDownList;

            descChanged = false;
            quantityChanged = false;
            locationChanged = false;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            descChanged = true;
            itemChanged = true;
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            locationChanged = true;
            itemChanged = true;
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            quantityChanged = true;
            itemChanged = true;
        }

        private string setEventDescription() 
        {
            string descString = "", quantityString = "", locationString = "";
            if (descChanged)
            {
                descString = "Description changed from " + Description + " to " + txtDescription.Text + "; ";
            }
            if (quantityChanged) 
            {
                quantityString = "Quantity changed from " + Quantity.ToString() + " to " + numQuantity.Value.ToString() + "; ";
            }
            if (locationChanged)
            {
                locationString = "Location changed from " + ItemLocation + " to " + cbLocation.Text + "; ";
            }
            return descString + quantityString + locationString;
        }
    }
}
