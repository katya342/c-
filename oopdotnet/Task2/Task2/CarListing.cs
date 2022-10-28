using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class CarListing
    {
        private List<YTans> tr = new List<YTans>();
        public void ListingAdd(YTans trans)
        {
            tr.Add(trans);
        }
        public void PrintInfo()
        {
            foreach (YTans item in tr)
            {
                item.GetTransInfo();
            }
        }
    }
}
