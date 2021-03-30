using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAClient
    {
        public DataTable GetClientFullName(int clientId)
        {
            string whereStatement = "";
            if (clientId != 0)
            {
                whereStatement = "and ClientId  = " + clientId.ToString();

            }

            DataTable dataTable = new DataTable();
            SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select ClientId, CONCAT(ClientName, ' ', ClientSurname) as ClientFullName from TClient where 1=1 "+whereStatement;


            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;


            adapter.Fill(dataTable);

            conection.Close();

            return dataTable;


        }
        public DataTable GetClientList(int clientId, string clientName, string clientSurname, string clientCode, string phoneNo, string email)
        {
            string whereStatement ="";
            if (String.IsNullOrWhiteSpace(clientName)==false)
                whereStatement += " and lower(ClientName)=lower(@ClientName)";
            if (String.IsNullOrWhiteSpace(clientSurname) == false)
                whereStatement += " and lower(ClientSurname)=lower(@ClientSurname)";
            if (String.IsNullOrWhiteSpace(clientCode) == false)
                whereStatement += " and lower(ClientCode)=lower(@ClientCode)";
            if (String.IsNullOrWhiteSpace(phoneNo) == false)
                whereStatement += " and lower(PhoneNo)=lower(@PhoneNo)";
            if (String.IsNullOrWhiteSpace(email) == false)
                whereStatement += " and lower(Email)=lower(@Email)";
            if (clientId >0)
                whereStatement += " and ClientId=@ClientId";





            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
                conection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandTimeout = 0;
                command.Connection = conection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select ClientId, ClientName, ClientSurname, ClientCode,PhoneNo ,Email from TClient where 1=1"+ whereStatement;

                SqlParameter parameterName = new SqlParameter();
                SqlParameter parameterSurname = new SqlParameter();
                SqlParameter parameterCode = new SqlParameter();
                SqlParameter parameterPhoneNo = new SqlParameter();
                SqlParameter parameterEmail = new SqlParameter();
                SqlParameter parameterId = new SqlParameter();

                parameterId.ParameterName = "@ClientId";
                parameterId.DbType = System.Data.DbType.Int32;
                parameterId.Size = 256;
                parameterId.Direction = System.Data.ParameterDirection.Input;
                parameterId.Value =clientId;

                parameterName.ParameterName = "@ClientName";
                parameterName.DbType = System.Data.DbType.String;
                parameterName.Size = 256;
                parameterName.Direction = System.Data.ParameterDirection.Input;
                parameterName.Value = clientName;

                parameterSurname.ParameterName = "@ClientSurname";
                parameterSurname.DbType = System.Data.DbType.String;
                parameterSurname.Size = 256;
                parameterSurname.Direction = System.Data.ParameterDirection.Input;
                parameterSurname.Value = clientSurname;

                parameterCode.ParameterName = "@ClientCode";
                parameterCode.DbType = System.Data.DbType.String;
                parameterCode.Size = 256;
                parameterCode.Direction = System.Data.ParameterDirection.Input;
                parameterCode.Value = clientCode;

                parameterPhoneNo.ParameterName = "@PhoneNo";
                parameterPhoneNo.DbType = System.Data.DbType.String;
                parameterPhoneNo.Size = 256;
                parameterPhoneNo.Direction = System.Data.ParameterDirection.Input;
                parameterPhoneNo.Value = phoneNo;

                parameterEmail.ParameterName = "@Email";
                parameterEmail.DbType = System.Data.DbType.String;
                parameterEmail.Size = 256;
                parameterEmail.Direction = System.Data.ParameterDirection.Input;
                parameterEmail.Value = email;

                command.Parameters.Add(parameterId);
                command.Parameters.Add(parameterName);
                command.Parameters.Add(parameterSurname);
                command.Parameters.Add(parameterCode);
                command.Parameters.Add(parameterPhoneNo);
                command.Parameters.Add(parameterEmail);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                

                adapter.Fill(dataTable);

                conection.Close();



            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            return dataTable;
        }
        public void Add(string clientName, string clientSurname, string clientCode, string phoneNo, string email)
        {
            SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
            //command.CommandText = "declare @ClientId int \n" +
            //    "exec GetNextId 0, 'TClient',@ClientId out,0,1 \n" +
            //    "insert into TClient(ClientId, ClientName, ClientSurname, ClientCode, PhoneNo,Email ) select @ClientId, @ClientName,@ClientSurname, @ClientCode, @PhoneNo,@Email";

            command.CommandText = "insert into TClient(ClientId, ClientName, ClientSurname, ClientCode, PhoneNo,Email ) select (SELECT COUNT(*) FROM TClient)+1, @ClientName,@ClientSurname, @ClientCode, @PhoneNo,@Email";


            SqlParameter parameterName = new SqlParameter();
            SqlParameter parameterSurname = new SqlParameter();
            SqlParameter parameterCode = new SqlParameter();
            SqlParameter parameterPhoneNo = new SqlParameter();
            SqlParameter parameterEmail = new SqlParameter();
            parameterName.ParameterName = "@ClientName";
            parameterName.DbType = System.Data.DbType.String;
            parameterName.Size = 256;
            parameterName.Direction = System.Data.ParameterDirection.Input;
            parameterName.Value = clientName;

            parameterSurname.ParameterName = "@ClientSurname";
            parameterSurname.DbType = System.Data.DbType.String;
            parameterSurname.Size = 256;
            parameterSurname.Direction = System.Data.ParameterDirection.Input;
            parameterSurname.Value = clientSurname;

            parameterCode.ParameterName = "@ClientCode";
            parameterCode.DbType = System.Data.DbType.String;
            parameterCode.Size = 256;
            parameterCode.Direction = System.Data.ParameterDirection.Input;
            parameterCode.Value = clientCode;

            parameterPhoneNo.ParameterName = "@PhoneNo";
            parameterPhoneNo.DbType = System.Data.DbType.String;
            parameterPhoneNo.Size = 256;
            parameterPhoneNo.Direction = System.Data.ParameterDirection.Input;
            parameterPhoneNo.Value = phoneNo == null ? (object)DBNull.Value : phoneNo;

            parameterEmail.ParameterName = "@Email";
            parameterEmail.DbType = System.Data.DbType.String;
            parameterEmail.Size = 256;
            parameterEmail.Direction = System.Data.ParameterDirection.Input;
            parameterEmail.Value = email == null ? (object)DBNull.Value : email ;
            

            command.Parameters.Add(parameterName);
            command.Parameters.Add(parameterSurname);
            command.Parameters.Add(parameterCode);
            command.Parameters.Add(parameterPhoneNo);
            command.Parameters.Add(parameterEmail);
            
            command.ExecuteNonQuery();
            conection.Close();

        }
        public void Update(out bool status, int id,  string clientName, string clientSurname, string clientCode, string phoneNo, string email)
        {
            List<string> stringArray =new List<string>();
            status = true;

            if (!String.IsNullOrWhiteSpace(clientName))
            {
                stringArray.Add("ClientName=@ClientName");
            }
            if (!String.IsNullOrWhiteSpace(clientSurname)) 
            {
                stringArray.Add("ClientSurname=@ClientSurname");
            }
            if (!String.IsNullOrWhiteSpace(clientCode))
            {
                stringArray.Add("ClientCode=@ClientCode");
            }
            if (!String.IsNullOrWhiteSpace(phoneNo))
            {
                stringArray.Add("PhoneNo=@PhoneNo");
            }
            if (!String.IsNullOrWhiteSpace(email))
            {
                stringArray.Add("Email=@Email");
            }
            
            
                

            string setStatement = "";
            foreach (string stringElement in stringArray)
            {
                setStatement += stringElement + ",";
            }
            //setStatement += stringArray[stringArray.Count - 1];
            

            setStatement = setStatement.Substring(0, setStatement.Length-1);



            SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "update TClient set "+ setStatement+ " where ClientId="+id.ToString();

            SqlParameter parameterName = new SqlParameter();
            SqlParameter parameterSurname = new SqlParameter();
            SqlParameter parameterCode = new SqlParameter();
            SqlParameter parameterPhoneNo = new SqlParameter();
            SqlParameter parameterEmail = new SqlParameter();
            parameterName.ParameterName = "@ClientName";
            parameterName.DbType = System.Data.DbType.String;
            parameterName.Size = 256;
            parameterName.Direction = System.Data.ParameterDirection.Input;
            parameterName.Value = clientName;

            parameterSurname.ParameterName = "@ClientSurname";
            parameterSurname.DbType = System.Data.DbType.String;
            parameterSurname.Size = 256;
            parameterSurname.Direction = System.Data.ParameterDirection.Input;
            parameterSurname.Value = clientSurname;

            parameterCode.ParameterName = "@ClientCode";
            parameterCode.DbType = System.Data.DbType.String;
            parameterCode.Size = 256;
            parameterCode.Direction = System.Data.ParameterDirection.Input;
            parameterCode.Value = clientCode;

            parameterPhoneNo.ParameterName = "@PhoneNo";
            parameterPhoneNo.DbType = phoneNo == null ? System.Data.DbType.Int32 : System.Data.DbType.String;
            parameterPhoneNo.Size = 256;
            parameterPhoneNo.Direction = System.Data.ParameterDirection.Input;
            parameterPhoneNo.Value = phoneNo;

            parameterEmail.ParameterName = "@Email";
            parameterEmail.DbType = email == null ? System.Data.DbType.Int32 : System.Data.DbType.String;
            parameterEmail.Size = 256;
            parameterEmail.Direction = System.Data.ParameterDirection.Input;
            parameterEmail.Value = email;

            command.Parameters.Add(parameterName);
            command.Parameters.Add(parameterSurname);
            command.Parameters.Add(parameterCode);
            command.Parameters.Add(parameterPhoneNo);
            command.Parameters.Add(parameterEmail);

            command.ExecuteNonQuery();
            conection.Close();

        }
        public void Delete(int id)
        {
            SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "delete from TClientAddress where ClientId = "+id.ToString()+"\n" + "delete from TClient where ClientId="+id.ToString();
            command.ExecuteNonQuery();
            conection.Close();


        }
    }
}
