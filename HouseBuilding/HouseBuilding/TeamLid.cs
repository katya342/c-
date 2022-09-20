using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    internal class TeamLid : IWorker
    {
        public string Name { get; set; }
        public string PricePerHour { get; set; }
        public List<IPart> WorkLists { get; set; }
        public bool IsCompleted { get; set; }
    }
}
