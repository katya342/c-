using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopALL
{
    public class Vendor
    {
        public string Name { get; set; }
        public List<Vendor> Products { get; set; }
        public string LastEntrance { get; set; }
        public string WrongPASS { get; set; }
        public string Login { get; set; }
        public int Password { get; set; }

        public void SetLogin()
        {
            Console.WriteLine("Enter login please");
            Login = Console.ReadLine();
        }
        public void SetPassword()
        {
            Console.WriteLine("Enter pass please");
            Password = Convert.ToInt32(Console.ReadLine());
            if()
        }
        public int CountWP()
        {
            
        }
    }
}
