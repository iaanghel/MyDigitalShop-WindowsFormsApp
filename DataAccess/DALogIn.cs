using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DALogIn

    {
        public DALogIn()
        {

        }
        public DataTable CheckUser(string userName)
        {
            
            DataTable dataTable = new DataTable();
            try
            {

                SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
                conection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select UserId, UserName, UserPassword from TERPUser"
                    + " where UserName=@UserName";
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@UserName";
                parameter.DbType = System.Data.DbType.String;
                parameter.Size = 256;
                parameter.Direction = System.Data.ParameterDirection.Input;
                parameter.Value = userName;

                command.Parameters.Add(parameter);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                
                adapter.Fill(dataTable);

                conection.Close();
            }
            catch(Exception ex)
            {
                //error = ex.Message.;
                //ex.Message
                throw ex;
            }
            return dataTable;



        }
        public DataTable CheckRegisterUser(string userName)
        {
            DataTable dataTable = new DataTable();
            try
            {

                SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
                conection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select UserId, UserName, UserPassword from TERPUser"
                    + " where UserName=@UserName";
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@UserName";
                parameter.DbType = System.Data.DbType.String;
                parameter.Size = 256;
                parameter.Direction = System.Data.ParameterDirection.Input;
                parameter.Value = userName;

                command.Parameters.Add(parameter);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                adapter.Fill(dataTable);

                conection.Close();
            }
            catch (Exception ex)
            {
                //error = ex.Message.;
                //ex.Message
                throw ex;
            }
            return dataTable;



        }
        public void RegisterUser(String userName, string password)
        {
            SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
             //"declare @UserId int \n" +
             //   "exec GetNextId 0, 'TERPUser',@UserId out,0,1 \n" +
            command.CommandText = "insert into TERPUser(UserId, UserName, UserPassword, LastLogin) select (select count(*) from TERPUser)+1, @UserName,@Password, getdate()";
            SqlParameter parameterUser = new SqlParameter();
            parameterUser.ParameterName = "@UserName";
            parameterUser.DbType = System.Data.DbType.String;
            parameterUser.Size = 256;
            parameterUser.Direction = System.Data.ParameterDirection.Input;
            parameterUser.Value = userName;

            SqlParameter parameterPassword = new SqlParameter();
            parameterPassword.ParameterName = "@Password";
            parameterPassword.DbType = System.Data.DbType.String;
            parameterPassword.Size = 256;
            parameterPassword.Direction = System.Data.ParameterDirection.Input;
            parameterPassword.Value = password;
            command.Parameters.Add(parameterUser);
            command.Parameters.Add(parameterPassword);
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.UpdateCommand = command;
            command.ExecuteNonQuery();
            conection.Close();

        }
        public void LastLogIn(int userId)
        {
            SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "update TERPUser set LastLogin = getdate() where UserId = @UserId";
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@UserId";
            parameter.DbType = System.Data.DbType.Int32;
            parameter.Size = 256;
            parameter.Direction = System.Data.ParameterDirection.Input;
            parameter.Value = userId;

            command.Parameters.Add(parameter);
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.UpdateCommand = command;
            command.ExecuteNonQuery();
            conection.Close();
        }
    }
}
