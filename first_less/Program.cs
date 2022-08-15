using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_less
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string fname = "Bezverkhova";
            //string mName = "Katya";
            //Console.WriteLine(fname);
            //Console.WriteLine(mName);
            //Console.ReadLine();
            Console.WriteLine("Vvedite fio");
            string userName = Console.ReadLine();

            Console.Write("Vvedite vosrast");
            string userAge = Console.ReadLine();

            int currentAge = 2022;
            int userAge_ = Convert.ToInt32(userAge);

            int avalAge = currentAge - userAge_;
            if(avalAge >= 18)
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("Slishkom molod");
            }
            Console.WriteLine("Приветствую тебя " + userName);

        }
    }
}
