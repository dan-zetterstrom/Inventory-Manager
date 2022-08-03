namespace Inventory_Manager
{
    partial class formChangeDB
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
            this.lblCurrentDB = new System.Windows.Forms.Label();
            this.txtCurrentDB = new System.Windows.Forms.TextBox();
            this.lblNewDB = new System.Windows.Forms.Label();
            this.txtNewDB = new System.Windows.Forms.TextBox();
            this.lblNewUN = new System.Windows.Forms.Label();
            this.txtNewUN = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.cmdFinish = new System.Windows.Forms.Button();
            this.cmdTestConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentDB
            // 
            this.lblCurrentDB.AutoSize = true;
            this.lblCurrentDB.Location = new System.Drawing.Point(12, 19);
            this.lblCurrentDB.Name = "lblCurrentDB";
            this.lblCurrentDB.Size = new System.Drawing.Size(65, 13);
            this.lblCurrentDB.TabIndex = 0;
            this.lblCurrentDB.Text = "Current DB: ";
            // 
            // txtCurrentDB
            // 
            this.txtCurrentDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentDB.Enabled = false;
            this.txtCurrentDB.Location = new System.Drawing.Point(83, 16);
            this.txtCurrentDB.Name = "txtCurrentDB";
            this.txtCurrentDB.Size = new System.Drawing.Size(259, 20);
            this.txtCurrentDB.TabIndex = 1;
            // 
            // lblNewDB
            // 
            this.lblNewDB.AutoSize = true;
            this.lblNewDB.Location = new System.Drawing.Point(12, 52);
            this.lblNewDB.Name = "lblNewDB";
            this.lblNewDB.Size = new System.Drawing.Size(96, 13);
            this.lblNewDB.TabIndex = 2;
            this.lblNewDB.Text = "New DB IP/Name:";
            // 
            // txtNewDB
            // 
            this.txtNewDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewDB.Location = new System.Drawing.Point(111, 49);
            this.txtNewDB.Name = "txtNewDB";
            this.txtNewDB.Size = new System.Drawing.Size(231, 20);
            this.txtNewDB.TabIndex = 2;
            // 
            // lblNewUN
            // 
            this.lblNewUN.AutoSize = true;
            this.lblNewUN.Location = new System.Drawing.Point(12, 86);
            this.lblNewUN.Name = "lblNewUN";
            this.lblNewUN.Size = new System.Drawing.Size(83, 13);
            this.lblNewUN.TabIndex = 4;
            this.lblNewUN.Text = "New Username:";
            // 
            // txtNewUN
            // 
            this.txtNewUN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewUN.Location = new System.Drawing.Point(101, 83);
            this.txtNewUN.Name = "txtNewUN";
            this.txtNewUN.Size = new System.Drawing.Size(241, 20);
            this.txtNewUN.TabIndex = 3;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(12, 121);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(81, 13);
            this.lblNewPass.TabIndex = 6;
            this.lblNewPass.Text = "New Password:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPass.Location = new System.Drawing.Point(99, 118);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(243, 20);
            this.txtNewPass.TabIndex = 4;
            // 
            // cmdFinish
            // 
            this.cmdFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFinish.Location = new System.Drawing.Point(267, 162);
            this.cmdFinish.Name = "cmdFinish";
            this.cmdFinish.Size = new System.Drawing.Size(75, 23);
            this.cmdFinish.TabIndex = 6;
            this.cmdFinish.Text = "Finish";
            this.cmdFinish.UseVisualStyleBackColor = true;
            this.cmdFinish.Click += new System.EventHandler(this.cmdFinish_Click);
            // 
            // cmdTestConnection
            // 
            this.cmdTestConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdTestConnection.Location = new System.Drawing.Point(15, 162);
            this.cmdTestConnection.Name = "cmdTestConnection";
            this.cmdTestConnection.Size = new System.Drawing.Size(124, 23);
            this.cmdTestConnection.TabIndex = 5;
            this.cmdTestConnection.Text = "Test Connection";
            this.cmdTestConnection.UseVisualStyleBackColor = true;
            this.cmdTestConnection.Click += new System.EventHandler(this.cmdTestConnection_Click);
            // 
            // formChangeDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 194);
            this.Controls.Add(this.cmdTestConnection);
            this.Controls.Add(this.cmdFinish);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.txtNewUN);
            this.Controls.Add(this.lblNewUN);
            this.Controls.Add(this.txtNewDB);
            this.Controls.Add(this.lblNewDB);
            this.Controls.Add(this.txtCurrentDB);
            this.Controls.Add(this.lblCurrentDB);
            this.Name = "formChangeDB";
            this.Text = "Change Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentDB;
        private System.Windows.Forms.TextBox txtCurrentDB;
        private System.Windows.Forms.Label lblNewDB;
        private System.Windows.Forms.TextBox txtNewDB;
        private System.Windows.Forms.Label lblNewUN;
        private System.Windows.Forms.TextBox txtNewUN;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button cmdFinish;
        private System.Windows.Forms.Button cmdTestConnection;
    }
}