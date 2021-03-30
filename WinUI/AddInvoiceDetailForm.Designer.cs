namespace WinUI
{
    partial class AddInvoiceDetailForm
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
            this.txtQtty = new System.Windows.Forms.TextBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblQtty = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblOdservations = new System.Windows.Forms.Label();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtQtty
            // 
            this.txtQtty.Location = new System.Drawing.Point(219, 46);
            this.txtQtty.Name = "txtQtty";
            this.txtQtty.Size = new System.Drawing.Size(100, 20);
            this.txtQtty.TabIndex = 0;
            this.txtQtty.TextChanged += new System.EventHandler(this.TxtQtty_TextChanged);
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(71, 45);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(121, 21);
            this.cmbItem.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(350, 46);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 2;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.TxtUnitPrice_TextChanged);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(71, 26);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(67, 13);
            this.lblItem.TabIndex = 3;
            this.lblItem.Text = "Nume Articol";
            // 
            // lblQtty
            // 
            this.lblQtty.AutoSize = true;
            this.lblQtty.Location = new System.Drawing.Point(216, 26);
            this.lblQtty.Name = "lblQtty";
            this.lblQtty.Size = new System.Drawing.Size(49, 13);
            this.lblQtty.TabIndex = 4;
            this.lblQtty.Text = "Cantitate";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(347, 28);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(57, 13);
            this.lblUnitPrice.TabIndex = 5;
            this.lblUnitPrice.Text = "Pret Unitar";
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(71, 100);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(75, 23);
            this.btnAddDetail.TabIndex = 6;
            this.btnAddDetail.Text = "Adauga";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.BtnAddDetail_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(465, 46);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 8;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(462, 30);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(34, 13);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Suma";
            // 
            // lblOdservations
            // 
            this.lblOdservations.AutoSize = true;
            this.lblOdservations.Location = new System.Drawing.Point(593, 26);
            this.lblOdservations.Name = "lblOdservations";
            this.lblOdservations.Size = new System.Drawing.Size(54, 13);
            this.lblOdservations.TabIndex = 10;
            this.lblOdservations.Text = "Observatii";
            // 
            // txtObservations
            // 
            this.txtObservations.Location = new System.Drawing.Point(596, 45);
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(100, 20);
            this.txtObservations.TabIndex = 11;
            // 
            // AddInvoiceDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtObservations);
            this.Controls.Add(this.lblOdservations);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblQtty);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.txtQtty);
            this.Name = "AddInvoiceDetailForm";
            this.Text = "AddInvoiceDetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQtty;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblQtty;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblOdservations;
        private System.Windows.Forms.TextBox txtObservations;
    }
}