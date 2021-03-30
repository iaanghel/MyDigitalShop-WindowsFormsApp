namespace WinUI
{
    partial class UpdateInvoiceDetailForm
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
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.txtQtty = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblObservations = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQtty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(58, 68);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(121, 21);
            this.cmbItem.TabIndex = 0;
            // 
            // txtQtty
            // 
            this.txtQtty.Location = new System.Drawing.Point(212, 69);
            this.txtQtty.Name = "txtQtty";
            this.txtQtty.Size = new System.Drawing.Size(100, 20);
            this.txtQtty.TabIndex = 1;
            this.txtQtty.TextChanged += new System.EventHandler(this.TxtQtty_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(493, 69);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(347, 69);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 3;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.TxtUnitPrice_TextChanged);
            // 
            // txtObservations
            // 
            this.txtObservations.Location = new System.Drawing.Point(629, 69);
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(100, 20);
            this.txtObservations.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(58, 154);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Modifica";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(58, 49);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(66, 13);
            this.lblItemName.TabIndex = 7;
            this.lblItemName.Text = "Nume articol";
            // 
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.Location = new System.Drawing.Point(626, 49);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(54, 13);
            this.lblObservations.TabIndex = 8;
            this.lblObservations.Text = "Observatii";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(490, 49);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(34, 13);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Suma";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(344, 49);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(57, 13);
            this.lblUnitPrice.TabIndex = 10;
            this.lblUnitPrice.Text = "Pret Unitar";
            // 
            // lblQtty
            // 
            this.lblQtty.AutoSize = true;
            this.lblQtty.Location = new System.Drawing.Point(209, 49);
            this.lblQtty.Name = "lblQtty";
            this.lblQtty.Size = new System.Drawing.Size(49, 13);
            this.lblQtty.TabIndex = 11;
            this.lblQtty.Text = "Cantitate";
            // 
            // UpdateInvoiceDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQtty);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblObservations);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtObservations);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtQtty);
            this.Controls.Add(this.cmbItem);
            this.Name = "UpdateInvoiceDetailForm";
            this.Text = "UpdateInvoiceDetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.TextBox txtQtty;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblObservations;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQtty;
    }
}