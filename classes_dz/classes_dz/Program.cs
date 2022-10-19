using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stationery [] stationery = new Stationery[5];
            Stationery first = new Stationery("Pen", "Good", "Bought");
            //Stationery second = new Stationery("Pen", "Good", "Bought");
            //second.Display();
            //for (int i = 0; i < stationery.Length; i++)
            //{
            //    Console.WriteLine(stationery[i]);
            //}
            first.Display();
        }
    }
}
