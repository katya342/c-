using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PublicationEdition obj1 = new PublicationEdition();
            obj1[0].ShowInfo();
            obj1[1].ShowInfo();

        }
    }
}
