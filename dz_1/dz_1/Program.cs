using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DZ_1();
        }
        static void DZ_1()
        {
            Console.WriteLine("Введите ФИО: ");
            string name = Console.ReadLine();
            Console.WriteLine("Приветствую тебя - " + name);
            int sum = 0;
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Введите число: ");
                int numbers = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter numbers: " + numbers);
                sum = sum + numbers;
            }
            Console.WriteLine("Summa: " + sum);
        }
    }
}
