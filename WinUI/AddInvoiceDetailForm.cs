using BusinessLogic;
using Entities;
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
    public partial class AddInvoiceDetailForm : Form
    {
        int invoiceId;
        InvoiceDetailForm parent;
        public AddInvoiceDetailForm()
        {
            InitializeComponent();
        }
        public AddInvoiceDetailForm(int _id , InvoiceDetailForm owner)
        {
            InitializeComponent();
            invoiceId = _id;
            parent = owner;
            BLInvoiceDetail bLInvoiceDetail = new BLInvoiceDetail();
            cmbItem.DataSource = bLInvoiceDetail.GetItem();
            cmbItem.DisplayMember = "ItemName";
        }



        private void Parent_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        

        private void BtnAddDetail_Click(object sender, EventArgs e)
        {
            ItemModel item = (ItemModel)cmbItem.SelectedItem;

            //string itemName = item.ItemName;
            double qtty = Convert.ToDouble(txtQtty.Text);
            double price = Convert.ToDouble(txtUnitPrice.Text);
            double amount = Convert.ToDouble(txtAmount.Text);
            string observations = txtObservations.Text;
            InvoiceDetailModel invoiceDetail = new InvoiceDetailModel();
            invoiceDetail.Amount = amount;
            invoiceDetail.ItemName = item.ItemName;
            invoiceDetail.InvoiceId = invoiceId;
            invoiceDetail.Qtty = qtty;
            invoiceDetail.UnitPrice = price;
            invoiceDetail.Observations = observations;
            invoiceDetail.Status = 1;
            parent.RefreshAdd(invoiceDetail);
            parent.Refresh();
            parent.Show();
            this.Hide();
            
            parent.FormClosed += Parent_FormClosed;

        }

        private void TxtQtty_TextChanged(object sender, EventArgs e)
        {
            double qtty;
            if (!String.IsNullOrEmpty(txtQtty.Text))
            {
                if (!Double.TryParse(txtQtty.Text, out qtty))
                {
                    MessageBox.Show("Trebuie sa introduceti un numar!");
                    return;

                }
            }
                

            if (!String.IsNullOrEmpty(txtQtty.Text) & !String.IsNullOrEmpty(txtUnitPrice.Text))
            {
                txtAmount.Text = (Convert.ToDouble(txtQtty.Text) * Convert.ToDouble(txtUnitPrice.Text)).ToString();
            }
            //txtAmount.Text = (Convert.ToDouble(txtQtty.Text) * Convert.ToDouble(txtUnitPrice.Text)).ToString(); 
        }

        private void TxtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            double unitPrice;
            if (!String.IsNullOrEmpty(txtUnitPrice.Text))
            {
                if (!Double.TryParse(txtUnitPrice.Text, out unitPrice))
                {
                    MessageBox.Show("Trebuie sa introduceti un numar!");
                    return;

                }
            }
                
            if (!String.IsNullOrEmpty(txtQtty.Text) & !String.IsNullOrEmpty(txtUnitPrice.Text))
            {
                txtAmount.Text = (Convert.ToDouble(txtQtty.Text) * Convert.ToDouble(txtUnitPrice.Text)).ToString();
            }
            //txtAmount.Text = (Convert.ToDouble(txtQtty.Text) * Convert.ToDouble(txtUnitPrice.Text)).ToString();
        }
    }
}
