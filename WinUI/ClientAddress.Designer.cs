namespace WinUI
{
    partial class ClientAddressForm
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
            this.dataGridClientAddress = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGetAddress = new System.Windows.Forms.Button();
            this.btnUpdateAddress = new System.Windows.Forms.Button();
            this.btnDeleteAddress = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientSurname = new System.Windows.Forms.TextBox();
            this.txtClientCode = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientSurname = new System.Windows.Forms.Label();
            this.lblClientCode = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMessageAdd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClientAddress
            // 
            this.dataGridClientAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientAddress.Location = new System.Drawing.Point(46, 84);
            this.dataGridClientAddress.Name = "dataGridClientAddress";
            this.dataGridClientAddress.Size = new System.Drawing.Size(482, 190);
            this.dataGridClientAddress.TabIndex = 0;
            this.dataGridClientAddress.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridClientAddress_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(593, 304);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 36);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnGetAddress
            // 
            this.btnGetAddress.Location = new System.Drawing.Point(12, 306);
            this.btnGetAddress.Name = "btnGetAddress";
            this.btnGetAddress.Size = new System.Drawing.Size(75, 37);
            this.btnGetAddress.TabIndex = 3;
            this.btnGetAddress.Text = "Obtine Adresa";
            this.btnGetAddress.UseVisualStyleBackColor = true;
            this.btnGetAddress.Click += new System.EventHandler(this.BtnGetAddress_Click);
            // 
            // btnUpdateAddress
            // 
            this.btnUpdateAddress.Location = new System.Drawing.Point(233, 305);
            this.btnUpdateAddress.Name = "btnUpdateAddress";
            this.btnUpdateAddress.Size = new System.Drawing.Size(84, 35);
            this.btnUpdateAddress.TabIndex = 4;
            this.btnUpdateAddress.Text = "Modifica Adresa";
            this.btnUpdateAddress.UseVisualStyleBackColor = true;
            this.btnUpdateAddress.Click += new System.EventHandler(this.BtnUpdateAddress_Click);
            // 
            // btnDeleteAddress
            // 
            this.btnDeleteAddress.Location = new System.Drawing.Point(340, 307);
            this.btnDeleteAddress.Name = "btnDeleteAddress";
            this.btnDeleteAddress.Size = new System.Drawing.Size(105, 35);
            this.btnDeleteAddress.TabIndex = 5;
            this.btnDeleteAddress.Text = "Sterge Adresa";
            this.btnDeleteAddress.UseVisualStyleBackColor = true;
            this.btnDeleteAddress.Click += new System.EventHandler(this.BtnDeleteAddress_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(43, 277);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(237, 13);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Selectati o adresa pentru a o modifica sau sterge";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(46, 42);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(100, 20);
            this.txtClientName.TabIndex = 7;
            // 
            // txtClientSurname
            // 
            this.txtClientSurname.Location = new System.Drawing.Point(165, 42);
            this.txtClientSurname.Name = "txtClientSurname";
            this.txtClientSurname.Size = new System.Drawing.Size(100, 20);
            this.txtClientSurname.TabIndex = 8;
            // 
            // txtClientCode
            // 
            this.txtClientCode.Location = new System.Drawing.Point(281, 42);
            this.txtClientCode.Name = "txtClientCode";
            this.txtClientCode.Size = new System.Drawing.Size(100, 20);
            this.txtClientCode.TabIndex = 9;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(392, 42);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNo.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(512, 42);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(46, 26);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(64, 13);
            this.lblClientName.TabIndex = 12;
            this.lblClientName.Text = "Nume Client";
            // 
            // lblClientSurname
            // 
            this.lblClientSurname.AutoSize = true;
            this.lblClientSurname.Location = new System.Drawing.Point(162, 26);
            this.lblClientSurname.Name = "lblClientSurname";
            this.lblClientSurname.Size = new System.Drawing.Size(84, 13);
            this.lblClientSurname.TabIndex = 13;
            this.lblClientSurname.Text = "Perenume Client";
            // 
            // lblClientCode
            // 
            this.lblClientCode.AutoSize = true;
            this.lblClientCode.Location = new System.Drawing.Point(278, 26);
            this.lblClientCode.Name = "lblClientCode";
            this.lblClientCode.Size = new System.Drawing.Size(55, 13);
            this.lblClientCode.TabIndex = 14;
            this.lblClientCode.Text = "Cod Client";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(389, 26);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(88, 13);
            this.lblPhoneNo.TabIndex = 15;
            this.lblPhoneNo.Text = "Numar de telefon";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(509, 26);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(115, 306);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(94, 35);
            this.btnAddAddress.TabIndex = 17;
            this.btnAddAddress.Text = "Adauga o adresa";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.BtnAddAddress_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(470, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 36);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Salveaza";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblMessageAdd
            // 
            this.lblMessageAdd.AutoSize = true;
            this.lblMessageAdd.Location = new System.Drawing.Point(46, 65);
            this.lblMessageAdd.Name = "lblMessageAdd";
            this.lblMessageAdd.Size = new System.Drawing.Size(0, 13);
            this.lblMessageAdd.TabIndex = 19;
            // 
            // ClientAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessageAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.lblClientCode);
            this.Controls.Add(this.lblClientSurname);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtClientCode);
            this.Controls.Add(this.txtClientSurname);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnDeleteAddress);
            this.Controls.Add(this.btnUpdateAddress);
            this.Controls.Add(this.btnGetAddress);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridClientAddress);
            this.Name = "ClientAddressForm";
            this.Text = "Adresa Client";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClientAddress;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGetAddress;
        private System.Windows.Forms.Button btnUpdateAddress;
        private System.Windows.Forms.Button btnDeleteAddress;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientSurname;
        private System.Windows.Forms.TextBox txtClientCode;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientSurname;
        private System.Windows.Forms.Label lblClientCode;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMessageAdd;
    }
}