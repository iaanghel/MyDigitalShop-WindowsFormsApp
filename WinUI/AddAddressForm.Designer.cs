namespace WinUI
{
    partial class AddAddressForm
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
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.txtStreetNo = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblStreetNo = new System.Windows.Forms.Label();
            this.cmbCountyName = new System.Windows.Forms.ComboBox();
            this.cmbCityName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(328, 56);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(100, 20);
            this.txtStreetName.TabIndex = 2;
            // 
            // txtStreetNo
            // 
            this.txtStreetNo.Location = new System.Drawing.Point(475, 56);
            this.txtStreetNo.Name = "txtStreetNo";
            this.txtStreetNo.Size = new System.Drawing.Size(100, 20);
            this.txtStreetNo.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(58, 155);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(58, 102);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(95, 28);
            this.btnAddAddress.TabIndex = 5;
            this.btnAddAddress.Text = "Adauga";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.BtnAddAddress_Click);
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(58, 37);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(33, 13);
            this.lblCounty.TabIndex = 6;
            this.lblCounty.Text = "Judet";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(188, 37);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 13);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "Oras";
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Location = new System.Drawing.Point(328, 37);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(69, 13);
            this.lblStreetName.TabIndex = 8;
            this.lblStreetName.Text = "Nume Strada";
            // 
            // lblStreetNo
            // 
            this.lblStreetNo.AutoSize = true;
            this.lblStreetNo.Location = new System.Drawing.Point(475, 37);
            this.lblStreetNo.Name = "lblStreetNo";
            this.lblStreetNo.Size = new System.Drawing.Size(72, 13);
            this.lblStreetNo.TabIndex = 9;
            this.lblStreetNo.Text = "Numar Strada";
            // 
            // cmbCountyName
            // 
            this.cmbCountyName.FormattingEnabled = true;
            this.cmbCountyName.Location = new System.Drawing.Point(61, 54);
            this.cmbCountyName.Name = "cmbCountyName";
            this.cmbCountyName.Size = new System.Drawing.Size(92, 21);
            this.cmbCountyName.TabIndex = 11;
            // 
            // cmbCityName
            // 
            this.cmbCityName.FormattingEnabled = true;
            this.cmbCityName.Location = new System.Drawing.Point(188, 54);
            this.cmbCityName.Name = "cmbCityName";
            this.cmbCityName.Size = new System.Drawing.Size(96, 21);
            this.cmbCityName.TabIndex = 12;
            // 
            // AddAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCityName);
            this.Controls.Add(this.cmbCountyName);
            this.Controls.Add(this.lblStreetNo);
            this.Controls.Add(this.lblStreetName);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtStreetNo);
            this.Controls.Add(this.txtStreetName);
            this.Name = "AddAddressForm";
            this.Text = "AddAddressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.TextBox txtStreetNo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblStreetNo;
        private System.Windows.Forms.ComboBox cmbCountyName;
        private System.Windows.Forms.ComboBox cmbCityName;
    }
}