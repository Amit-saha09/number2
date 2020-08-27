using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_mannagement_System.Entity
{
    class User:Baseclass
    {
        public string Username { set; get; }
        public string Passward { set; get; }
        public string Usertype { set; get; }
    }
}
