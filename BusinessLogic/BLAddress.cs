using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLAddress
    {
        public List<FullAddressModule> GetFullAddress(int clientId)
        {
            List<FullAddressModule> fullAddresses = new List<FullAddressModule>();
            DAAddress dAAddress = new DAAddress();
            DataTable data = dAAddress.GetFullAddress(clientId);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                fullAddresses.Add(new FullAddressModule
                {
                    ClientAddressId = Convert.ToInt32(data.Rows[i]["ClientAddressId"]),

                    FullAddress = data.Rows[i]["FullAddress"].ToString(),


                });
            }

            return fullAddresses;
        }
        public List<AddressModel> Address(int id)
        {
            List<AddressModel> address = new List<AddressModel>();
            DAAddress aAddress = new DAAddress();
            DataTable data = aAddress.Address(id);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                address.Add(new AddressModel
                {
                    ClientId = Convert.ToInt32(data.Rows[i]["ClientId"]),
                    ClientAddressId = Convert.ToInt32(data.Rows[i]["ClientAddressId"]),
                    ClientName = data.Rows[i]["ClientName"].ToString(),
                    ClientSurname = data.Rows[i]["ClientSurName"].ToString(),
                    CityName = data.Rows[i]["CityName"].ToString(),
                    CountyName = data.Rows[i]["CountyName"].ToString(),
                    StreetName = data.Rows[i]["StreetName"].ToString(),
                    StreetNo = data.Rows[i]["StreetNo"].ToString(),

                });
            }

            return address;
        }
        public List<CityModel> GetCity()
        {
            List<CityModel> address = new List<CityModel>();
            DAAddress aAddress = new DAAddress();
            DataTable data = aAddress.GetCity();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                address.Add(new CityModel
                {
                    CityId = Convert.ToInt32(data.Rows[i]["CityId"]),
                    
                    CityName = data.Rows[i]["CityName"].ToString(),
                    

                });
            }

            return address;
        }
        public List<CountyModel> GetCounty()
        {
            List<CountyModel> address = new List<CountyModel>();
            DAAddress aAddress = new DAAddress();
            DataTable data = aAddress.GetCounty();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                address.Add(new CountyModel
                {
                    CountyId = Convert.ToInt32(data.Rows[i]["CountyId"]),

                    CountyName = data.Rows[i]["CountyName"].ToString(),


                });
            }

            return address;
        }
        public void AddAddress(int clientId, string cityName, string countyName, string streetName, string streetNo)
        {
            DAAddress da = new DAAddress();
            da.Add(clientId, cityName, countyName,  streetName,  streetNo);
        }
        public AddressModel GetAddress(int clientAddressId,string cityName, string countyName, string streetName, string streetNo)
        {
            AddressModel addressModel = new AddressModel();
            addressModel.CityName = cityName;
            addressModel.CountyName = countyName;
            addressModel.StreetName = streetName;
            addressModel.StreetNo = streetNo;
            addressModel.ClientAddressId = clientAddressId;


            return addressModel;

        }


        public void UpdateAddress(int clientId, int clientAddressId, string cityName, string countyName, string streetName, string streetNo)

        {
            DAAddress dAAddress = new DAAddress();
            dAAddress.Update(clientId, clientAddressId, cityName, countyName, streetName, streetNo);


        }
        public void DeleteAddress(int clientId, int clientAddressId)
        {
            DAAddress dAAddress = new DAAddress();
            dAAddress.Delete(clientId, clientAddressId);
        }
    }
}
