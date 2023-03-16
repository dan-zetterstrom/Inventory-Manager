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
    public partial class formCatSNAddDelete : Form
    {
        public formDeviceAdd AddDeviceForm;
        public formAdd AddForm;
        public string Identifier;

        public formCatSNAddDelete(formDeviceAdd addDeviceForm, string identifier)
        {
            InitializeComponent();
            AddDeviceForm = addDeviceForm;
            Identifier = identifier;
        }
        public formCatSNAddDelete(formAdd addForm, string identifier)
        {
            InitializeComponent();
            AddForm = addForm;
            Identifier = identifier;
        }

        private void cmdExec_Click(object sender, EventArgs e)
        {
            switch (Identifier) 
            {
                case "CatAdd":
                    if (txtToAdd.Text != "")
                    {
                        MessageBox.Show("Attention! A device must be assigned to this category and saved for this addition to be committed!");
                        AddDeviceForm.addToCatList(txtToAdd.Text);
                        this.Close();
                    }
                    else 
                    {
                        MessageBox.Show("Category to add cannot be blank!");
                    }
                    break;
                case "TypeAdd":
                    if (txtToAdd.Text != "")
                    {
                        MessageBox.Show("Attention! A device must use this SN Type and be saved for this addition to be committed!");
                        AddDeviceForm.addToSNList(txtToAdd.Text);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Category to add cannot be blank!");
                    }
                    break;
                case "invCatAdd":
                    if (txtToAdd.Text != "")
                    {
                        MessageBox.Show("Attention! An inventory item must be assigned to this category and saved for this addition to be committed!");
                        AddForm.addCategory(txtToAdd.Text);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Category to add cannot be blank!");
                    }
                    break;
            }
        }
    }
}
