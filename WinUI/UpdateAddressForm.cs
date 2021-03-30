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
    public partial class UpdateAddressForm : Form
    {
        int clientIdValue;
        int clientAddressIdValue;
        ClientAddressForm parent;
        public UpdateAddressForm()
        {
            InitializeComponent();
        }
        public UpdateAddressForm(int _clientId, int _clientAddressId, ClientAddressForm owner)
        {
            clientIdValue = _clientId;
            clientAddressIdValue = _clientAddressId;
            parent = owner;
            InitializeComponent();
            BLAddress bLAddress = new BLAddress();
            List<CityModel> cities = bLAddress.GetCity();
            List<CountyModel> county = bLAddress.GetCounty();


            cmbCounty.DataSource = county;
            cmbCounty.DisplayMember = "CountyName";
            cmbCounty.SelectedIndex = -1;




            cmbCity.DataSource = cities;
            cmbCity.DisplayMember = "CityName";
            cmbCity.SelectedIndex = -1;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CityModel city = (CityModel)cmbCity.SelectedItem;
            CountyModel county = (CountyModel)cmbCounty.SelectedItem;
            
            
            int clientId = clientIdValue;
            
            //MessageBox.Show(cmbCity.SelectedIndex.ToString());
            int clientAddressid = clientAddressIdValue;
            int cityId = (cmbCity.SelectedIndex == -1)? -1 :city.CityId;
            string cityName = (cmbCity.SelectedIndex == -1) ? null : city.CityName; 
            //MessageBox.Show(cityId.ToString());
            int countyId = (cmbCounty.SelectedIndex == -1) ? -1 : county.CountyId;
            string countyName = (cmbCounty.SelectedIndex == -1) ? null : county.CountyName; 
            string streetName = txtStreetName.Text;
            string streetNo = txtStreetNo.Text;
            BLAddress bl = new BLAddress();
            AddressModel address = bl.GetAddress(clientAddressid, cityName, countyName, streetName, streetNo);
            address.status = 2;
            parent.RefreshGridUpdate(address);
            //bl.UpdateAddress(clientId, clientAddressid, cityId, countyId, streetName, streetNo);
            //bl.AddAddress(clientId, cityId, countyId, streetName, streetNo);
            //MessageBox.Show("Adresa a fost modificata cu succes.");
        }
    }
}
