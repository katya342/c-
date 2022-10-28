using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public class Door : IPart
    {
        public string Color { get; set; }
        public TimeSpan InstallationTime { get; set; }
        public int Count { get; set; }
        public TypeFabric TypeFabric { get; set; }
        public double PriceFabric { get; set; }
        public int Sort { get; set; }
        public bool IsCompleted { get; set; }

        public System.Nullable<int>TypeDoor = null;
        //public int? TypeDoor = null;
        public TimeSpan GetConstructionTime()
        {
            var data = TypeDoor ?? 0;
            if(TypeDoor == null)
            {
                data = 0;
            }
            return TimeSpan.FromTicks(InstallationTime.Ticks * Count);
        }
        public double GetPriceFabric()
        {
            return Count * PriceFabric;
        }
    }
}
