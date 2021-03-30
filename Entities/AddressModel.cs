using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AddressModel
    {
        

        public int ClientId { set; get; }

        public int ClientAddressId { set; get; }
        public string ClientName { set; get; }
        
        public string ClientSurname { set; get; }
        public string CityName { set; get; }
        public string CountyName { set; get; }
        public string StreetName { set; get; }
        public string StreetNo { set; get; }
        //1 - add, 2- update 3 - delete
        public int status { set; get; }

    }
}
