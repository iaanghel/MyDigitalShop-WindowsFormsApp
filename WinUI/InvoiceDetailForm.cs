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

    public partial class InvoiceDetailForm : Form
    {
        int invoiceId;
        int userId;
        //public invoicedetailform(int _id, int _userid)
        //{
        //    initializecomponent();
        //    userid = _userid;
        //    invoiceid = _id;
        //    blclient blclient = new blclient();
        //    cmbclientfullname.datasource = blclient.getclientfullname(0);
        //    cmbclientfullname.displaymember = "clientfullname";
        //}
        public InvoiceDetailForm(int _id, int _userId)
        {
            InitializeComponent();
            //userId = _userId;
            invoiceId = _id;
            userId = _userId;

            BLInvoice bLInvoice = new BLInvoice();
            List<DisplayInvoiceModel> list = bLInvoice.GetDisplayInvoice(invoiceId, "", DateTime.Now, DateTime.Now, "");
            DisplayInvoiceModel displayInvoiceModel = new DisplayInvoiceModel();
            if (list.Count >0)
                displayInvoiceModel =  list[0];
            //txtAddress.Text = displayInvoiceModel.Address;
            //txtClientFullName.Text = displayInvoiceModel.ClientFullName;
            txtInvoiceNumber.Text = displayInvoiceModel.InvoiceNumber;
            dateInvoice.Value = (displayInvoiceModel.InvoiceDate == DateTime.Parse("1/1/0001 12:00:00 AM")) ? DateTime.Now : displayInvoiceModel.InvoiceDate;

            BLClient bLClient = new BLClient();
            List<ClientFullNameModel> clients = bLClient.GetClientFullName(0);
            cmbClientFullName.DataSource = clients;

            

            ClientFullNameModel clientFullName = bLClient.GetClientFullName(displayInvoiceModel.ClientId)[0];

            //int index = clients.IndexOf(clientFullName);

            int index = clients.FindIndex(a => a.ClientId == clientFullName.ClientId);



            cmbClientFullName.SelectedIndex = index;
            //MessageBox.Show(cmbClientFullName.SelectedIndex.ToString());
            //cmbClientFullName.

            //MessageBox.Show(cmbClientFullName.SelectedItem.ClientId);

            //cmbClientFullName.

            cmbClientFullName.DisplayMember = "ClientFullName";
            //cmbClientFullName.DisplayMember = "ClientSurname";
            //txtInvoiceDate.Text = displayInvoiceModel.InvoiceDate.Year.ToString()+"-"+ displayInvoiceModel.InvoiceDate.Month.ToString()+"-"+ displayInvoiceModel.InvoiceDate.Day.ToString();
            txtObservations.Text = displayInvoiceModel.Observations;
            BLInvoiceDetail bLInvoiceDetail = new BLInvoiceDetail();

            dataGridDetails.DataSource = bLInvoiceDetail.GetInvoiceDetail(invoiceId);

            dataGridDetails.Columns["InvoiceDetailId"].Visible = false;
            dataGridDetails.Columns["ItemId"].Visible = false;
            dataGridDetails.Columns["InvoiceId"].Visible = false;
            dataGridDetails.Columns["Status"].Visible = false;
            dataGridDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void RefreshAdd(InvoiceDetailModel detail)
        {
            List<InvoiceDetailModel> list = new List<InvoiceDetailModel>();
            //BLAddress bLAddress = new BLAddress();
            for (int i = 0; i < dataGridDetails.Rows.Count; i++)
            {
                InvoiceDetailModel details = new InvoiceDetailModel();
                details = (InvoiceDetailModel)dataGridDetails.Rows[i].DataBoundItem;
                //addressModel.status = 1;
                list.Add(details);

            }

            //list = bLAddress.Address(id);
            //address.status = 1;
            //address.ClientAddressId = -1;

            list.Add(detail);
            //MessageBox.Show(address.ClientAddressId.ToString());
            dataGridDetails.DataSource = list;
            dataGridDetails.Columns["InvoiceDetailId"].Visible = false;
            dataGridDetails.Columns["ItemId"].Visible = false;
            dataGridDetails.Columns["InvoiceId"].Visible = false;
            dataGridDetails.Columns["Status"].Visible = false;
            dataGridDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void RefreshUpdate(InvoiceDetailModel detail)
        {
            List<InvoiceDetailModel> list = new List<InvoiceDetailModel>();
            
            for (int i = 0; i < dataGridDetails.Rows.Count; i++)
            {
                InvoiceDetailModel detailModel = new InvoiceDetailModel();
                detailModel = (InvoiceDetailModel)dataGridDetails.Rows[i].DataBoundItem;
                
                if (detailModel.InvoiceDetailId == detail.InvoiceDetailId)
                {
                    list.Add(detail);
                }
                else
                {
                    list.Add(detailModel);
                }

            }


            dataGridDetails.DataSource = list;
            dataGridDetails.Columns["InvoiceDetailId"].Visible = false;
            dataGridDetails.Columns["ItemId"].Visible = false;
            dataGridDetails.Columns["InvoiceId"].Visible = false;
            dataGridDetails.Columns["Status"].Visible = false;
            dataGridDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public InvoiceDetailModel GetDetail()
        {
            InvoiceDetailModel invoiceDetail = (InvoiceDetailModel)dataGridDetails.SelectedRows[0].DataBoundItem;
            
            return invoiceDetail;
        }
        private void BtnAddDetails_Click(object sender, EventArgs e)
        {
            AddInvoiceDetailForm addInvoiceDetailForm = new AddInvoiceDetailForm(invoiceId,this);
            addInvoiceDetailForm.Show();
            this.Hide();
            addInvoiceDetailForm.FormClosed += AddInvoiceDetailForm_FormClosed;

        }

        private void AddInvoiceDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm();
            this.Hide();
            invoiceForm.Show();
            invoiceForm.FormClosed += InvoiceForm_FormClosed;
        }

        private void InvoiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save(invoiceId,userId);
        }

        private void CmbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbClientFullName_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLAddress bLAddress = new BLAddress();
            ClientFullNameModel clientFullName = (ClientFullNameModel)cmbClientFullName.SelectedItem;
            cmbAddress.DataSource = bLAddress.GetFullAddress(clientFullName.ClientId);
            cmbAddress.DisplayMember = "FullAddress";

        }
        private void Save(int invoiceId, int userId)
        {
            BLInvoice bLInvoice = new BLInvoice();
            BLInvoiceDetail bLInvoiceDetail = new BLInvoiceDetail();
            if(userId != 0 & invoiceId == 0)
            {
                string invoiceNumber = txtInvoiceNumber.Text;
                DateTime invoiceDate = dateInvoice.Value;
                ClientFullNameModel clientFullName = (ClientFullNameModel)cmbClientFullName.SelectedItem;
                FullAddressModule fullAddress = (FullAddressModule)cmbAddress.SelectedItem;
                if (fullAddress == null)
                {
                    MessageBox.Show("Clientul nu are o adresa, adaugati o adresa clientului pentru a creea o factura!");
                    return;
                }
                int clientId = clientFullName.ClientId;
                int clientAddressId =  fullAddress.ClientAddressId;
                string observations = txtObservations.Text;

                MessageBox.Show(clientAddressId.ToString());

                bLInvoice.AddInvoice(invoiceNumber, invoiceDate, clientId, clientAddressId,userId, observations);
                MessageBox.Show("Factura a fost adaugata cu succes.");
                int invoiceIdValue = bLInvoice.GetInvoiceList(-1,"",DateTime.Now, DateTime.Now, invoiceNumber)[0].InvoiceId;
                Save(invoiceIdValue, 0);
            }
            if (userId == 0 & invoiceId != 0)
            {
                for (int i = 0; i < dataGridDetails.Rows.Count; i++)
                {
                    InvoiceDetailModel detail = new InvoiceDetailModel();
                    detail = (InvoiceDetailModel)dataGridDetails.Rows[i].DataBoundItem;
                    if (detail.Status == 1)
                    {
                        bLInvoiceDetail.AddDetail(invoiceId,detail.ItemName,detail.Qtty,detail.UnitPrice,detail.Amount,detail.Observations);

                    }
                    //INSERT
                    if (detail.Status == 2)
                    {
                        bLInvoiceDetail.UpdateDetail(invoiceId,detail.InvoiceDetailId, detail.ItemName,detail.Qtty,detail.UnitPrice,detail.Amount,detail.Observations);

                    }



                    //UPDATE
                    if (detail.Status == 3)
                    {
                        bLInvoiceDetail.DeleteDetail(invoiceId,detail.InvoiceDetailId);

                    }






                }
            }
        }

        private void BtnUpdateDetail_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteDetail_Click(object sender, EventArgs e)
        {
            if (dataGridDetails.SelectedRows.Count == 0)
            {
                MessageBox.Show("Trebuie sa selectati o adresa.");
                return;
            }
            //BLAddress bLAddress = new BLAddress();

            int index = dataGridDetails.SelectedRows[0].Index;

            //addressModel = (AddressModel)dataGridClientAddress.SelectedRows[0].DataBoundItem;
            //UpdateAddressForm updateAddressForm = new UpdateAddressForm(id, addressModel.ClientAddressId);
            if (MessageBox.Show("Sunteti sigur ca vreiti sa stergeti adresa selectata?", "Mesaj de avertizare!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                dataGridDetails.Rows[index].Cells[8].Value = 3;


                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridDetails.DataSource];
                currencyManager1.SuspendBinding();
                dataGridDetails.Rows[index].Visible = false;
                currencyManager1.ResumeBinding();

            }


        }
    }
}
