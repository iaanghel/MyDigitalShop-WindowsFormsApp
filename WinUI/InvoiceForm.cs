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
    public partial class InvoiceForm : Form
    {
        int userId;
        public InvoiceForm()
        {
            InitializeComponent();
        }
        public InvoiceForm(int _id)
        {
            userId = _id;
            InitializeComponent();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnGetInvoice_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Selectati o factura pentru a sterge sau modifica";

            string clientName = txtClientName.Text;
            DateTime dateFrom = dateTimeFrom.Value;
            DateTime dateTo = dateTimeTo.Value;
            //MessageBox.Show(DateTime.Now.ToString());
            string invoiceNumber = txtInvoiceNumber.Text;

            BLInvoice bLInvoice = new BLInvoice();
            List<DisplayInvoiceModel> list = bLInvoice.GetDisplayInvoice(-1,clientName, dateFrom, dateTo, invoiceNumber);
            //dataGridInvoice.Columns["ClientId"].Visible = false;
            





            if (list.Count == 0)
                MessageBox.Show("Nu sunt inregistrari cu parametrii introdusi!!!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

            dataGridInvoice.DataSource = list;
            dataGridInvoice.Columns["ClientId"].Visible = false;
            dataGridInvoice.Columns["InvoiceId"].Visible = false;
            dataGridInvoice.Columns["InvoiceNumber"].HeaderText = "Numar Factura";
            dataGridInvoice.Columns["InvoiceDate"].HeaderText = "Data Factura";
            dataGridInvoice.Columns["ClientFullName"].HeaderText = "Nume Client";
            dataGridInvoice.Columns["Address"].HeaderText = "Adresa";
            dataGridInvoice.Columns["Observations"].HeaderText = "Observatii";
            dataGridInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridInvoice.RowHeaderMouseDoubleClick += DataGridInvoice_RowHeaderMouseDoubleClick;



            //dataGridInvoice.RowHeaderMouseDoubleClick += DataGridClient_RowHeaderMouseDoubleClick;
            //dataGridClient.RowHeaderMouseClick += DataGridClient_RowHeaderMouseClick;
            //dataGridClient.SelectedRows[0].Cells[0].Value;      
            //dataGridClient.Columns.GetFirstColumn.Hide();
        }

        private void DataGridInvoice_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplayInvoiceModel displayInvoiceModel = new DisplayInvoiceModel();
            displayInvoiceModel = (DisplayInvoiceModel)dataGridInvoice.SelectedRows[0].DataBoundItem;

            InvoiceDetailForm invoiceDetailForm = new InvoiceDetailForm(displayInvoiceModel.InvoiceId,0);
            invoiceDetailForm.Show();
            this.Hide();
            invoiceDetailForm.FormClosed += InvoiceDetailForm_FormClosed;
        }

        private void InvoiceDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnAddInvoice_Click(object sender, EventArgs e)
        {
            InvoiceDetailForm invoiceDetailForm = new InvoiceDetailForm(0,userId);
            invoiceDetailForm.Show();
            this.Hide();
            invoiceDetailForm.FormClosed += InvoiceDetailForm_FormClosed;
        }
    }
}

