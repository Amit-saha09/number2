using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_mannagement_System.Entity
{
    class Customer:Baseclass
    {
        public string Name { set; get; }
        public string Phone { set; get; }
        public string Nid { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string Pic { set; get; }
        public string Job { set; get; }
        public int Salary { set; get; }
        public string Dateofbirth { set; get; }
        public string Bloodgroup { set; get; }
    }
}
