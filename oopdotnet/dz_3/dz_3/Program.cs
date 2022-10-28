using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Chisla();
            LongNum();
        }
       
        
        //static void Chisla()
        //{
        //    int Sum(int number)
        //    {
        //        if (number < 10)
        //            return number;
        //        else
        //        {
        //            return Sum(number/10) + number % 10;
        //        }
        //    }
        //    int sum = Sum(12345);
        //    Console.WriteLine(sum);
           
        //}
        static void LongNum()
        {
            int [] ArrNum = new int[100];
            Console.WriteLine("Enter num: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < num.ToString().Length; i++)
            {
                Console.WriteLine(num % 10);
            }
        }
       

    }
}
