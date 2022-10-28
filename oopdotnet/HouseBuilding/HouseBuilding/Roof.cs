using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public class Roof : IPart
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
            throw new NotImplementedException();
        }

        public double GetPriceFabric()
        {
            throw new NotImplementedException();
        }
    }
}
