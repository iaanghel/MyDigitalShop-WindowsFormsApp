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
    public partial class AddAddressForm : Form
    {
        int id;
        ClientAddressForm parent;
        public AddAddressForm()
        {
            InitializeComponent();
        }
        public AddAddressForm(int _id, ClientAddressForm owner )
        {
            id = _id;
            parent = owner;
            InitializeComponent();
            BLAddress bLAddress = new BLAddress();
            List<CityModel> cities = bLAddress.GetCity();
            List<CountyModel> county = bLAddress.GetCounty();


            cmbCountyName.DataSource = county;
            cmbCountyName.DisplayMember = "CountyName";
            
            //cmbCountyName.ValueMember.


            cmbCityName.DataSource = cities;
            cmbCityName.DisplayMember = "CityName";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //ClientAddressForm clientAddressForm = new ClientAddressForm(id);
            //clientAddressForm.Show();

            this.Hide();
            parent.Show();
        }

        private void BtnAddAddress_Click(object sender, EventArgs e)
        {

            CityModel city = (CityModel)cmbCityName.SelectedItem;
            CountyModel county = (CountyModel)cmbCountyName.SelectedItem;
            //cmbCityName.SelectedItem.
            //MessageBox.Show(city.CityId.ToString());
            int clientId = id;
            int cityId = city.CityId;
            int countyId = county.CountyId;
            string cityName = city.CityName;
            string countyName = county.CountyName;
            string streetName = txtStreetName.Text;
            string streetNo = txtStreetNo.Text;
            BLAddress bl = new BLAddress();
            parent.RefreshGridAdd(bl.GetAddress(-1,cityName, countyName, streetName, streetNo));
            //bl.AddAddress(clientId, cityId, countyId, streetName, streetNo);
            //MessageBox.Show("Adresa a fost adaugata cu succes.");
        }
    }
}
