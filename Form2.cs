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
    public partial class formAdd : Form
    {
        public SqlConnection Connection;
        public DataSet idDataSet;
        public formAdd()
        {
            InitializeComponent();
            
        }

        public formAdd(SqlConnection connection, DataSet categoryList, DataSet idList) 
        {
            InitializeComponent();
            Connection = connection;
            idDataSet = idList;
            foreach (DataRow row in categoryList.Tables[0].Rows) 
            {
                foreach (Object item in row.ItemArray) 
                {
                    cbCategories.Items.Add(item.ToString());
                }
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {

            if (txtDescription.Text != "")
            {
                if (cbCategories.Text != "")
                {
                    string insertQuery = "INSERT INTO inventoryObjects(ID, description, quantity, category) VALUES (@ID, @Description, @Quantity, @Category)";
                    SqlCommand cmd = new SqlCommand(insertQuery, Connection);
                    cmd.Parameters.Add("@ID", SqlDbType.Int);
                    cmd.Parameters["@ID"].Value = getNextID(cbCategories.Text);
                    cmd.Parameters.Add("@Description", SqlDbType.VarChar, 255);
                    cmd.Parameters["@Description"].Value = txtDescription.Text;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int);
                    cmd.Parameters["@Quantity"].Value = numQuantity.Value;
                    cmd.Parameters.Add("@Category", SqlDbType.VarChar, 255);
                    cmd.Parameters["@Category"].Value = cbCategories.Text;
                    cmd.ExecuteNonQuery();
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Please fill in category field!");
                }
            }
            else 
            {
                MessageBox.Show("Please fill in description field!");
            }
        }

        private int getNextID(string cat) {
            switch (cat) {
                case ("Data"):
                    return (int)idDataSet.Tables[0].Rows[0].ItemArray[0] + 1;
                case ("HMI"):
                    return (int)idDataSet.Tables[0].Rows[1].ItemArray[0] + 1;
                case ("Network"):
                    return (int)idDataSet.Tables[0].Rows[2].ItemArray[0] + 1;
                case ("Printing"):
                    return (int)idDataSet.Tables[0].Rows[5].ItemArray[0] + 1;
                case ("PSU"):
                    return (int)idDataSet.Tables[0].Rows[6].ItemArray[0] + 1;
                case ("Rack"):
                    return (int)idDataSet.Tables[0].Rows[7].ItemArray[0] + 1;
                case ("Video"):
                    return (int)idDataSet.Tables[0].Rows[8].ItemArray[0] + 1;
                case ("PC Components"):
                    return (int)idDataSet.Tables[0].Rows[3].ItemArray[0] + 1;
                case ("Phones"):
                    return (int)idDataSet.Tables[0].Rows[4].ItemArray[0] + 1;
            }
            return 0;
        }
    }
}
