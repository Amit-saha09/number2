using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_mannagement_System.Entity
{
    class Category:Baseclass
    {
        public string Name { set; get; }
        public int C_id { set; get; }
        public string Pic { set; get; }
        public int Stock { set; get; }
        public int Price { set; get; }
        public int Totalprice
        {
            get
            {
                return (Stock * Price);
            }
            
        }
        public int Paidprice { set; get; }
        public int Dueprice
        {
            get
            {
                return (Totalprice-Paidprice);
            }

        }

    }
}
