namespace WinUI
{
    partial class InvoiceDetailForm
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
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.btnDeleteDetail = new System.Windows.Forms.Button();
            this.dataGridDetails = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblClientFullName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblObservations = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dateInvoice = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbClientFullName = new System.Windows.Forms.ComboBox();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.btnUpdateDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(49, 40);
            this.txtInvoiceNumber.Multiline = true;
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(100, 20);
            this.txtInvoiceNumber.TabIndex = 0;
            // 
            // txtObservations
            // 
            this.txtObservations.Location = new System.Drawing.Point(592, 40);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(100, 20);
            this.txtObservations.TabIndex = 1;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(49, 79);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 35);
            this.btnDetails.TabIndex = 5;
            this.btnDetails.Text = "Vezi detalii";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(146, 79);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(75, 35);
            this.btnAddDetail.TabIndex = 6;
            this.btnAddDetail.Text = "Adauga Detaliu";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.BtnAddDetails_Click);
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.Location = new System.Drawing.Point(342, 79);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(75, 35);
            this.btnDeleteDetail.TabIndex = 8;
            this.btnDeleteDetail.Text = "Sterge Detaliu";
            this.btnDeleteDetail.UseVisualStyleBackColor = true;
            this.btnDeleteDetail.Click += new System.EventHandler(this.BtnDeleteDetail_Click);
            // 
            // dataGridDetails
            // 
            this.dataGridDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetails.Location = new System.Drawing.Point(49, 161);
            this.dataGridDetails.Name = "dataGridDetails";
            this.dataGridDetails.Size = new System.Drawing.Size(643, 127);
            this.dataGridDetails.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(49, 294);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(49, 21);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(77, 13);
            this.lblInvoiceNumber.TabIndex = 11;
            this.lblInvoiceNumber.Text = "Numar Factura";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(152, 20);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(69, 13);
            this.lblInvoiceDate.TabIndex = 12;
            this.lblInvoiceDate.Text = "Data Factura";
            // 
            // lblClientFullName
            // 
            this.lblClientFullName.AutoSize = true;
            this.lblClientFullName.Location = new System.Drawing.Point(339, 20);
            this.lblClientFullName.Name = "lblClientFullName";
            this.lblClientFullName.Size = new System.Drawing.Size(88, 13);
            this.lblClientFullName.TabIndex = 13;
            this.lblClientFullName.Text = "Numele Clientului";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(463, 20);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(40, 13);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Adresa";
            // 
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.Location = new System.Drawing.Point(589, 20);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(54, 13);
            this.lblObservations.TabIndex = 15;
            this.lblObservations.Text = "Observatii";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(52, 142);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(236, 13);
            this.lblMessage.TabIndex = 16;
            this.lblMessage.Text = "Selectati un detaliu pentru a modifica sau sterge.";
            // 
            // dateInvoice
            // 
            this.dateInvoice.Location = new System.Drawing.Point(155, 40);
            this.dateInvoice.Name = "dateInvoice";
            this.dateInvoice.Size = new System.Drawing.Size(181, 20);
            this.dateInvoice.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(441, 79);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 35);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Salveaza";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // cmbClientFullName
            // 
            this.cmbClientFullName.FormattingEnabled = true;
            this.cmbClientFullName.Location = new System.Drawing.Point(342, 40);
            this.cmbClientFullName.Name = "cmbClientFullName";
            this.cmbClientFullName.Size = new System.Drawing.Size(104, 21);
            this.cmbClientFullName.TabIndex = 19;
            this.cmbClientFullName.SelectedIndexChanged += new System.EventHandler(this.CmbClientFullName_SelectedIndexChanged);
            // 
            // cmbAddress
            // 
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Location = new System.Drawing.Point(466, 40);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(97, 21);
            this.cmbAddress.TabIndex = 20;
            this.cmbAddress.SelectedIndexChanged += new System.EventHandler(this.CmbAddress_SelectedIndexChanged);
            // 
            // btnUpdateDetail
            // 
            this.btnUpdateDetail.Location = new System.Drawing.Point(242, 79);
            this.btnUpdateDetail.Name = "btnUpdateDetail";
            this.btnUpdateDetail.Size = new System.Drawing.Size(75, 35);
            this.btnUpdateDetail.TabIndex = 21;
            this.btnUpdateDetail.Text = "Modifica Detaliu";
            this.btnUpdateDetail.UseVisualStyleBackColor = true;
            // 
            // InvoiceDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateDetail);
            this.Controls.Add(this.cmbAddress);
            this.Controls.Add(this.cmbClientFullName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateInvoice);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblObservations);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblClientFullName);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.lblInvoiceNumber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridDetails);
            this.Controls.Add(this.btnDeleteDetail);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.txtObservations);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Name = "InvoiceDetailForm";
            this.Text = "InvoiceDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Button btnDeleteDetail;
        private System.Windows.Forms.DataGridView dataGridDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblClientFullName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblObservations;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DateTimePicker dateInvoice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbClientFullName;
        private System.Windows.Forms.ComboBox cmbAddress;
        private System.Windows.Forms.Button btnUpdateDetail;
    }
}