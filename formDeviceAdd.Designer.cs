namespace Inventory_Manager
{
    partial class formDeviceAdd
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
            this.lblSN = new System.Windows.Forms.Label();
            this.lblSNType = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.cmdAddDevice = new System.Windows.Forms.Button();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Location = new System.Drawing.Point(12, 36);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(76, 13);
            this.lblSN.TabIndex = 0;
            this.lblSN.Text = "Serial Number:";
            // 
            // lblSNType
            // 
            this.lblSNType.AutoSize = true;
            this.lblSNType.Location = new System.Drawing.Point(12, 69);
            this.lblSNType.Name = "lblSNType";
            this.lblSNType.Size = new System.Drawing.Size(106, 13);
            this.lblSNType.TabIndex = 1;
            this.lblSNType.Text = "Serial Number Type: ";
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Location = new System.Drawing.Point(12, 104);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(63, 13);
            this.lblHostName.TabIndex = 2;
            this.lblHostName.Text = "Host Name:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(12, 136);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 3;
            this.lblMake.Text = "Make:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 172);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 204);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category:";
            // 
            // txtSN
            // 
            this.txtSN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSN.Location = new System.Drawing.Point(101, 33);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(413, 20);
            this.txtSN.TabIndex = 6;
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(132, 69);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(382, 21);
            this.cbType.TabIndex = 7;
            // 
            // txtHostName
            // 
            this.txtHostName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHostName.Location = new System.Drawing.Point(88, 101);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(426, 20);
            this.txtHostName.TabIndex = 8;
            // 
            // txtMake
            // 
            this.txtMake.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMake.Location = new System.Drawing.Point(62, 133);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(452, 20);
            this.txtMake.TabIndex = 9;
            // 
            // txtModel
            // 
            this.txtModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModel.Location = new System.Drawing.Point(64, 169);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(450, 20);
            this.txtModel.TabIndex = 10;
            // 
            // cbCat
            // 
            this.cbCat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(77, 201);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(437, 21);
            this.cbCat.TabIndex = 11;
            // 
            // cmdAddDevice
            // 
            this.cmdAddDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAddDevice.Location = new System.Drawing.Point(439, 266);
            this.cmdAddDevice.Name = "cmdAddDevice";
            this.cmdAddDevice.Size = new System.Drawing.Size(75, 23);
            this.cmdAddDevice.TabIndex = 12;
            this.cmdAddDevice.Text = "Add";
            this.cmdAddDevice.UseVisualStyleBackColor = true;
            this.cmdAddDevice.Click += new System.EventHandler(this.cmdAddDevice_Click);
            // 
            // dtStartDate
            // 
            this.dtStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtStartDate.Location = new System.Drawing.Point(118, 233);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(396, 20);
            this.dtStartDate.TabIndex = 14;
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(12, 236);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(100, 13);
            this.lblDateStart.TabIndex = 15;
            this.lblDateStart.Text = "Service Start Date: ";
            // 
            // formDeviceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 301);
            this.Controls.Add(this.lblDateStart);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.cmdAddDevice);
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
            this.Name = "formDeviceAdd";
            this.Text = "Add Device";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label lblSNType;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Button cmdAddDevice;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label lblDateStart;
    }
}