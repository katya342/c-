using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    
    public interface IWorker
    {
        string Name { get; set; }
        string PricePerHour { get; set; }
        List<IPart> WorkLists { get; set; }
        bool IsCompleted { get; set; }
    }
}
