using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class MainMenuForm : Form
    {
        int userId;
        public MainMenuForm()
        {
            InitializeComponent();
        }
        public MainMenuForm(int _id)
        {
            userId = _id;
            InitializeComponent();
        }


        private void BtnPartner_Click(object sender, EventArgs e)
        {
            ClientForm partnerForm = new ClientForm();
            partnerForm.Show();
            this.Hide();
            partnerForm.FormClosed += PartnerForm_FormClosed;



        }

        private void PartnerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnInvoice_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm(userId);
            invoiceForm.Show();
            this.Hide();
            invoiceForm.FormClosed += InvoiceForm_FormClosed;

        }

        private void InvoiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            this.Hide();
            logInForm.Show();
            
        }
    }
}
