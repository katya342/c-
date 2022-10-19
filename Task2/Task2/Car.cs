using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Car : YTans
    {
        public Car(int MxSpd = 240)
        {
            this.MaxSpeed = MxSpd;
        }
        private int Speed_;
        public readonly int MaxSpeed;
        public string Name { get; set; }
        public string Model { get; set; }
        public int Speed {
            get
            {
                return Speed_;
            }
            set
            {
                if (value >= MaxSpeed)
                {
                    throw new Exception("Снизьте скорость пожалуйста");
                }
                else
                {
                    Speed = value;
                }

            }
        }
        public override string WeightInfo()
        {
            return string.Format("Грузоподьемность равна: {0}", MaxWeight - CarWeight);
        }

    }
}
