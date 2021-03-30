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
    public partial class UpdateInvoiceDetailForm : Form
    {
        int invoiceId;
        InvoiceDetailForm parent;
        int invoiceDetailId;
        public UpdateInvoiceDetailForm(int _invoiceId,int _invoiceDetailId, InvoiceDetailForm owner )
        {
            InitializeComponent();
            invoiceId = _invoiceId;
            invoiceDetailId = _invoiceDetailId;
            parent = owner;
            BLInvoiceDetail bLInvoiceDetail = new BLInvoiceDetail();
            cmbItem.DataSource = bLInvoiceDetail.GetItem();
            cmbItem.DisplayMember = "ItemName";
            cmbItem.SelectedIndex = -1;

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            InvoiceDetailModel invoiceDetail = parent.GetDetail();
            ItemModel item = (ItemModel)cmbItem.SelectedItem;
            invoiceDetail.Amount = Convert.ToDouble(txtAmount.Text); ;
            invoiceDetail.ItemName = item.ItemName;
            //invoiceDetail.InvoiceId = invoiceId;
            invoiceDetail.Qtty = Convert.ToDouble(txtQtty.Text); ;
            invoiceDetail.UnitPrice = Convert.ToDouble(txtUnitPrice.Text); ;
            invoiceDetail.Observations = txtObservations.Text;
            invoiceDetail.Status = 2;
            parent.RefreshUpdate(invoiceDetail);
            parent.Refresh();
            parent.Show();
            this.Hide();

            parent.FormClosed += Parent_FormClosed;
        }

        private void Parent_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
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
        }
    }
}
