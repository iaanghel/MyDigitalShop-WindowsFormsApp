using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAInvoiceDetail
    {
        public void Delete(int invoiceId, int invoiceDetailId)
        {
            SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "delete from TInvpiceDetail where InvoiceId=" + invoiceId.ToString() + " and InvoiceDetailId=" + invoiceDetailId.ToString();
            command.ExecuteNonQuery();
            conection.Close();


        }
        public void Add(int invoiceId, string itemName, double qtty, double price ,double amount, string observations)
        {
            SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
            conection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            command.CommandType = System.Data.CommandType.Text;
            //command.CommandText = "declare @ClientAddressId int \n" +
            //    "exec GetNextId 0, 'TClientAddress',@ClientAddressId out,0,1 \n" +
            //    "insert into TClientAddress(ClientAddressId, ClientId, CityId, CountyId, StreetName,StreetNo ) select @ClientAddressId, @ClientId,(select CityId from TCity where CityName = @CityName), (select CountyId from TCounty where CountyName = @CountyName), @StreetName,@StreetNo";

            command.CommandText = "insert into TInvoiceDetail(InvoiceDetailId, InvoiceId, ItemId, Qtty, Price,Amount,Observations ) select (select count(*) from TInvoiceDetail)+1, @InvoiceId,(select ItemId from TItem where ItemName = @ItemName), @Qtty, @Price,@Amount,@Observations";


            SqlParameter parameterInvoiceId = new SqlParameter();
            SqlParameter parameterItemName = new SqlParameter();
            SqlParameter parameterQtty = new SqlParameter();
            SqlParameter parameterPrice = new SqlParameter();
            SqlParameter parameterAmount = new SqlParameter();
            SqlParameter parameterObservations = new SqlParameter();

            parameterInvoiceId.ParameterName = "@InvoiceId";
            parameterInvoiceId.DbType = System.Data.DbType.Int32;
            parameterInvoiceId.Size = 256;
            parameterInvoiceId.Direction = System.Data.ParameterDirection.Input;
            parameterInvoiceId.Value = invoiceId;

            parameterItemName.ParameterName = "@ItemName";
            parameterItemName.DbType = System.Data.DbType.String;
            parameterItemName.Size = 256;
            parameterItemName.Direction = System.Data.ParameterDirection.Input;
            parameterItemName.Value = itemName;


            parameterQtty.ParameterName = "@Qtty";
            parameterQtty.DbType = System.Data.DbType.Double;
            parameterQtty.Size = 256;
            parameterQtty.Direction = System.Data.ParameterDirection.Input;
            parameterQtty.Value = qtty;

            parameterPrice.ParameterName = "@Price";
            parameterPrice.DbType = System.Data.DbType.Double;
            parameterPrice.Size = 256;
            parameterPrice.Direction = System.Data.ParameterDirection.Input;
            parameterPrice.Value = price;

            parameterAmount.ParameterName = "@Amount";
            parameterAmount.DbType = System.Data.DbType.Double;
            parameterAmount.Size = 256;
            parameterAmount.Direction = System.Data.ParameterDirection.Input;
            parameterAmount.Value = amount;

            parameterObservations.ParameterName = "@Observations";
            parameterObservations.DbType = System.Data.DbType.String;
            parameterObservations.Size = 256;
            parameterObservations.Direction = System.Data.ParameterDirection.Input;
            parameterObservations.Value = observations;




            command.Parameters.Add(parameterInvoiceId);
            command.Parameters.Add(parameterItemName);
            command.Parameters.Add(parameterQtty);
            command.Parameters.Add(parameterPrice);
            command.Parameters.Add(parameterAmount);
            command.Parameters.Add(parameterObservations);


            command.ExecuteNonQuery();
            conection.Close();


        }
        public void Update(int invoiceId,int invoiceDetailId, string itemName, double qtty, double price, double amount, string observations)
        {
            List<string> stringArray = new List<string>();
            //status = true;

            if (!String.IsNullOrWhiteSpace(itemName))
            {
                stringArray.Add("ItemId=(select ItemId from Titem where ItemName = @ItemName)");
            }
            if (qtty >= 0)
            {
                stringArray.Add("Qtty=@Qtty");
            }
            if (price >= 0 )
            {
                stringArray.Add("Price=@Price");
            }
            if (amount >= 0)
            {
                stringArray.Add("Amount=@Amount");
            }
            if (!String.IsNullOrWhiteSpace(observations))
            {
                stringArray.Add("Observations=@Observations");
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
            //command.CommandText = "declare @ClientAddressId int \n" +
            //    "exec GetNextId 0, 'TClientAddress',@ClientAddressId out,0,1 \n" +
            //    "insert into TClientAddress(ClientAddressId, ClientId, CityId, CountyId, StreetName,StreetNo ) select @ClientAddressId, @ClientId,(select CityId from TCity where CityName = @CityName), (select CountyId from TCounty where CountyName = @CountyName), @StreetName,@StreetNo";

            command.CommandText = "update TInvoiceDetail set " + setStatement + " where InvoiceDetailId=" + invoiceDetailId.ToString() + " and InvoiceId=@InvoiceaId";


            SqlParameter parameterInvoiceId = new SqlParameter();
            SqlParameter parameterItemName = new SqlParameter();
            SqlParameter parameterQtty = new SqlParameter();
            SqlParameter parameterPrice = new SqlParameter();
            SqlParameter parameterAmount = new SqlParameter();
            SqlParameter parameterObservations = new SqlParameter();

            parameterInvoiceId.ParameterName = "@InvoiceaId";
            parameterInvoiceId.DbType = System.Data.DbType.Int32;
            parameterInvoiceId.Size = 256;
            parameterInvoiceId.Direction = System.Data.ParameterDirection.Input;
            parameterInvoiceId.Value = invoiceId;

            parameterItemName.ParameterName = "@ItemName";
            parameterItemName.DbType = System.Data.DbType.String;
            parameterItemName.Size = 256;
            parameterItemName.Direction = System.Data.ParameterDirection.Input;
            parameterItemName.Value = itemName;


            parameterQtty.ParameterName = "@Qtty";
            parameterQtty.DbType = System.Data.DbType.Double;
            parameterQtty.Size = 256;
            parameterQtty.Direction = System.Data.ParameterDirection.Input;
            parameterQtty.Value = qtty;

            parameterPrice.ParameterName = "@Price";
            parameterPrice.DbType = System.Data.DbType.Double;
            parameterPrice.Size = 256;
            parameterPrice.Direction = System.Data.ParameterDirection.Input;
            parameterPrice.Value = price;

            parameterAmount.ParameterName = "@Amount";
            parameterAmount.DbType = System.Data.DbType.Double;
            parameterAmount.Size = 256;
            parameterAmount.Direction = System.Data.ParameterDirection.Input;
            parameterAmount.Value = amount;

            parameterObservations.ParameterName = "@Observations";
            parameterObservations.DbType = System.Data.DbType.String;
            parameterObservations.Size = 256;
            parameterObservations.Direction = System.Data.ParameterDirection.Input;
            parameterObservations.Value = observations;




            command.Parameters.Add(parameterInvoiceId);
            command.Parameters.Add(parameterItemName);
            command.Parameters.Add(parameterQtty);
            command.Parameters.Add(parameterPrice);
            command.Parameters.Add(parameterAmount);
            command.Parameters.Add(parameterObservations);


            command.ExecuteNonQuery();
            conection.Close();


        }
        public DataTable GetInvoiceDetail(int invoiceId)
        {
            //string whereStatement = "";
            //if (String.IsNullOrWhiteSpace(clientName) == false)
            //    whereStatement += " and ClientId in (select ClientId from TClient where lower(ClientName)=lower(@ClientName))";
            //if (!(dateTime.Date == DateTime.Now.Date))
            //    whereStatement += " and InvoiceDate=@InvoiceDate";
            //if (String.IsNullOrWhiteSpace(invoiceNumber) == false)
            //    whereStatement += " and lower(InvoiceNumber)=@InvoiceNumber";
            //if (invoiceId > 0)
            //    whereStatement += " and InvoiceId=@InvoiceId";






            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
                conection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select id.InvoiceDetailId, id.InvoiceId, id.ItemId,i.ItemName, id.Qtty, id.Price as UnitPrice, id.Amount, id.Observations from TInvoiceDetail id join TItem i on i.ItemId=id.ItemId where InvoiceId = @InvoiceId";

                SqlParameter parameterId = new SqlParameter();
                //SqlParameter parameterName = new SqlParameter();
                //SqlParameter parameterDate = new SqlParameter();
                //SqlParameter parameterNumber = new SqlParameter();

                parameterId.ParameterName = "@InvoiceId";
                parameterId.DbType = System.Data.DbType.Int32;
                parameterId.Size = 256;
                parameterId.Direction = System.Data.ParameterDirection.Input;
                parameterId.Value = invoiceId;


                //parameterName.ParameterName = "@ClientName";
                //parameterName.DbType = System.Data.DbType.String;
                //parameterName.Size = 256;
                //parameterName.Direction = System.Data.ParameterDirection.Input;
                //parameterName.Value = clientName;

                //parameterDate.ParameterName = "@InvoiceDate";
                //parameterDate.DbType = System.Data.DbType.String;
                //parameterDate.Size = 256;
                //parameterDate.Direction = System.Data.ParameterDirection.Input;
                //parameterDate.Value = dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString();

                //parameterNumber.ParameterName = "@InvoiceNumber";
                //parameterNumber.DbType = System.Data.DbType.String;
                //parameterNumber.Size = 256;
                //parameterNumber.Direction = System.Data.ParameterDirection.Input;
                //parameterNumber.Value = invoiceNumber;


                command.Parameters.Add(parameterId);
                //command.Parameters.Add(parameterName);
                //command.Parameters.Add(parameterDate);
                //command.Parameters.Add(parameterNumber);

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
        public DataTable GetItem()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection conection = new SqlConnection(Properties.Resources.ConnectionString);
                conection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select ItemId,ItemName, ItemCode, MeasuringUnitName, ItemDescription from TItem";

                

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
    }
}
