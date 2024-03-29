﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class formDeviceAdd : Form
    {
        public SqlConnection Connection;
        public formMain MainForm;
        public SqlDataAdapter dataAdapter;
        public DateTime startDate = DateTime.Now;

        public formDeviceAdd(SqlConnection connection, formMain mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            Connection = connection;
            populateComboBox(cbType, MainForm.getData("SELECT DISTINCT SN_Type FROM [IT_Inventory].[dbo].devices"));
            populateComboBox(cbCat, MainForm.getData("SELECT DISTINCT category FROM [IT_Inventory].[dbo].devices"));
        }

        public void populateComboBox(ComboBox cb, DataSet setOfData) 
        {
            foreach (DataRow row in setOfData.Tables[0].Rows)
            {
                foreach (Object item in row.ItemArray)
                {
                    if (!inComboBox(cb, item.ToString()))
                    {
                        cb.Items.Add(item.ToString());
                    }
                }
            }
        }

        private string getUniqueDeviceID(string serialNumber) 
        {
            //Given a serial number, returns the primary key deviceID from the table for use in event reporting
            string uniqueDeviceID = "99999";
            DataSet idSet = MainForm.getData("SELECT TOP 1 ID FROM [IT_Inventory].[dbo].devices WHERE SN = '" + serialNumber + "' ORDER BY ID DESC");
            foreach (DataRow row in idSet.Tables[0].Rows)
            {
                foreach (Object item in row.ItemArray)
                {
                    uniqueDeviceID = item.ToString();
                }
            }
            return uniqueDeviceID;
        }

        private void cmdAddDevice_Click(object sender, EventArgs e)
        {
            //Sanatizes user inputs to avoid any and all
            //tomfoolery, shenanigans, and brouhaha (that's the correct spelling, I checked)
            string insertQuery = "INSERT INTO [IT_Inventory].[dbo].devices(SN, SN_Type, hostName, make, model, category, assignedTo, status, serviceStartDate, ST_ID) VALUES (@SN, @Type, @hostName, @make, @model, @category, '0', 'Active', '" + dtStartDate.Value + "', @STID)";
            SqlCommand cmd = new SqlCommand(insertQuery, Connection);
            cmd.Parameters.Add("@SN", SqlDbType.VarChar, 255);
            cmd.Parameters["@SN"].Value = txtSN.Text;

            cmd.Parameters.Add("@Type", SqlDbType.VarChar, 255);
            cmd.Parameters["@Type"].Value = cbType.Text;

            cmd.Parameters.Add("@hostName", SqlDbType.VarChar, 255);
            cmd.Parameters["@hostName"].Value = txtHostName.Text;

            cmd.Parameters.Add("@make", SqlDbType.VarChar, 255);
            cmd.Parameters["@make"].Value = txtMake.Text;

            cmd.Parameters.Add("@model", SqlDbType.VarChar, 255);
            cmd.Parameters["@model"].Value = txtModel.Text;

            cmd.Parameters.Add("@category", SqlDbType.VarChar, 255);
            cmd.Parameters["@category"].Value = cbCat.Text;

            cmd.Parameters.Add("@STID", SqlDbType.VarChar, 255);
            cmd.Parameters["@STID"].Value = mtxtSTID.Text == "" ? mtxtSTID.Text : "ST" + mtxtSTID.Text;

            cmd.ExecuteNonQuery();
            MainForm.generateEvent("ADD DEVICE", getUniqueDeviceID(cmd.Parameters["@SN"].Value.ToString()), "Added " + cmd.Parameters["@Type"].Value.ToString() + ": " + cmd.Parameters["@SN"].Value.ToString() + " to Devices");
            MainForm.deviceViewHandler();
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCatSNAddDelete catSNAddDeleteForm = new formCatSNAddDelete(this, "CatAdd");
            catSNAddDeleteForm.ShowDialog();
        }

        private bool inComboBox(ComboBox cb, string toCheck) 
        {
            for (int i = 0; i < cb.Items.Count; i++) 
            {
                if ((string)cb.Items[i] == toCheck) 
                {
                    return true;
                }
            }
            return false;
        }

        public void addToCatList(string item) 
        {
            cbCat.Items.Add(item);
        }

        public void addToSNList(string item) 
        {
            cbType.Items.Add(item);
        }

        private void sNTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formCatSNAddDelete catSNAddDeleteForm = new formCatSNAddDelete(this, "TypeAdd");
            catSNAddDeleteForm.ShowDialog();
        }
    }
}
