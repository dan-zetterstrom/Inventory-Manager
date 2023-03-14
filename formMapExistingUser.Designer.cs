namespace Inventory_Manager
{
    partial class formMapExistingUser
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
            this.lblUsers = new System.Windows.Forms.Label();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.cmdMapUser = new System.Windows.Forms.Button();
            this.lblUserToMap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(12, 49);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(76, 13);
            this.lblUsers.TabIndex = 0;
            this.lblUsers.Text = "Existing Users:";
            // 
            // cbUsers
            // 
            this.cbUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(12, 65);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(415, 21);
            this.cbUsers.TabIndex = 1;
            // 
            // cmdMapUser
            // 
            this.cmdMapUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMapUser.Location = new System.Drawing.Point(352, 114);
            this.cmdMapUser.Name = "cmdMapUser";
            this.cmdMapUser.Size = new System.Drawing.Size(75, 23);
            this.cmdMapUser.TabIndex = 2;
            this.cmdMapUser.Text = "OK";
            this.cmdMapUser.UseVisualStyleBackColor = true;
            this.cmdMapUser.Click += new System.EventHandler(this.cmdMapUser_Click);
            // 
            // lblUserToMap
            // 
            this.lblUserToMap.AutoSize = true;
            this.lblUserToMap.Location = new System.Drawing.Point(12, 22);
            this.lblUserToMap.Name = "lblUserToMap";
            this.lblUserToMap.Size = new System.Drawing.Size(72, 13);
            this.lblUserToMap.TabIndex = 3;
            this.lblUserToMap.Text = "User To Map:";
            // 
            // formMapExistingUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 149);
            this.Controls.Add(this.lblUserToMap);
            this.Controls.Add(this.cmdMapUser);
            this.Controls.Add(this.cbUsers);
            this.Controls.Add(this.lblUsers);
            this.Name = "formMapExistingUser";
            this.Text = "Map Existing User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.Button cmdMapUser;
        private System.Windows.Forms.Label lblUserToMap;
    }
}