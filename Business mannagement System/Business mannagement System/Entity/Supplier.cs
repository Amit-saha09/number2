using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_mannagement_System.Entity
{
    class Supplier:Baseclass
    {
        public string Name { set; get; }
        public string Phone { set; get; }
        public string Country { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string Pic { set; get; }
    }
}
