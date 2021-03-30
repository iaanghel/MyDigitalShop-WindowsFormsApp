using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAAddress
    {
        public DataTable GetFullAddress(int id)
        {

            DataTable dataTable = new DataTable();
            SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select ca.ClientAddressId,  CONCAT(city.CityName, ' ', county.CountyName,' ',ca.StreetName,' ',ca.StreetNo) as FullAddress  from TClient c join TClientAddress ca on ca.ClientId=c.ClientId join TCity city on city.CityId = ca.CityId join TCounty county on county.CountyId=ca.CountyId where c.ClientId = @Id";

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@Id";
            parameter.DbType = System.Data.DbType.Int32;
            parameter.Size = 256;
            parameter.Direction = System.Data.ParameterDirection.Input;
            parameter.Value = id;

            command.Parameters.Add(parameter);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;


            adapter.Fill(dataTable);

            conection.Close();

            return dataTable;


        }
        public DataTable Address(int id)
        {

            DataTable dataTable = new DataTable();
            SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select c.ClientId,ca.ClientAddressId, c.ClientName, c.ClientSurname, city.CityName, county.CountyName, ca.StreetName, ca.StreetNo from TClient c join TClientAddress ca on ca.ClientId=c.ClientId join TCity city on city.CityId = ca.CityId join TCounty county on county.CountyId=ca.CountyId where c.ClientId = @Id";

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@Id";
            parameter.DbType = System.Data.DbType.Int32;
            parameter.Size = 256;
            parameter.Direction = System.Data.ParameterDirection.Input;
            parameter.Value = id;

            command.Parameters.Add(parameter);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;


            adapter.Fill(dataTable);

            conection.Close();

            return dataTable;


        }
        public DataTable GetCity()
        {

            DataTable dataTable = new DataTable();
            SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select CityId, CityName from TCity";

            
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;


            adapter.Fill(dataTable);

            conection.Close();

            return dataTable;


        }
        public DataTable GetCounty()
        {

            DataTable dataTable = new DataTable();
            SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select CountyId, CountyName from TCounty";


            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;


            adapter.Fill(dataTable);

            conection.Close();

            return dataTable;


        }
        
        public void Add(int clientId, string cityName, string countyName, string streetName, string streetNo)
        {
            SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
            //command.CommandText = "declare @ClientAddressId int \n" +
            //    "exec GetNextId 0, 'TClientAddress',@ClientAddressId out,0,1 \n" +
            //    "insert into TClientAddress(ClientAddressId, ClientId, CityId, CountyId, StreetName,StreetNo ) select @ClientAddressId, @ClientId,(select CityId from TCity where CityName = @CityName), (select CountyId from TCounty where CountyName = @CountyName), @StreetName,@StreetNo";

            command.CommandText = "insert into TClientAddress(ClientAddressId, ClientId, CityId, CountyId, StreetName,StreetNo ) select (select count(*) from TClientAddress)+1, @ClientId,(select CityId from TCity where CityName = @CityName), (select CountyId from TCounty where CountyName = @CountyName), @StreetName,@StreetNo";


            SqlParameter parameterCity = new SqlParameter();
            SqlParameter parameterClient = new SqlParameter();
            SqlParameter parameterCounty = new SqlParameter();
            SqlParameter parameterStreetName = new SqlParameter();
            SqlParameter parameterStreetNo = new SqlParameter();

            parameterCity.ParameterName = "@CityName";
            parameterCity.DbType = System.Data.DbType.String;
            parameterCity.Size = 256;
            parameterCity.Direction = System.Data.ParameterDirection.Input;
            parameterCity.Value = cityName;

            parameterClient.ParameterName = "@ClientId";
            parameterClient.DbType = System.Data.DbType.Int32;
            parameterClient.Size = 256;
            parameterClient.Direction = System.Data.ParameterDirection.Input;
            parameterClient.Value = clientId;


            parameterCounty.ParameterName = "@CountyName";
            parameterCounty.DbType = System.Data.DbType.String;
            parameterCounty.Size = 256;
            parameterCounty.Direction = System.Data.ParameterDirection.Input;
            parameterCounty.Value = countyName;

            parameterStreetName.ParameterName = "@StreetName";
            parameterStreetName.DbType = System.Data.DbType.String;
            parameterStreetName.Size = 256;
            parameterStreetName.Direction = System.Data.ParameterDirection.Input;
            parameterStreetName.Value = streetName == null ? (object)DBNull.Value : streetName; 

            parameterStreetNo.ParameterName = "@StreetNo";
            parameterStreetNo.DbType = System.Data.DbType.String;
            parameterStreetNo.Size = 256;
            parameterStreetNo.Direction = System.Data.ParameterDirection.Input;
            parameterStreetNo.Value = streetNo == null ? (object)DBNull.Value : streetNo;

            


            command.Parameters.Add(parameterCity);
            command.Parameters.Add(parameterClient);
            command.Parameters.Add(parameterCounty);
            command.Parameters.Add(parameterStreetName);
            command.Parameters.Add(parameterStreetNo);
            

            command.ExecuteNonQuery();
            conection.Close();



        }
        public void Update(int clientId, int clientAddressId, string cityName, string countyName, string streetName, string streetNo)
        {
            List<string> stringArray = new List<string>();
            //status = true;

            if (!String.IsNullOrWhiteSpace(cityName))
            {
                stringArray.Add("CityId=(select CityId from TCity where CityName = @CityName)");
            }
            if (!String.IsNullOrWhiteSpace(countyName))
            {
                stringArray.Add("CountyId=(select CountyId from TCounty where CountyName = @CountyName)");
            }
            if (!String.IsNullOrWhiteSpace(streetName))
            {
                stringArray.Add("StreetName=@StreetName");
            }
            if (!String.IsNullOrWhiteSpace(streetNo))
            {
                stringArray.Add("StreetNo=@StreetNo");
            }
            




            string setStatement = "";
            foreach (string stringElement in stringArray)
            {
                setStatement += stringElement + ",";
            }
            


            setStatement = setStatement.Substring(0, setStatement.Length - 1);



            SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "update TClientAddress set " + setStatement + " where ClientAddressId=" + clientAddressId.ToString()+" and ClientId="+clientId.ToString();

            SqlParameter parameterCityId = new SqlParameter();
            SqlParameter parameterCountyId = new SqlParameter();
            SqlParameter parameterStreetName = new SqlParameter();
            SqlParameter parameterStreetNo = new SqlParameter();

            parameterCityId.ParameterName = "@CityName";
            parameterCityId.DbType = System.Data.DbType.String;
            parameterCityId.Size = 256;
            parameterCityId.Direction = System.Data.ParameterDirection.Input;
            parameterCityId.Value = cityName;

            parameterCountyId.ParameterName = "@CountyName";
            parameterCountyId.DbType = System.Data.DbType.String;
            parameterCountyId.Size = 256;
            parameterCountyId.Direction = System.Data.ParameterDirection.Input;
            parameterCountyId.Value = cityName;

            parameterStreetName.ParameterName = "@StreetName";
            parameterStreetName.DbType = System.Data.DbType.String;
            parameterStreetName.Size = 256;
            parameterStreetName.Direction = System.Data.ParameterDirection.Input;
            parameterStreetName.Value = streetName;

            parameterStreetNo.ParameterName = "@StreetNo";
            parameterStreetNo.DbType = System.Data.DbType.String;
            parameterStreetNo.Size = 256;
            parameterStreetNo.Direction = System.Data.ParameterDirection.Input;
            parameterStreetNo.Value = streetNo;

           

            command.Parameters.Add(parameterCityId);
            command.Parameters.Add(parameterCountyId);
            command.Parameters.Add(parameterStreetName);
            command.Parameters.Add(parameterStreetNo);
            

            command.ExecuteNonQuery();
            conection.Close();

        }
        public void Delete(int clientId, int clientAddressId)
        {
            SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "delete from TClientAddress where ClientId=" + clientId.ToString() +" and ClientAddressId="+clientAddressId.ToString();
            command.ExecuteNonQuery();
            conection.Close();


        }




    }
}
