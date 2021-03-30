using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAInvoice
    {
        public DataTable GetInvoiceList(int invoiceId, string clientName, DateTime dateFrom,DateTime dateTo, string invoiceNumber)
        {
            string whereStatement = "";
            if (String.IsNullOrWhiteSpace(clientName) == false)
                whereStatement += " and ClientId in (select ClientId from TClient where lower(ClientName)=lower(@ClientName))";
            if (!(dateFrom.Date == DateTime.Now.Date))
                whereStatement += " and InvoiceDate BETWEEN @InvoiceDateFrom and @InvoiceDateTo";
            if (String.IsNullOrWhiteSpace(invoiceNumber) == false)
                whereStatement += " and lower(InvoiceNumber)=@InvoiceNumber";
            if (invoiceId >0)
                whereStatement += " and InvoiceId=@InvoiceId";






            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
                conection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select InvoiceId, InvoiceNumber, InvoiceDate, ClientId, ClientAddressId, UserId,Observations from TInvoice where 1=1" + whereStatement;

                SqlParameter parameterId = new SqlParameter();
                SqlParameter parameterName = new SqlParameter();
                SqlParameter parameterDateFrom = new SqlParameter();
                SqlParameter parameterDateTo = new SqlParameter();
                SqlParameter parameterNumber = new SqlParameter();

                parameterId.ParameterName = "@InvoiceId";
                parameterId.DbType = System.Data.DbType.Int32;
                parameterId.Size = 256;
                parameterId.Direction = System.Data.ParameterDirection.Input;
                parameterId.Value = invoiceId;


                parameterName.ParameterName = "@ClientName";
                parameterName.DbType = System.Data.DbType.String;
                parameterName.Size = 256;
                parameterName.Direction = System.Data.ParameterDirection.Input;
                parameterName.Value = clientName;

                parameterDateFrom.ParameterName = "@InvoiceDateFrom";
                parameterDateFrom.DbType = System.Data.DbType.String;
                parameterDateFrom.Size = 256;
                parameterDateFrom.Direction = System.Data.ParameterDirection.Input;
                parameterDateFrom.Value = dateFrom.Year.ToString()+"-"+ dateFrom.Month.ToString()+"-"+ dateFrom.Day.ToString();

                parameterDateTo.ParameterName = "@InvoiceDateTo";
                parameterDateTo.DbType = System.Data.DbType.String;
                parameterDateTo.Size = 256;
                parameterDateTo.Direction = System.Data.ParameterDirection.Input;
                parameterDateTo.Value = dateTo.Year.ToString() + "-" + dateTo.Month.ToString() + "-" + dateTo.Day.ToString();


                parameterNumber.ParameterName = "@InvoiceNumber";
                parameterNumber.DbType = System.Data.DbType.String;
                parameterNumber.Size = 256;
                parameterNumber.Direction = System.Data.ParameterDirection.Input;
                parameterNumber.Value = invoiceNumber;


                command.Parameters.Add(parameterId);
                command.Parameters.Add(parameterName);
                command.Parameters.Add(parameterDateFrom);
                command.Parameters.Add(parameterDateTo);
                command.Parameters.Add(parameterNumber);
                
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
        public void Add(string invoiceNumber, DateTime invoiceDate,int clientId,int clientAddressId, int userId, string observations)
        {
            SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
            //command.CommandText = "declare @InvoiceId int \n" +
            //    "exec GetNextId 0, 'TInvoice',@InvoiceId out,0,1 \n" +
            //    "insert into TInvoice(InvoiceId, InvoiceNumber, InvoiceDate, ClientId, ClientAddressId,UserId, Observations ) select @InvoiceId, @InvoiceDate,@InvoiceDate, @ClientId, @ClientAddressId,@UserId , @Observations";

            command.CommandText = "insert into TInvoice(InvoiceId, InvoiceNumber, InvoiceDate, ClientId, ClientAddressId,UserId, Observations ) select (select count(*) from TInvoice)+1, @InvoiceNumber,@InvoiceDate, @ClientId, @ClientAddressId,@UserId , @Observations";


            SqlParameter parameterNumber = new SqlParameter();
            SqlParameter parameterDate = new SqlParameter();
            SqlParameter parameterClientId = new SqlParameter();
            SqlParameter parameterClientAddressId = new SqlParameter();
            SqlParameter parameterUserId = new SqlParameter();
            SqlParameter parameterObservations = new SqlParameter();

            parameterNumber.ParameterName = "@InvoiceNumber";
            parameterNumber.DbType = System.Data.DbType.String;
            parameterNumber.Size = 256;
            parameterNumber.Direction = System.Data.ParameterDirection.Input;
            parameterNumber.Value = invoiceNumber;

            parameterDate.ParameterName = "@InvoiceDate";
            parameterDate.DbType = System.Data.DbType.DateTime;
            parameterDate.Size = 256;
            parameterDate.Direction = System.Data.ParameterDirection.Input;
            parameterDate.Value = invoiceDate;


            parameterClientId.ParameterName = "@ClientId";
            parameterClientId.DbType = System.Data.DbType.Int32;
            parameterClientId.Size = 256;
            parameterClientId.Direction = System.Data.ParameterDirection.Input;
            parameterClientId.Value = clientId;

            parameterClientAddressId.ParameterName = "@ClientAddressId";
            parameterClientAddressId.DbType = System.Data.DbType.String;
            parameterClientAddressId.Size = 256;
            parameterClientAddressId.Direction = System.Data.ParameterDirection.Input;
            parameterClientAddressId.Value = clientAddressId;

            parameterUserId.ParameterName = "@UserId";
            parameterUserId.DbType = System.Data.DbType.Int32;
            parameterUserId.Size = 256;
            parameterUserId.Direction = System.Data.ParameterDirection.Input;
            parameterUserId.Value = userId;

            parameterObservations.ParameterName = "@Observations";
            parameterObservations.DbType = System.Data.DbType.String;
            parameterObservations.Size = 256;
            parameterObservations.Direction = System.Data.ParameterDirection.Input;
            parameterObservations.Value = observations;




            command.Parameters.Add(parameterNumber);
            command.Parameters.Add(parameterDate);
            command.Parameters.Add(parameterClientId);
            command.Parameters.Add(parameterClientAddressId);
            command.Parameters.Add(parameterUserId);
            command.Parameters.Add(parameterObservations);


            command.ExecuteNonQuery();
            conection.Close();

        }

    }
}
