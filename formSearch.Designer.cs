namespace Inventory_Manager
{
    partial class formSearch
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
            this.lblTable = new System.Windows.Forms.Label();
            this.lblColumn = new System.Windows.Forms.Label();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.cbColumns = new System.Windows.Forms.ComboBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.radLike = new System.Windows.Forms.RadioButton();
            this.radEquals = new System.Windows.Forms.RadioButton();
            this.radEquals2 = new System.Windows.Forms.RadioButton();
            this.radLike2 = new System.Windows.Forms.RadioButton();
            this.txtSearchTerm2 = new System.Windows.Forms.TextBox();
            this.lblTerm2 = new System.Windows.Forms.Label();
            this.cbColumns2 = new System.Windows.Forms.ComboBox();
            this.lblColumn2 = new System.Windows.Forms.Label();
            this.chkMoreSearch = new System.Windows.Forms.CheckBox();
            this.radAnd = new System.Windows.Forms.RadioButton();
            this.radOr = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(12, 26);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(74, 13);
            this.lblTable.TabIndex = 0;
            this.lblTable.Text = "Search Table:";
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Location = new System.Drawing.Point(12, 64);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(82, 13);
            this.lblColumn.TabIndex = 1;
            this.lblColumn.Text = "Search Column:";
            // 
            // cmdSearch
            // 
            this.cmdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSearch.Location = new System.Drawing.Point(604, 372);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(64, 23);
            this.cmdSearch.TabIndex = 2;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // cbTables
            // 
            this.cbTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Items.AddRange(new object[] {
            "Closet Inventory",
            "Devices",
            "Users",
            "Change Log"});
            this.cbTables.Location = new System.Drawing.Point(92, 23);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(576, 21);
            this.cbTables.TabIndex = 3;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
            // 
            // cbColumns
            // 
            this.cbColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColumns.FormattingEnabled = true;
            this.cbColumns.Location = new System.Drawing.Point(100, 61);
            this.cbColumns.Name = "cbColumns";
            this.cbColumns.Size = new System.Drawing.Size(568, 21);
            this.cbColumns.TabIndex = 4;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(12, 134);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(71, 13);
            this.lblTerm.TabIndex = 5;
            this.lblTerm.Text = "Search Term:";
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchTerm.Location = new System.Drawing.Point(89, 131);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(574, 20);
            this.txtSearchTerm.TabIndex = 6;
            // 
            // radLike
            // 
            this.radLike.AutoSize = true;
            this.radLike.Checked = true;
            this.radLike.Location = new System.Drawing.Point(7, 12);
            this.radLike.Name = "radLike";
            this.radLike.Size = new System.Drawing.Size(48, 17);
            this.radLike.TabIndex = 7;
            this.radLike.TabStop = true;
            this.radLike.Text = "LIKE";
            this.radLike.UseVisualStyleBackColor = true;
            // 
            // radEquals
            // 
            this.radEquals.AutoSize = true;
            this.radEquals.Location = new System.Drawing.Point(63, 12);
            this.radEquals.Name = "radEquals";
            this.radEquals.Size = new System.Drawing.Size(68, 17);
            this.radEquals.TabIndex = 8;
            this.radEquals.Text = "EQUALS";
            this.radEquals.UseVisualStyleBackColor = true;
            // 
            // radEquals2
            // 
            this.radEquals2.AutoSize = true;
            this.radEquals2.Enabled = false;
            this.radEquals2.Location = new System.Drawing.Point(59, 10);
            this.radEquals2.Name = "radEquals2";
            this.radEquals2.Size = new System.Drawing.Size(68, 17);
            this.radEquals2.TabIndex = 14;
            this.radEquals2.Text = "EQUALS";
            this.radEquals2.UseVisualStyleBackColor = true;
            // 
            // radLike2
            // 
            this.radLike2.AutoSize = true;
            this.radLike2.Checked = true;
            this.radLike2.Enabled = false;
            this.radLike2.Location = new System.Drawing.Point(3, 10);
            this.radLike2.Name = "radLike2";
            this.radLike2.Size = new System.Drawing.Size(48, 17);
            this.radLike2.TabIndex = 13;
            this.radLike2.TabStop = true;
            this.radLike2.Text = "LIKE";
            this.radLike2.UseVisualStyleBackColor = true;
            // 
            // txtSearchTerm2
            // 
            this.txtSearchTerm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchTerm2.Enabled = false;
            this.txtSearchTerm2.Location = new System.Drawing.Point(89, 319);
            this.txtSearchTerm2.Name = "txtSearchTerm2";
            this.txtSearchTerm2.Size = new System.Drawing.Size(574, 20);
            this.txtSearchTerm2.TabIndex = 12;
            // 
            // lblTerm2
            // 
            this.lblTerm2.AutoSize = true;
            this.lblTerm2.Enabled = false;
            this.lblTerm2.Location = new System.Drawing.Point(12, 322);
            this.lblTerm2.Name = "lblTerm2";
            this.lblTerm2.Size = new System.Drawing.Size(71, 13);
            this.lblTerm2.TabIndex = 11;
            this.lblTerm2.Text = "Search Term:";
            // 
            // cbColumns2
            // 
            this.cbColumns2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbColumns2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColumns2.Enabled = false;
            this.cbColumns2.FormattingEnabled = true;
            this.cbColumns2.Location = new System.Drawing.Point(100, 249);
            this.cbColumns2.Name = "cbColumns2";
            this.cbColumns2.Size = new System.Drawing.Size(568, 21);
            this.cbColumns2.TabIndex = 10;
            // 
            // lblColumn2
            // 
            this.lblColumn2.AutoSize = true;
            this.lblColumn2.Enabled = false;
            this.lblColumn2.Location = new System.Drawing.Point(12, 252);
            this.lblColumn2.Name = "lblColumn2";
            this.lblColumn2.Size = new System.Drawing.Size(82, 13);
            this.lblColumn2.TabIndex = 9;
            this.lblColumn2.Text = "Search Column:";
            // 
            // chkMoreSearch
            // 
            this.chkMoreSearch.AutoSize = true;
            this.chkMoreSearch.Location = new System.Drawing.Point(15, 174);
            this.chkMoreSearch.Name = "chkMoreSearch";
            this.chkMoreSearch.Size = new System.Drawing.Size(142, 17);
            this.chkMoreSearch.TabIndex = 15;
            this.chkMoreSearch.Text = "Additional Search Term?";
            this.chkMoreSearch.UseVisualStyleBackColor = true;
            this.chkMoreSearch.CheckedChanged += new System.EventHandler(this.chkMoreSearch_CheckedChanged);
            // 
            // radAnd
            // 
            this.radAnd.AutoSize = true;
            this.radAnd.Checked = true;
            this.radAnd.Enabled = false;
            this.radAnd.Location = new System.Drawing.Point(3, 7);
            this.radAnd.Name = "radAnd";
            this.radAnd.Size = new System.Drawing.Size(48, 17);
            this.radAnd.TabIndex = 16;
            this.radAnd.TabStop = true;
            this.radAnd.Text = "AND";
            this.radAnd.UseVisualStyleBackColor = true;
            // 
            // radOr
            // 
            this.radOr.AutoSize = true;
            this.radOr.Enabled = false;
            this.radOr.Location = new System.Drawing.Point(59, 7);
            this.radOr.Name = "radOr";
            this.radOr.Size = new System.Drawing.Size(41, 17);
            this.radOr.TabIndex = 17;
            this.radOr.Text = "OR";
            this.radOr.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radEquals);
            this.panel1.Controls.Add(this.radLike);
            this.panel1.Location = new System.Drawing.Point(7, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 43);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radAnd);
            this.panel2.Controls.Add(this.radOr);
            this.panel2.Location = new System.Drawing.Point(7, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 32);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radLike2);
            this.panel3.Controls.Add(this.radEquals2);
            this.panel3.Location = new System.Drawing.Point(7, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 38);
            this.panel3.TabIndex = 20;
            // 
            // formSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 407);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkMoreSearch);
            this.Controls.Add(this.txtSearchTerm2);
            this.Controls.Add(this.lblTerm2);
            this.Controls.Add(this.cbColumns2);
            this.Controls.Add(this.lblColumn2);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.cbColumns);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.lblColumn);
            this.Controls.Add(this.lblTable);
            this.Name = "formSearch";
            this.Text = "Search";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.ComboBox cbColumns;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.RadioButton radLike;
        private System.Windows.Forms.RadioButton radEquals;
        private System.Windows.Forms.RadioButton radEquals2;
        private System.Windows.Forms.RadioButton radLike2;
        private System.Windows.Forms.TextBox txtSearchTerm2;
        private System.Windows.Forms.Label lblTerm2;
        private System.Windows.Forms.ComboBox cbColumns2;
        private System.Windows.Forms.Label lblColumn2;
        private System.Windows.Forms.CheckBox chkMoreSearch;
        private System.Windows.Forms.RadioButton radAnd;
        private System.Windows.Forms.RadioButton radOr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}