namespace Inventory_Manager
{
    partial class formUserView
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
            this.viewUserMenu = new System.Windows.Forms.MenuStrip();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblOffice = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblTermDate = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cbOfficeLocation = new System.Windows.Forms.ComboBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtTerm = new System.Windows.Forms.DateTimePicker();
            this.chkTerm = new System.Windows.Forms.CheckBox();
            this.viewUserMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewUserMenu
            // 
            this.viewUserMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDelete,
            this.menuSave});
            this.viewUserMenu.Location = new System.Drawing.Point(0, 0);
            this.viewUserMenu.Name = "viewUserMenu";
            this.viewUserMenu.Size = new System.Drawing.Size(465, 24);
            this.viewUserMenu.TabIndex = 0;
            this.viewUserMenu.Text = "menuStrip1";
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(52, 20);
            this.menuDelete.Text = "Delete";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(92, 20);
            this.menuSave.Text = "Save Changes";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 40);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 70);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Location = new System.Drawing.Point(12, 100);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(82, 13);
            this.lblOffice.TabIndex = 3;
            this.lblOffice.Text = "Office Location:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 130);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(12, 160);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblTermDate
            // 
            this.lblTermDate.AutoSize = true;
            this.lblTermDate.Location = new System.Drawing.Point(12, 190);
            this.lblTermDate.Name = "lblTermDate";
            this.lblTermDate.Size = new System.Drawing.Size(60, 13);
            this.lblTermDate.TabIndex = 6;
            this.lblTermDate.Text = "Term Date:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(78, 37);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(375, 20);
            this.txtFirstName.TabIndex = 7;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(78, 67);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(375, 20);
            this.txtLastName.TabIndex = 8;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(48, 127);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(405, 20);
            this.txtTitle.TabIndex = 9;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // cbOfficeLocation
            // 
            this.cbOfficeLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOfficeLocation.FormattingEnabled = true;
            this.cbOfficeLocation.Items.AddRange(new object[] {
            "Middlesex",
            "Bethlehem",
            "Beloit"});
            this.cbOfficeLocation.Location = new System.Drawing.Point(100, 97);
            this.cbOfficeLocation.Name = "cbOfficeLocation";
            this.cbOfficeLocation.Size = new System.Drawing.Size(353, 21);
            this.cbOfficeLocation.TabIndex = 10;
            this.cbOfficeLocation.SelectedIndexChanged += new System.EventHandler(this.cbOfficeLocation_SelectedIndexChanged);
            // 
            // dtStart
            // 
            this.dtStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtStart.Location = new System.Drawing.Point(76, 157);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(377, 20);
            this.dtStart.TabIndex = 11;
            this.dtStart.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
            // 
            // dtTerm
            // 
            this.dtTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTerm.Enabled = false;
            this.dtTerm.Location = new System.Drawing.Point(97, 187);
            this.dtTerm.Name = "dtTerm";
            this.dtTerm.Size = new System.Drawing.Size(356, 20);
            this.dtTerm.TabIndex = 12;
            this.dtTerm.ValueChanged += new System.EventHandler(this.dtTerm_ValueChanged);
            // 
            // chkTerm
            // 
            this.chkTerm.AutoSize = true;
            this.chkTerm.Location = new System.Drawing.Point(76, 190);
            this.chkTerm.Name = "chkTerm";
            this.chkTerm.Size = new System.Drawing.Size(15, 14);
            this.chkTerm.TabIndex = 13;
            this.chkTerm.UseVisualStyleBackColor = true;
            this.chkTerm.CheckedChanged += new System.EventHandler(this.chkTerm_CheckedChanged);
            // 
            // formUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 226);
            this.Controls.Add(this.chkTerm);
            this.Controls.Add(this.dtTerm);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.cbOfficeLocation);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblTermDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblOffice);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.viewUserMenu);
            this.MainMenuStrip = this.viewUserMenu;
            this.Name = "formUserView";
            this.Text = "View User";
            this.viewUserMenu.ResumeLayout(false);
            this.viewUserMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip viewUserMenu;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblOffice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblTermDate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cbOfficeLocation;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtTerm;
        private System.Windows.Forms.CheckBox chkTerm;
    }
}