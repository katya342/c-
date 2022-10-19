using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_structure
{
    public interface ICooperators
    {
        int AverageSalary { get; set; }
        string Salary { get; set; }
        string HireDate { get; set; }
        string Sex { get; set; }
    }
}
