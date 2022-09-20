using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public interface IPart
    {
        string Color { get; set; }
        TimeSpan InstallationTime { get; set; }
        int Count { get; set; }
        TypeFabric TypeFabric { get; set; }
        double PriceFabric { get; set; }
        int Sort { get; set; }
        bool IsCompleted { get; set; }

        TimeSpan GetConstructionTime();

        double GetPriceFabric();
    }
}
