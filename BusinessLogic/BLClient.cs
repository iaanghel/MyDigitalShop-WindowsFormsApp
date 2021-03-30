using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLogic
{
    public class BLClient
    {
        public List<ClientFullNameModel> GetClientFullName(int clientId)
        {
            List<ClientFullNameModel> clients = new List<ClientFullNameModel>();
            DAClient client = new DAClient();
            DataTable data = client.GetClientFullName(clientId);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                clients.Add(new ClientFullNameModel
                {
                    ClientId = Convert.ToInt32(data.Rows[i]["ClientId"]),

                    ClientFullName = data.Rows[i]["ClientFullName"].ToString(),


                });
            }

            return clients;
        }
        public List<ClientModule> GetClientList(int clientId,string clientName, string clientSurname, string clientCode, string phoneNo, string email)
        {
            List<ClientModule> clients = new List<ClientModule>();
            DAClient dAPartner = new DAClient();
            DataTable data = dAPartner.GetClientList(clientId,clientName, clientSurname, clientCode, phoneNo, email);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                clients.Add(new ClientModule { ClientId = Convert.ToInt32(data.Rows[i]["ClientId"]),
                    ClientName = data.Rows[i]["ClientName"].ToString(),
                    ClientSurname = data.Rows[i]["ClientSurname"].ToString(),
                    ClientCode = data.Rows[i]["ClientCode"].ToString(),
                    PhoneNo = data.Rows[i]["PhoneNo"].ToString(),
                    Email = data.Rows[i]["Email"].ToString()
                });
            }



                return clients;
        }
        public void AddClient(string clientName, string clientSurname, string clientCode, string phoneNo, string email, out bool status)
        {
            status = true;
            DAClient dAClient = new DAClient();
            DataTable data = dAClient.GetClientList(-1, "","","","","");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if(clientCode == data.Rows[i]["ClientCode"].ToString())
                {
                    status = false;
                    return;
                }
            }
            if (status)
                dAClient.Add(clientName, clientSurname, clientCode, phoneNo, email);

            return;


        }
        public void UpdateClient(int id, string clientName, string clientSurname, string clientCode, string phoneNo, string email, out bool status)
        {
            status = true;
            DAClient dAClient = new DAClient();
            DataTable data = dAClient.GetClientList(-1,"", "", "", "", "");
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (clientCode == data.Rows[i]["ClientCode"].ToString())
                {
                    status = false;
                    return;
                }
            }


            if (status)
                dAClient.Update(out status, id, clientName, clientSurname, clientCode, phoneNo, email);
            //else
            //    return;

            //ssssreturn;


        }
        public void DeleteClient(int id)
        {
            DAClient dAClient = new DAClient();
            dAClient.Delete(id);
        }
    }
}
