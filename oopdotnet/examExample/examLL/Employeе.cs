using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace examLL
{
    public class Employeе
    {

        public int EmployeId { get; set; }
        //  public string Name { get; set;}
        public string FullName { get; set; }
        public DateTime BdayDate { get; set; }
        //    public JobTitle JobTitleId { get; set;}
        public int JobTitleId { set; get; }
        public int CityId { get; set; }
        public double SalaryFork { get; set; }
        public int DepartmentId { get; set; }
        // public Department Department { get; set; }
        public List<HistoryChanging> History = new List<HistoryChanging>();
        public override string ToString()
        {
            return string.Format("{0} | {1} | {2: dd MMM yyyy}",
                EmployeId, FullName, BdayDate);
        }
        //public HistoryChanging this[int index]
        //{
        //    get { return History.ElementAt(index); }
        //    set { History.Add(value); }
        //}
        public List<HistoryChanging> this[DateTime timeChange]
        {
            get { return History.Where(w => w.Changes == timeChange).ToList(); }
        }
    }
}
