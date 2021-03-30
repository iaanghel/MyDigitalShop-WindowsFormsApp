using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserModel
    {
        public int UserId { set; get; }
        public string UserName { set; get; }
        public string UserPassword { set; get; }
        public DateTime LastLogIn { set; get; }
        public UserModel()
        {
            
            
        }
    }
}
