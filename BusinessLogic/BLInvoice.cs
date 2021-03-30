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
    public class BLInvoice
    {

        public void AddInvoice(string invoiceNumber, DateTime invoiceDate, int clientId, int clientAddressId, int userId, string observations)
        {
            DAInvoice dAInvoice = new DAInvoice();
            dAInvoice.Add( invoiceNumber,  invoiceDate,  clientId,  clientAddressId,  userId,  observations);

        }
        public List<InvoiceModel> GetInvoiceList(int invoiceId,string clientName, DateTime dateFrom,DateTime dateTo, string invoiceNumber)
        {
            List<InvoiceModel> invoice = new List<InvoiceModel>();
            DAInvoice dAInvoice = new DAInvoice();
            DataTable data = dAInvoice.GetInvoiceList(invoiceId, clientName, dateFrom, dateTo, invoiceNumber);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                invoice.Add(new InvoiceModel
                {
                    InvoiceId = Convert.ToInt32(data.Rows[i]["InvoiceId"]),
                    InvoiceNumber = data.Rows[i]["InvoiceNumber"].ToString(),
                    InvoiceDate = (DateTime)data.Rows[i]["InvoiceDate"],
                    ClientId = Convert.ToInt32(data.Rows[i]["ClientId"]),
                    ClientAddressId = Convert.ToInt32(data.Rows[i]["ClientAddressId"]),
                    UserId = Convert.ToInt32(data.Rows[i]["UserId"]),
                    Observations = data.Rows[i]["Observations"].ToString()
                });
            }



            return invoice;
        }
        public List<DisplayInvoiceModel> GetDisplayInvoice(int invoiceId, string clientName, DateTime dateFrom, DateTime dateTo, string invoiceNumber)
        {
            BLInvoice bLInvoice = new BLInvoice();
            BLAddress bLAddress = new BLAddress();


            List<InvoiceModel> listInvoice = bLInvoice.GetInvoiceList(invoiceId, clientName, dateFrom, dateTo, invoiceNumber);
            List<AddressModel> listAddress = null;
            List<DisplayInvoiceModel> list = new List<DisplayInvoiceModel>();
            //string stringAddress;
            for (int i = 0; i < listInvoice.Count; i++)
            {
                listAddress = bLAddress.Address(listInvoice[i].ClientId);
                for (int j = 0; j < listAddress.Count; j++)
                {
                    list.Add(new DisplayInvoiceModel
                    {

                        InvoiceId = listInvoice[i].InvoiceId,
                        ClientId = listInvoice[i].ClientId,
                        InvoiceNumber = listInvoice[i].InvoiceNumber,
                        InvoiceDate = listInvoice[i].InvoiceDate,
                        ClientFullName = listAddress[j].ClientName + " " + listAddress[j].ClientSurname,
                        Address = listAddress[j].CityName + " " + listAddress[j].CountyName + " " + listAddress[j].StreetName + " " + listAddress[j].StreetNo,
                        Observations = listInvoice[i].Observations,
                    });
                }

            }
            return list;
        }
    }
}
