using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Motorcycle : YTans
    {
        public Motorcycle(int maxW, int carW): base(carW, maxW)
        {
            
        }
        public string MotoType { get; set; }
        public string Number { get; set; }
        public int Speed { get; set; }
        public bool WheelChairs { get; set; }

        public override void GetTransInfo()
        {
            Console.WriteLine("Private information");
        }
        public override string WeightInfo()
        {
            return string.Format("Грузоподьемность равна: {0}", (MaxWeight - CarWeight)/0.25);
        }
    }
}
