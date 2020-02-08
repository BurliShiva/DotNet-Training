using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Proprice { get; set; }
        public double totalprice(int price, double tax)
        {
            var totalprice = price + tax ;
            return price;
        }
    }
}
