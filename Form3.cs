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
        public formViewItem(SqlConnection connection, int ID, string description, int quantity, string category)
        {
            InitializeComponent();
            Connection = connection;
            txtID.Text = ID.ToString();
            txtDescription.Text = description;
            numQuantity.Value = quantity;
            txtCategory.Text = category;
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text != "")
            {
                if (txtCategory.Text != "")
                {
                    string updateQuery = "UPDATE inventoryObjects SET description = @Description, quantity = @Quantity WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(updateQuery, Connection);
                    cmd.Parameters.Add("@Description", SqlDbType.VarChar, 255);
                    cmd.Parameters["@Description"].Value = txtDescription.Text;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int);
                    cmd.Parameters["@Quantity"].Value = numQuantity.Value;
                    cmd.Parameters.Add("@ID", SqlDbType.Int);
                    cmd.Parameters["@ID"].Value = txtID.Text;
                    cmd.ExecuteNonQuery();
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
                string deleteQuery = "DELETE FROM inventoryObjects WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(deleteQuery, Connection);
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = txtID.Text;
                cmd.ExecuteNonQuery();
                this.Close();
            }
        }
    }
}
