using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    internal class Worker : IWorker
    {
        public enum Profession { AnElectrician, StoneMan, Plumber }
        public string Name { get; set; }    
        public int PricePerHour { get; set; } 
        public List<IPart> WorkLists { get; set; }
        public bool IsBusy { get; set; }
        string IWorker.PricePerHour { get; set; }
        public bool IsCompleted { get; set; }

        public void PrintSalaryInfo()
        {
            double Salory = 0;
            foreach (IPart item in WorkLists)
            {
                Salory += item.InstallationTime.TotalHours * PricePerHour;
            }
            Console.WriteLine("Итого зарплата {0} {1} тенге", Name, Salory);
            Console.WriteLine("Обьем выполненных работ {0}", WorkLists.Count);
        }
    }
}
