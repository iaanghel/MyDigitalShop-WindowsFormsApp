namespace WinUI
{
    partial class InvoiceForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridInvoice = new System.Windows.Forms.DataGridView();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.btnGetInvoice = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 308);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // dataGridInvoice
            // 
            this.dataGridInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInvoice.Location = new System.Drawing.Point(12, 138);
            this.dataGridInvoice.Name = "dataGridInvoice";
            this.dataGridInvoice.Size = new System.Drawing.Size(621, 150);
            this.dataGridInvoice.TabIndex = 2;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Location = new System.Drawing.Point(152, 45);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFrom.TabIndex = 3;
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(12, 45);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(100, 20);
            this.txtClientName.TabIndex = 4;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(564, 45);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(100, 20);
            this.txtInvoiceNumber.TabIndex = 5;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(12, 24);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(64, 13);
            this.lblClientName.TabIndex = 6;
            this.lblClientName.Text = "Nume Client";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(149, 24);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(30, 13);
            this.lblInvoiceDate.TabIndex = 7;
            this.lblInvoiceDate.Text = "de la";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(561, 24);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(77, 13);
            this.lblInvoiceNumber.TabIndex = 8;
            this.lblInvoiceNumber.Text = "Numar Factura";
            // 
            // btnGetInvoice
            // 
            this.btnGetInvoice.Location = new System.Drawing.Point(12, 69);
            this.btnGetInvoice.Name = "btnGetInvoice";
            this.btnGetInvoice.Size = new System.Drawing.Size(75, 30);
            this.btnGetInvoice.TabIndex = 9;
            this.btnGetInvoice.Text = "Cauta Factura";
            this.btnGetInvoice.UseVisualStyleBackColor = true;
            this.btnGetInvoice.Click += new System.EventHandler(this.BtnGetInvoice_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 113);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(213, 13);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "Apasati Butonul cauta pentru a afisa facturi.";
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(133, 71);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(92, 28);
            this.btnAddInvoice.TabIndex = 11;
            this.btnAddInvoice.Text = "Adauga Factura";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.BtnAddInvoice_Click);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Location = new System.Drawing.Point(258, 71);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(94, 28);
            this.btnDeleteInvoice.TabIndex = 13;
            this.btnDeleteInvoice.Text = "Sterge Factura";
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Location = new System.Drawing.Point(358, 45);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimeTo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "pana la";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeTo);
            this.Controls.Add(this.btnDeleteInvoice);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnGetInvoice);
            this.Controls.Add(this.lblInvoiceNumber);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.dataGridInvoice);
            this.Controls.Add(this.btnBack);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridInvoice;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Button btnGetInvoice;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.Label label1;
    }
}