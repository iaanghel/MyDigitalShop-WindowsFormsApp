using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DisplayInvoiceModel
    {
        public int InvoiceId { set; get; }
        public int ClientId { set; get; }
        public string InvoiceNumber { set; get; }
        public DateTime InvoiceDate { set; get; }
        public string ClientFullName { set; get; }
        public string Address { set; get; }
        public string Observations { set; get; }
    }
}
