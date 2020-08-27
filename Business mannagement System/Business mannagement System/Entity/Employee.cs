using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_mannagement_System.Entity
{
    class Employee:Baseclass
    {
        public string Name { set; get; }
        public string Phone { set; get; }
        public string Hiredate { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string Pic { set; get; }
        public string Designation { set; get; }
        public int Salary { set; get; }
        public string Dateofbirth { set; get; }
        public string Bloodgroup { set; get; }
    }
}
