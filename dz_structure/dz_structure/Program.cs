using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_structure
{
    public enum Jobs { Engineer, Doctor, Pilot, Fireman, Driver, SalesManager }
    public enum Name { Katya, Nurzhan, Asir, Dimitry, EvgenBro, cat}
    public enum Surname { Ivanov, IvanovSecond, IvanovThird, IvanovFourth, IvanovFive, IvanovSixth}
    public class Program
    {
       
        static void Main(string[] args)
        {
            CooperatorsStructure cooperators = new CooperatorsStructure();
            cooperators.PrintJobInfo();
            //cooperators.GetHireDate();
            // cooperators.PrintNameInfo();
            Console.WriteLine("Поиск по должности -----------------------------");
            Console.WriteLine("Введите должность:");
            Console.WriteLine("0 - engineer, 1 - doctor, 2 - pilot, 3 - fireman, 4 - driver, 5 - salesManager");
            int temp = Convert.ToInt32(Console.ReadLine());
            cooperators.SearchByJob(temp);
            cooperators.AddSalaryToList();
            cooperators.GetSex("Female");
           // cooperators.GetHireDate();
        }
    }
}
