using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    
    public class InvoiceModel
    {
        public int InvoiceId { set; get; }
        public string InvoiceNumber { set; get; }
        public DateTime InvoiceDate { set; get; }
        public int ClientId { set; get; }
        public int ClientAddressId { set; get; }
        public int UserId { set; get; }
        public string Observations { set; get; }



    }
}
