using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopALL
{
    public class Product
    {
        public string Name { get; set; }
        public string ItemNumber { get; set; }
        public int Count { get; set; }
        public DateTime DateArrival { get; set; }
        public DateTime DateDelivery { get; set; }
        public double Discount { get; set; }
        public int Price { get; set; }
        public int PriceW { get; set; }

    }
}
