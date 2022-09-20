using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    public class Book : Publication
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public DateTime YearOfPublic { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine(base.Name + "   " + base.CretedEdition);
        }
    }
}
