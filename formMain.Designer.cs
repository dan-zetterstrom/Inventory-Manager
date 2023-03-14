namespace Inventory_Manager
{
    partial class formMain
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
            this.menuMainForm = new System.Windows.Forms.MenuStrip();
            this.menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataBase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataBaseChange = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataBaseRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataBaseImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataBaseImportDevices = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataBaseImportUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewCloset = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewDevices = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewChangeLog = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgInventoryData = new System.Windows.Forms.DataGridView();
            this.lblCurrentDB = new System.Windows.Forms.Label();
            this.lblViewing = new System.Windows.Forms.Label();
            this.menuMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventoryData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMainForm
            // 
            this.menuMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem,
            this.menuDataBase,
            this.menuView,
            this.searchToolStripMenuItem});
            this.menuMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuMainForm.Name = "menuMainForm";
            this.menuMainForm.Size = new System.Drawing.Size(944, 24);
            this.menuMainForm.TabIndex = 0;
            this.menuMainForm.Text = "menuStrip1";
            // 
            // menuItem
            // 
            this.menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAdd,
            this.menuItemView});
            this.menuItem.Name = "menuItem";
            this.menuItem.Size = new System.Drawing.Size(43, 20);
            this.menuItem.Text = "Item";
            // 
            // menuItemAdd
            // 
            this.menuItemAdd.Name = "menuItemAdd";
            this.menuItemAdd.Size = new System.Drawing.Size(99, 22);
            this.menuItemAdd.Text = "Add";
            this.menuItemAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuItemView
            // 
            this.menuItemView.Name = "menuItemView";
            this.menuItemView.Size = new System.Drawing.Size(99, 22);
            this.menuItemView.Text = "View";
            this.menuItemView.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // menuDataBase
            // 
            this.menuDataBase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDataBaseChange,
            this.menuDataBaseRefresh,
            this.menuDataBaseImport});
            this.menuDataBase.Name = "menuDataBase";
            this.menuDataBase.Size = new System.Drawing.Size(67, 20);
            this.menuDataBase.Text = "Database";
            // 
            // menuDataBaseChange
            // 
            this.menuDataBaseChange.Name = "menuDataBaseChange";
            this.menuDataBaseChange.Size = new System.Drawing.Size(180, 22);
            this.menuDataBaseChange.Text = "Change";
            this.menuDataBaseChange.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // menuDataBaseRefresh
            // 
            this.menuDataBaseRefresh.Enabled = false;
            this.menuDataBaseRefresh.Name = "menuDataBaseRefresh";
            this.menuDataBaseRefresh.Size = new System.Drawing.Size(180, 22);
            this.menuDataBaseRefresh.Text = "Refresh";
            this.menuDataBaseRefresh.Visible = false;
            this.menuDataBaseRefresh.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
            // 
            // menuDataBaseImport
            // 
            this.menuDataBaseImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDataBaseImportDevices,
            this.menuDataBaseImportUsers});
            this.menuDataBaseImport.Name = "menuDataBaseImport";
            this.menuDataBaseImport.Size = new System.Drawing.Size(180, 22);
            this.menuDataBaseImport.Text = "Import";
            // 
            // menuDataBaseImportDevices
            // 
            this.menuDataBaseImportDevices.Name = "menuDataBaseImportDevices";
            this.menuDataBaseImportDevices.Size = new System.Drawing.Size(180, 22);
            this.menuDataBaseImportDevices.Text = "Devices";
            this.menuDataBaseImportDevices.Click += new System.EventHandler(this.menuDataBaseImportDevices_Click);
            // 
            // menuDataBaseImportUsers
            // 
            this.menuDataBaseImportUsers.Name = "menuDataBaseImportUsers";
            this.menuDataBaseImportUsers.Size = new System.Drawing.Size(180, 22);
            this.menuDataBaseImportUsers.Text = "Users";
            this.menuDataBaseImportUsers.Click += new System.EventHandler(this.menuDataBaseImportUsers_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewCloset,
            this.menuViewDevices,
            this.menuViewUsers,
            this.menuViewChangeLog});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "View";
            // 
            // menuViewCloset
            // 
            this.menuViewCloset.Name = "menuViewCloset";
            this.menuViewCloset.Size = new System.Drawing.Size(160, 22);
            this.menuViewCloset.Text = "Closet Inventory";
            this.menuViewCloset.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // menuViewDevices
            // 
            this.menuViewDevices.Name = "menuViewDevices";
            this.menuViewDevices.Size = new System.Drawing.Size(160, 22);
            this.menuViewDevices.Text = "Devices";
            this.menuViewDevices.Click += new System.EventHandler(this.menuViewDevices_Click);
            // 
            // menuViewUsers
            // 
            this.menuViewUsers.Name = "menuViewUsers";
            this.menuViewUsers.Size = new System.Drawing.Size(160, 22);
            this.menuViewUsers.Text = "Users";
            this.menuViewUsers.Click += new System.EventHandler(this.usersToolStripMenuItem1_Click);
            // 
            // menuViewChangeLog
            // 
            this.menuViewChangeLog.Name = "menuViewChangeLog";
            this.menuViewChangeLog.Size = new System.Drawing.Size(160, 22);
            this.menuViewChangeLog.Text = "Change Log";
            this.menuViewChangeLog.Click += new System.EventHandler(this.changeLogToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // dgInventoryData
            // 
            this.dgInventoryData.AllowUserToAddRows = false;
            this.dgInventoryData.AllowUserToDeleteRows = false;
            this.dgInventoryData.AllowUserToResizeColumns = false;
            this.dgInventoryData.AllowUserToResizeRows = false;
            this.dgInventoryData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInventoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventoryData.Location = new System.Drawing.Point(12, 57);
            this.dgInventoryData.Name = "dgInventoryData";
            this.dgInventoryData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgInventoryData.Size = new System.Drawing.Size(920, 547);
            this.dgInventoryData.TabIndex = 1;
            // 
            // lblCurrentDB
            // 
            this.lblCurrentDB.AutoSize = true;
            this.lblCurrentDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDB.Location = new System.Drawing.Point(12, 29);
            this.lblCurrentDB.Name = "lblCurrentDB";
            this.lblCurrentDB.Size = new System.Drawing.Size(117, 20);
            this.lblCurrentDB.TabIndex = 4;
            this.lblCurrentDB.Text = "Connected To: ";
            // 
            // lblViewing
            // 
            this.lblViewing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblViewing.AutoSize = true;
            this.lblViewing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewing.Location = new System.Drawing.Point(748, 29);
            this.lblViewing.Name = "lblViewing";
            this.lblViewing.Size = new System.Drawing.Size(186, 20);
            this.lblViewing.TabIndex = 5;
            this.lblViewing.Text = "Viewing: Closet Inventory";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 616);
            this.Controls.Add(this.lblViewing);
            this.Controls.Add(this.lblCurrentDB);
            this.Controls.Add(this.dgInventoryData);
            this.Controls.Add(this.menuMainForm);
            this.MainMenuStrip = this.menuMainForm;
            this.Name = "formMain";
            this.Text = "Inventory Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onClose);
            this.menuMainForm.ResumeLayout(false);
            this.menuMainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventoryData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMainForm;
        private System.Windows.Forms.ToolStripMenuItem menuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdd;
        private System.Windows.Forms.DataGridView dgInventoryData;
        private System.Windows.Forms.ToolStripMenuItem menuItemView;
        private System.Windows.Forms.ToolStripMenuItem menuDataBase;
        private System.Windows.Forms.ToolStripMenuItem menuDataBaseChange;
        private System.Windows.Forms.ToolStripMenuItem menuDataBaseRefresh;
        private System.Windows.Forms.Label lblCurrentDB;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuViewCloset;
        private System.Windows.Forms.ToolStripMenuItem menuViewDevices;
        private System.Windows.Forms.Label lblViewing;
        private System.Windows.Forms.ToolStripMenuItem menuViewUsers;
        private System.Windows.Forms.ToolStripMenuItem menuViewChangeLog;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDataBaseImport;
        private System.Windows.Forms.ToolStripMenuItem menuDataBaseImportDevices;
        private System.Windows.Forms.ToolStripMenuItem menuDataBaseImportUsers;
    }
}

