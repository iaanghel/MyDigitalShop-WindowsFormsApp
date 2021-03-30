using BusinessLogic;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class ClientAddressForm : Form
    {
        int id;
        public ClientAddressForm()
        {
            InitializeComponent();
            //MessageBox.Show(id.ToString());
            lblMessageAdd.Text = "Numele, prenumele si codul clientului sunt obligatorii";
        }
        public ClientAddressForm(int _id)
        {
            id = _id;
            InitializeComponent();
            BLAddress bLAddress = new BLAddress();
            dataGridClientAddress.DataSource = bLAddress.Address(id);
            BLClient bLClient = new BLClient();
            ClientModule client = new ClientModule();
            client = bLClient.GetClientList(id, "", "", "", "", "")[0];

            txtClientName.Text = client.ClientName;
            txtClientSurname.Text = client.ClientSurname;
            txtClientCode.Text = client.ClientCode;
            txtEmail.Text = client.Email;
            txtPhoneNo.Text = client.PhoneNo;

            dataGridClientAddress.Columns["ClientId"].Visible = false;
            dataGridClientAddress.Columns["ClientAddressId"].Visible = false;
            dataGridClientAddress.Columns["ClientName"].Visible = false;
            dataGridClientAddress.Columns["ClientSurname"].Visible = false;
            dataGridClientAddress.Columns["CityName"].HeaderText = "Oras";
            dataGridClientAddress.Columns["CountyName"].HeaderText = "Judet";
            dataGridClientAddress.Columns["StreetName"].HeaderText = "Nume Strada";
            dataGridClientAddress.Columns["StreetNo"].HeaderText = "Numar Strada";
            dataGridClientAddress.Columns["status"].Visible = false;

            dataGridClientAddress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void RefreshGridAdd(AddressModel address)
        {
            List<AddressModel> list = new List<AddressModel>();
            //BLAddress bLAddress = new BLAddress();
            for (int i = 0; i<dataGridClientAddress.Rows.Count;i++ )
            {
                AddressModel addressModel = new AddressModel();
                addressModel = (AddressModel)dataGridClientAddress.Rows[i].DataBoundItem;
                //addressModel.status = 1;
                list.Add(addressModel);

            }

            //list = bLAddress.Address(id);
            address.status = 1;
            //address.ClientAddressId = -1;

            list.Add(address);
            //MessageBox.Show(address.ClientAddressId.ToString());
            dataGridClientAddress.DataSource = list;

            dataGridClientAddress.Columns["ClientId"].Visible = false;
            dataGridClientAddress.Columns["ClientAddressId"].Visible = false;
            dataGridClientAddress.Columns["ClientName"].Visible = false;
            dataGridClientAddress.Columns["ClientSurname"].Visible = false;
            dataGridClientAddress.Columns["CityName"].HeaderText = "Oras";
            dataGridClientAddress.Columns["CountyName"].HeaderText = "Judet";
            dataGridClientAddress.Columns["StreetName"].HeaderText = "Nume Strada";
            dataGridClientAddress.Columns["StreetNo"].HeaderText = "Numar Strada";
            dataGridClientAddress.Columns["status"].Visible = false;
            dataGridClientAddress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void RefreshGridUpdate(AddressModel address)
        {
            List<AddressModel> list = new List<AddressModel>();
            //if(address.ClientAddressId == 0)
            //{
            //    MessageBox.Show("Adresa trebuie salvata pentru a fi modificata");
            //    return;
            //}

            //BLAddress bLAddress = new BLAddress();
            for (int i = 0; i < dataGridClientAddress.Rows.Count; i++)
            {
                AddressModel addressModel = new AddressModel();
                addressModel = (AddressModel)dataGridClientAddress.Rows[i].DataBoundItem;
                //addressModel.status = 2;
                if (addressModel.ClientAddressId == address.ClientAddressId)
                {
                    list.Add(address);
                }
                else
                {
                    list.Add(addressModel);
                }

            }

            //list = bLAddress.Address(id);
            //list.Add(address);
            dataGridClientAddress.DataSource = list;

            dataGridClientAddress.Columns["ClientId"].Visible = false;
            dataGridClientAddress.Columns["ClientAddressId"].Visible = false;
            dataGridClientAddress.Columns["ClientName"].Visible = false;
            dataGridClientAddress.Columns["status"].Visible = false;
            dataGridClientAddress.Columns["ClientSurname"].Visible = false;
            dataGridClientAddress.Columns["CityName"].HeaderText = "Oras";
            dataGridClientAddress.Columns["CountyName"].HeaderText = "Judet";
            dataGridClientAddress.Columns["StreetName"].HeaderText = "Nume Strada";
            dataGridClientAddress.Columns["StreetNo"].HeaderText = "Numar Strada";
            dataGridClientAddress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void DataGridClientAddress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        

        private void BtnGetAddress_Click(object sender, EventArgs e)
        {
            //ClientForm clientForm = new ClientForm();
            //int id = clientForm.id;
            //if (dataGridClientAddress.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Trebuie sa selectati o adresa.");
            //    return;
            //}

            BLAddress bLAddress = new BLAddress();

            dataGridClientAddress.DataSource = bLAddress.Address(id);
            dataGridClientAddress.Columns["ClientId"].Visible = false;
            dataGridClientAddress.Columns["ClientAddressId"].Visible = false;
            dataGridClientAddress.Columns["ClientName"].Visible = false;
            dataGridClientAddress.Columns["status"].Visible = false;
            dataGridClientAddress.Columns["ClientSurname"].Visible = false;
            dataGridClientAddress.Columns["CityName"].HeaderText = "Oras";
            dataGridClientAddress.Columns["CountyName"].HeaderText = "Judet";
            dataGridClientAddress.Columns["StreetName"].HeaderText = "Nume Strada";
            dataGridClientAddress.Columns["StreetNo"].HeaderText = "Numar Strada";
            dataGridClientAddress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //txtClientFullName.Text = id.ToString();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

            ClientForm partnerForm = new ClientForm();
            partnerForm.Show();
            this.Hide();
        }

        private void BtnUpdateAddress_Click(object sender, EventArgs e)
        {
            AddressModel addressModel = new AddressModel();
            if (dataGridClientAddress.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o adresa pentru a o modifica!");
                return;
            }
                
            addressModel = (AddressModel)dataGridClientAddress.SelectedRows[0].DataBoundItem;
            //MessageBox.Show(addressModel.ClientAddressId.ToString());
            if (addressModel.ClientAddressId == -1)
            {
                MessageBox.Show("Adresa trebuie salvata pentru a fi modificata");
                return;
            }
            UpdateAddressForm updateAddressForm = new UpdateAddressForm(id,addressModel.ClientAddressId,this);
            updateAddressForm.Show();
            //this.Hide();
            updateAddressForm.FormClosed += UpdateAddressForm_FormClosed;
        }

        private void UpdateAddressForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnDeleteAddress_Click(object sender, EventArgs e)
        {
            //List<AddressModel> list = new List<AddressModel>();
            if (dataGridClientAddress.SelectedRows.Count == 0)
            {
                MessageBox.Show("Trebuie sa selectati o adresa.");
                return;
            }
            //BLAddress bLAddress = new BLAddress();
            
            int index = dataGridClientAddress.SelectedRows[0].Index;
            
            //addressModel = (AddressModel)dataGridClientAddress.SelectedRows[0].DataBoundItem;
            //UpdateAddressForm updateAddressForm = new UpdateAddressForm(id, addressModel.ClientAddressId);
            if (MessageBox.Show("Sunteti sigur ca vreiti sa stergeti adresa selectata?", "Mesaj de avertizare!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                
                dataGridClientAddress.Rows[index].Cells[8].Value = 3;


                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridClientAddress.DataSource];
                currencyManager1.SuspendBinding();
                dataGridClientAddress.Rows[index].Visible = false;
                currencyManager1.ResumeBinding();
                
            }


        }



        private void BtnAddAddress_Click(object sender, EventArgs e)
        {
            AddAddressForm addAddressForm = new AddAddressForm(id, this);
            addAddressForm.Show();
            //this.Hide();
            addAddressForm.FormClosed += AddAddressForm_FormClosed;

        }

        private void AddAddressForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save(id);
            
        }
        public void Save(int id)
        {
            BLClient bl = new BLClient();
            if (id != 0)
            {


                List<ClientModule> listUpdate = bl.GetClientList(id, "", "", "", "", "");
                ClientModule client = listUpdate[0];
                string clientName = txtClientName.Text;
                string clientSurname = txtClientSurname.Text;
                string clientCode = txtClientCode.Text;
                string email = txtEmail.Text;
                string phoneNo = txtPhoneNo.Text;

                if (!(clientName == client.ClientName & clientSurname == client.ClientSurname & clientCode == client.ClientCode & email == client.Email & phoneNo == client.PhoneNo)  )
                {
                    foreach (char c in txtPhoneNo.Text.ToCharArray())
                    {
                        if (!(c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9'))
                        {
                            MessageBox.Show("Tnumarul de telefon trebuie sa contina doar cife.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                    if (!(new EmailAddressAttribute().IsValid(txtEmail.Text)) & !String.IsNullOrWhiteSpace(txtEmail.Text))
                    {
                        MessageBox.Show("Emailul trebuie sa fie valid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    //txtClientCode.TextChanged
                    bool status = false;
                    if (clientCode == client.ClientCode)
                    {
                        bl.UpdateClient(id, clientName, clientSurname, "", phoneNo, email, out status);
                    }
                    else
                    {
                        bl.UpdateClient(id, clientName, clientSurname, clientCode, phoneNo, email, out status);
                    }
                    //BLClient bl = new BLClient();
                    
                    if (status)
                        MessageBox.Show("Modificare reusita.");
                    else
                    {
                        MessageBox.Show("Codul de client exista deja!");
                        return;
                    }

                }




                
                BLAddress bLAddress = new BLAddress();
                //List<AddressModel> list= new List<AddressModel>();
                //list = bLAddress.Address(id);
                for (int i = 0; i < dataGridClientAddress.Rows.Count; i++)
                {
                    AddressModel addressModel = new AddressModel();
                    addressModel = (AddressModel)dataGridClientAddress.Rows[i].DataBoundItem;
                    if (addressModel.status == 1)
                    {
                        bLAddress.AddAddress(id, addressModel.CityName, addressModel.CountyName, addressModel.StreetName, addressModel.StreetNo);

                    }
                    //INSERT
                    if (addressModel.status == 2)
                    {
                        bLAddress.UpdateAddress(id, addressModel.ClientAddressId, addressModel.CityName, addressModel.CountyName, addressModel.StreetName, addressModel.StreetNo);

                    }



                    //UPDATE
                    if (addressModel.status == 3)
                    {
                        bLAddress.DeleteAddress(addressModel.ClientId, addressModel.ClientAddressId);

                    }






                }

            }
            else
            {
                if (String.IsNullOrWhiteSpace(txtClientName.Text))
                {
                    MessageBox.Show("Numele clientului este obligatoriu", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (String.IsNullOrWhiteSpace(txtClientSurname.Text))
                {
                    MessageBox.Show("Prenumele utilizatorului eate obligatoriu", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (String.IsNullOrWhiteSpace(txtClientCode.Text))
                {
                    MessageBox.Show("codul de client este obligatoriu", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (char c in txtPhoneNo.Text.ToCharArray())
                {
                    if (!(c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9'))
                    {
                        MessageBox.Show("Numarul de telefon trebuie sa contina doar cife.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                if (!(new EmailAddressAttribute().IsValid(txtEmail.Text)) & !String.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Emailul trebuie sa fie valid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string clientName = txtClientName.Text;
                string clientSurname = txtClientSurname.Text;
                string clientCode = txtClientCode.Text;
                string phoneNo = String.IsNullOrWhiteSpace(txtPhoneNo.Text) ? null : txtPhoneNo.Text;
                string email = String.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text; ;
                bool status = true;
                
                bl.AddClient(clientName, clientSurname, clientCode, phoneNo, email, out status);
                if (status)
                {
                    MessageBox.Show("Clientul " + clientName + " " + clientSurname + " a fost adaugat cu succes");
                    List<ClientModule> list = bl.GetClientList(-1, "", "", clientCode, "", "");
                    Save(list[0].ClientId);//RECURSIVITATE
                }
                    //MessageBox.Show("Clientul " + clientName + " " + clientSurname + " a fost adaugat cu succes");
                else
                {
                    MessageBox.Show("Codul de client exista deja!");
                }

            }

        }
    }
}
