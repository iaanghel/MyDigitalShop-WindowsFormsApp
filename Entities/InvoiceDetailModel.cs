using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InvoiceDetailModel
    {


        public string ItemName { set; get; }

        public int InvoiceDetailId { set; get; }
        public int InvoiceId { set; get; }
        public int ItemId { set; get; }
        public double Qtty { set; get; }
        public double UnitPrice { set; get; }
        public double Amount { set; get; }
        public string Observations { set; get; }
        
        public int Status { set; get; }



    }
}
