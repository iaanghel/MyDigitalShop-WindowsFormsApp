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
    public class BLInvoiceDetail
    {
        public void DeleteDetail(int invoiceId, int invoiceDetailId)
        {
            DAInvoiceDetail da = new DAInvoiceDetail();
            da.Delete(invoiceId, invoiceDetailId);
        }
        public void AddDetail(int invoiceId, string itemName, double qtty, double price, double amount, string observations)
        {
            DAInvoiceDetail da = new DAInvoiceDetail();
            da.Add(invoiceId, itemName, qtty, price, amount, observations);
        }
        public void UpdateDetail(int invoiceId,int invoiceDetailId, string itemName, double qtty, double price, double amount, string observations)
        {
            DAInvoiceDetail da = new DAInvoiceDetail();
            da.Update(invoiceId,invoiceDetailId, itemName, qtty, price, amount, observations);
        }
        public List<InvoiceDetailModel> GetInvoiceDetail(int invoiceId)
        {
            List<InvoiceDetailModel> invoice = new List<InvoiceDetailModel>();
            DAInvoice dAInvoice = new DAInvoice();
            DAInvoiceDetail dAInvoiceDetail = new DAInvoiceDetail();
            DataTable data = dAInvoiceDetail.GetInvoiceDetail(invoiceId);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                invoice.Add(new InvoiceDetailModel
                {
                    InvoiceId = Convert.ToInt32(data.Rows[i]["InvoiceId"]),
                    InvoiceDetailId = Convert.ToInt32(data.Rows[i]["InvoiceDetailId"]),
                    ItemId = Convert.ToInt32(data.Rows[i]["ItemId"]),
                    Qtty = Convert.ToDouble(data.Rows[i]["Qtty"]),
                    UnitPrice = Convert.ToDouble(data.Rows[i]["UnitPrice"]),
                    Amount = Convert.ToDouble(data.Rows[i]["Amount"]),
                    Observations = data.Rows[i]["Observations"].ToString(),
                    ItemName = data.Rows[i]["ItemName"].ToString()
                });
            }



            return invoice;
        }
        public List<ItemModel> GetItem()
        {
            List<ItemModel> item = new List<ItemModel>();
            DAInvoiceDetail dAInvoiceDetail = new DAInvoiceDetail();
            DataTable data = dAInvoiceDetail.GetItem();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                item.Add(new ItemModel
                {
                    ItemId = Convert.ToInt32(data.Rows[i]["ItemId"]),

                    ItemName = data.Rows[i]["ItemName"].ToString(),


                });
            }
            return item;
        }
    }
}
