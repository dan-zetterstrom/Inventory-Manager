namespace Inventory_Manager
{
    partial class formCatSNAddDelete
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
            this.txtToAdd = new System.Windows.Forms.TextBox();
            this.lblToAdd = new System.Windows.Forms.Label();
            this.cmdExec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtToAdd
            // 
            this.txtToAdd.Location = new System.Drawing.Point(63, 26);
            this.txtToAdd.Name = "txtToAdd";
            this.txtToAdd.Size = new System.Drawing.Size(291, 20);
            this.txtToAdd.TabIndex = 0;
            // 
            // lblToAdd
            // 
            this.lblToAdd.AutoSize = true;
            this.lblToAdd.Location = new System.Drawing.Point(12, 29);
            this.lblToAdd.Name = "lblToAdd";
            this.lblToAdd.Size = new System.Drawing.Size(45, 13);
            this.lblToAdd.TabIndex = 1;
            this.lblToAdd.Text = "To Add:";
            // 
            // cmdExec
            // 
            this.cmdExec.Location = new System.Drawing.Point(279, 52);
            this.cmdExec.Name = "cmdExec";
            this.cmdExec.Size = new System.Drawing.Size(75, 23);
            this.cmdExec.TabIndex = 4;
            this.cmdExec.Text = "Exec";
            this.cmdExec.UseVisualStyleBackColor = true;
            this.cmdExec.Click += new System.EventHandler(this.cmdExec_Click);
            // 
            // formCatSNAddDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 85);
            this.Controls.Add(this.cmdExec);
            this.Controls.Add(this.lblToAdd);
            this.Controls.Add(this.txtToAdd);
            this.Name = "formCatSNAddDelete";
            this.Text = "Manage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToAdd;
        private System.Windows.Forms.Label lblToAdd;
        private System.Windows.Forms.Button cmdExec;
    }
}