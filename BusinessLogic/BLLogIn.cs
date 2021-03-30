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
    public class BLLogIn
    {
        public BLLogIn()
        {

        }
        
        public UserModel CheckUser(string userName, string password , out bool status)
        {
            UserModel user = new UserModel();
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(password);
            password = System.Convert.ToBase64String(buffer);

           
            status = false;
            DALogIn da = new DALogIn();
            DataTable tableUsers = da.CheckUser(userName);
            
            if (tableUsers.Rows.Count == 0)
                status = false;
            else
            {
                for(int i = 0; i < tableUsers.Rows.Count; i++)
                {
                   if(password == tableUsers.Rows[i]["UserPassword"].ToString())
                    {
                        status = true;
                        user.UserId = Convert.ToInt32(tableUsers.Rows[i]["UserId"]);
                        user.UserName = tableUsers.Rows[i]["UserName"].ToString();
                        user.UserPassword = tableUsers.Rows[i]["UserPassword"].ToString();
                        user.LastLogIn = DateTime.Now;
                    }
                }
            }

            if (status)
                da.LastLogIn(user.UserId);


            return user;
        }
        public void RegisterUser(string userName, string password, out bool status)
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(password);
            password = System.Convert.ToBase64String(buffer);
            DataTable tableUsers = new DataTable();
            
            DALogIn da = new DALogIn();
            tableUsers = da.CheckRegisterUser(userName);
            status = true;
            for (int i = 0; i < tableUsers.Rows.Count; i++)
            {
                if (userName == tableUsers.Rows[i]["UserName"].ToString())
                {
                    status = false;
                    
                }
            }
            if (status == true)
                da.RegisterUser(userName, password);




        }
    }
}
