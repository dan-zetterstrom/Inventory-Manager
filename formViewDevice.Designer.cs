namespace Inventory_Manager
{
    partial class formViewDevice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.lblSNType = new System.Windows.Forms.Label();
            this.lblSN = new System.Windows.Forms.Label();
            this.meNu = new System.Windows.Forms.MenuStrip();
            this.itemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.cbAssignedTo = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblServiceStartDate = new System.Windows.Forms.Label();
            this.lblDateAssigned = new System.Windows.Forms.Label();
            this.dtServiceStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtDateAssigned = new System.Windows.Forms.DateTimePicker();
            this.mtxtSTID = new System.Windows.Forms.MaskedTextBox();
            this.lblSTID = new System.Windows.Forms.Label();
            this.meNu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCat
            // 
            this.cbCat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(72, 237);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(380, 21);
            this.cbCat.TabIndex = 23;
            this.cbCat.SelectedIndexChanged += new System.EventHandler(this.cbCat_SelectedIndexChanged);
            // 
            // txtModel
            // 
            this.txtModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModel.Location = new System.Drawing.Point(59, 205);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(393, 20);
            this.txtModel.TabIndex = 22;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // txtMake
            // 
            this.txtMake.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMake.Location = new System.Drawing.Point(57, 169);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(395, 20);
            this.txtMake.TabIndex = 21;
            this.txtMake.TextChanged += new System.EventHandler(this.txtMake_TextChanged);
            // 
            // txtHostName
            // 
            this.txtHostName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHostName.Location = new System.Drawing.Point(83, 137);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(369, 20);
            this.txtHostName.TabIndex = 20;
            this.txtHostName.TextChanged += new System.EventHandler(this.txtHostName_TextChanged);
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(119, 70);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(333, 21);
            this.cbType.TabIndex = 19;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // txtSN
            // 
            this.txtSN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSN.Location = new System.Drawing.Point(96, 37);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(356, 20);
            this.txtSN.TabIndex = 18;
            this.txtSN.TextChanged += new System.EventHandler(this.txtSN_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(7, 240);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 17;
            this.lblCategory.Text = "Category:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(7, 208);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 16;
            this.lblModel.Text = "Model:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(7, 172);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 15;
            this.lblMake.Text = "Make:";
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Location = new System.Drawing.Point(7, 140);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(63, 13);
            this.lblHostName.TabIndex = 14;
            this.lblHostName.Text = "Host Name:";
            // 
            // lblSNType
            // 
            this.lblSNType.AutoSize = true;
            this.lblSNType.Location = new System.Drawing.Point(7, 73);
            this.lblSNType.Name = "lblSNType";
            this.lblSNType.Size = new System.Drawing.Size(106, 13);
            this.lblSNType.TabIndex = 13;
            this.lblSNType.Text = "Serial Number Type: ";
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Location = new System.Drawing.Point(7, 40);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(76, 13);
            this.lblSN.TabIndex = 12;
            this.lblSN.Text = "Serial Number:";
            // 
            // meNu
            // 
            this.meNu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDelete,
            this.itemSave});
            this.meNu.Location = new System.Drawing.Point(0, 0);
            this.meNu.Name = "meNu";
            this.meNu.Size = new System.Drawing.Size(464, 24);
            this.meNu.TabIndex = 24;
            this.meNu.Text = "menuStrip1";
            // 
            // itemDelete
            // 
            this.itemDelete.Name = "itemDelete";
            this.itemDelete.Size = new System.Drawing.Size(52, 20);
            this.itemDelete.Text = "Delete";
            this.itemDelete.Click += new System.EventHandler(this.itemDelete_Click);
            // 
            // itemSave
            // 
            this.itemSave.Name = "itemSave";
            this.itemSave.Size = new System.Drawing.Size(92, 20);
            this.itemSave.Text = "Save Changes";
            this.itemSave.Click += new System.EventHandler(this.itemSave_Click);
            // 
            // cbAssignedTo
            // 
            this.cbAssignedTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAssignedTo.FormattingEnabled = true;
            this.cbAssignedTo.Items.AddRange(new object[] {
            "Unassigned"});
            this.cbAssignedTo.Location = new System.Drawing.Point(82, 271);
            this.cbAssignedTo.Name = "cbAssignedTo";
            this.cbAssignedTo.Size = new System.Drawing.Size(370, 21);
            this.cbAssignedTo.TabIndex = 26;
            this.cbAssignedTo.SelectedIndexChanged += new System.EventHandler(this.cbAssignedTo_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(7, 274);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(69, 13);
            this.lblUser.TabIndex = 25;
            this.lblUser.Text = "Assigned To:";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbStatus.Location = new System.Drawing.Point(53, 303);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(399, 21);
            this.cbStatus.TabIndex = 28;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(7, 306);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Text = "Status:";
            // 
            // lblServiceStartDate
            // 
            this.lblServiceStartDate.AutoSize = true;
            this.lblServiceStartDate.Location = new System.Drawing.Point(7, 338);
            this.lblServiceStartDate.Name = "lblServiceStartDate";
            this.lblServiceStartDate.Size = new System.Drawing.Size(97, 13);
            this.lblServiceStartDate.TabIndex = 29;
            this.lblServiceStartDate.Text = "Service Start Date:";
            // 
            // lblDateAssigned
            // 
            this.lblDateAssigned.AutoSize = true;
            this.lblDateAssigned.Location = new System.Drawing.Point(7, 370);
            this.lblDateAssigned.Name = "lblDateAssigned";
            this.lblDateAssigned.Size = new System.Drawing.Size(82, 13);
            this.lblDateAssigned.TabIndex = 30;
            this.lblDateAssigned.Text = "Date Assigned: ";
            // 
            // dtServiceStartDate
            // 
            this.dtServiceStartDate.Location = new System.Drawing.Point(110, 335);
            this.dtServiceStartDate.Name = "dtServiceStartDate";
            this.dtServiceStartDate.Size = new System.Drawing.Size(342, 20);
            this.dtServiceStartDate.TabIndex = 31;
            this.dtServiceStartDate.ValueChanged += new System.EventHandler(this.dtServiceStartDate_ValueChanged);
            // 
            // dtDateAssigned
            // 
            this.dtDateAssigned.Location = new System.Drawing.Point(96, 368);
            this.dtDateAssigned.Name = "dtDateAssigned";
            this.dtDateAssigned.Size = new System.Drawing.Size(356, 20);
            this.dtDateAssigned.TabIndex = 32;
            this.dtDateAssigned.ValueChanged += new System.EventHandler(this.dtDateAssigned_ValueChanged);
            // 
            // mtxtSTID
            // 
            this.mtxtSTID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtSTID.Location = new System.Drawing.Point(98, 103);
            this.mtxtSTID.Mask = "00000";
            this.mtxtSTID.Name = "mtxtSTID";
            this.mtxtSTID.Size = new System.Drawing.Size(354, 20);
            this.mtxtSTID.TabIndex = 33;
            this.mtxtSTID.TextChanged += new System.EventHandler(this.mtxtSTID_ValueChanged);
            // 
            // lblSTID
            // 
            this.lblSTID.AutoSize = true;
            this.lblSTID.Location = new System.Drawing.Point(7, 106);
            this.lblSTID.Name = "lblSTID";
            this.lblSTID.Size = new System.Drawing.Size(90, 13);
            this.lblSTID.TabIndex = 34;
            this.lblSTID.Text = "Spray-Tek ID: ST";
            // 
            // formViewDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 404);
            this.Controls.Add(this.lblSTID);
            this.Controls.Add(this.mtxtSTID);
            this.Controls.Add(this.dtDateAssigned);
            this.Controls.Add(this.dtServiceStartDate);
            this.Controls.Add(this.lblDateAssigned);
            this.Controls.Add(this.lblServiceStartDate);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbAssignedTo);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblHostName);
            this.Controls.Add(this.lblSNType);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.meNu);
            this.MainMenuStrip = this.meNu;
            this.Name = "formViewDevice";
            this.Text = " View Device";
            this.meNu.ResumeLayout(false);
            this.meNu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Label lblSNType;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.MenuStrip meNu;
        private System.Windows.Forms.ToolStripMenuItem itemDelete;
        private System.Windows.Forms.ToolStripMenuItem itemSave;
        private System.Windows.Forms.ComboBox cbAssignedTo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblServiceStartDate;
        private System.Windows.Forms.Label lblDateAssigned;
        private System.Windows.Forms.DateTimePicker dtServiceStartDate;
        private System.Windows.Forms.DateTimePicker dtDateAssigned;
        private System.Windows.Forms.MaskedTextBox mtxtSTID;
        private System.Windows.Forms.Label lblSTID;
    }
}