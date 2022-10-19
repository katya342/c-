using ShopALL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopKzTova
{
     public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the action please: ");
            Console.WriteLine("Press 1 to enter acccount");
            Console.WriteLine("Press 2 to show all the good in store");
            Console.WriteLine("Press 3 to open auction");
            int ch = Convert.ToInt32(Console.ReadLine());


            switch (ch)
            {
                case 1:
                    Vendor vendor = new Vendor();
                    vendor.SetLogin();
                    vendor.SetPassword();    break;
                    
            }
        }
    }
}
