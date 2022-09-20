using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    internal class Window: IPart
    {
        public string Color { get; set; }
        public TimeSpan InstallationTime { get; set; }
        public int Count { get; set; }
        public TypeFabric TypeFabric { get; set; }
        public double PriceFabric { get; set; }
        public int Sort { get; set; }
        public bool IsCompleted { get; set; }

        public TimeSpan GetConstructionTime()
        {
            return TimeSpan.FromTicks(InstallationTime.Ticks * Count);
        }

        public double GetPriceFabric()
        {
            return Count * PriceFabric;
        }
    }
}
