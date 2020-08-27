using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_mannagement_System.Entity
{
    class Product:Baseclass
    {
        public string Name { set; get; }
        public int P_id { set; get; }
        public string Pic { set; get; }
        public int Stock { set; get; }
        public int Sellprice { set; get; }
        public int Discount { set; get; }
        
        public int Price 
        {

            get
            {
                return (Sellprice - Discount);
            }
        }
       
       
        
    }
}
