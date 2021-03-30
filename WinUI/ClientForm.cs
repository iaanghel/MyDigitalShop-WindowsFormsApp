using BusinessLogic;
using DataAccess;
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
    public partial class ClientForm : Form
    {
        //public int id;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnFilterPartner_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Selectati un client pentru a modifica sau sterge.\n" +
                "Pentru a vedea, modifica sau sterge adresa, dublu click perandul clientului ";
            string clientName = txtClientName.Text;
            string clientSurname = txtClientSurname.Text;
            string clientCode = txtClientCode.Text;
            string phoneNo = txtPhoneNo.Text;
            string email = txtEmail.Text;
            //int id = null;
            BLClient bLGetClient = new BLClient();
            List<ClientModule> list = bLGetClient.GetClientList(-1, clientName, clientSurname, clientCode, phoneNo, email);

            if(list.Count==0)
                MessageBox.Show("Nu sunt inregistrari cu parametrii introdusi!!!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

            dataGridClient.DataSource = list;
           
            dataGridClient.Columns["ClientId"].Visible = false;
            dataGridClient.Columns["ClientName"].HeaderText = "Nume Client";
            dataGridClient.Columns["ClientSurname"].HeaderText = "Prenume Client";
            dataGridClient.Columns["PhoneNo"].HeaderText = "Numar de telefon";
            dataGridClient.Columns["Email"].HeaderText = "Email";

            dataGridClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridClient.RowHeaderMouseDoubleClick += DataGridClient_RowHeaderMouseDoubleClick;
            //dataGridClient.RowHeaderMouseClick += DataGridClient_RowHeaderMouseClick;
            //dataGridClient.SelectedRows[0].Cells[0].Value;      
            //dataGridClient.Columns.GetFirstColumn.Hide();
        }

        
        private void DataGridClient_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //ClientAddressForm clientAddressForm = new ClientAddressForm();
            //clientAddressForm.Show();
            //this.Hide();
            //string clientName = textBoxPartener.Text;
            //BLGetClientList bLGetClient = new BLGetClientList();
            //int e1 = e.RowIndex;

            //List<ClientModule> list = bLGetClient.GetClientList(clientName);
            //this.id = Convert.ToInt32( dataGridClient.Rows[e.RowIndex].Cells[0].Value);
            //textBoxPartener.Text = this.id.ToString();
            this.Hide();
            ClientModule client = (ClientModule)dataGridClient.SelectedRows[0].DataBoundItem;
            ClientAddressForm clientAddressForm = new ClientAddressForm(client.ClientId);

            clientAddressForm.Show();
            clientAddressForm.FormClosed += ClientAddressForm_FormClosed;




        }

        private void ClientAddressForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnAddPartner_Click(object sender, EventArgs e)
        {

            this.Hide();
            //ClientModule client = (ClientModule)dataGridClient.SelectedRows[0].DataBoundItem;
            ClientAddressForm clientAddressForm = new ClientAddressForm();

            clientAddressForm.Show();
            clientAddressForm.FormClosed += ClientAddressForm_FormClosed;

            //AddClientForm addClientForm = new AddClientForm();
            //addClientForm.Show();
            //this.Hide();
            //addClientForm.FormClosed += AddClientForm_FormClosed;
        }

        private void AddClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void BtnModify_Click(object sender, EventArgs e)
        //{
        //    if (dataGridClient.SelectedRows.Count == 0)
        //    {
        //        MessageBox.Show("Trebuie sa selectati un client.");
        //        return;
        //    }
                
        //    else
        //    {
        //        ClientModule client = (ClientModule)dataGridClient.SelectedRows[0].DataBoundItem;
        //        UpdateClientForm updateClientForm = new UpdateClientForm(client.ClientId);
        //        updateClientForm.Show();
        //        this.Hide();
        //        updateClientForm.FormClosed += UpdateClientForm_FormClosed;
                
        //    }
            
           
        //}

        //private void UpdateClientForm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    this.Close();
        //}

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridClient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Trebuie sa selectati un client.");
                return;
            }
            BLClient bLClient = new BLClient();
            ClientModule client = (ClientModule)dataGridClient.SelectedRows[0].DataBoundItem;
            //UpdateClientForm updateClientForm = new UpdateClientForm(client.ClientId);
            if (MessageBox.Show("Sunteti sigur ca vreiti sa stergeti clientul " + client.ClientName + " " + client.ClientSurname + "?", "Mesaj de avertizare!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bLClient.DeleteClient(client.ClientId);
                MessageBox.Show(client.ClientName + " " + client.ClientSurname+" a fost sters cu succes.");
                List<ClientModule> list = bLClient.GetClientList(-1,"", "", "", "", "");
                dataGridClient.DataSource = list;
            }
            else
            {
                return;
            }

            
            














        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            //ClientModule client = (ClientModule)dataGridClient.SelectedRows[0].DataBoundItem;
            ClientAddressForm clientAddressForm = new ClientAddressForm();

            clientAddressForm.Show();
            clientAddressForm.FormClosed += ClientAddressForm_FormClosed;

        }
    }
}
