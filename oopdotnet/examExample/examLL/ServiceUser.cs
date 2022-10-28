using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examLL
{
    public class ServiceUser
    {
        public List<Employeе> Employees = new List<Employeе>();
        private readonly string path;
        public ServiceUser(string Path)
        {
            this.path = Path;
        }
        public bool AddEmpleyee(Employeе employee)
        {
            try
            {
                using (var db = new LiteDatabase(this.path))
                {
                    // Get a collection (or create, if doesn't exist)
                    var col = db.GetCollection<Employeе>("Employee");
                    // Insert new customer document (Id will be auto-incremented)
                    col.Insert(employee);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        public void GetEmploye()
        {
            try
            {
                using (var db = new LiteDatabase(this.path))
                {
                    // Get a collection (or create, if doesn't exist)
                    Employees = db.GetCollection<Employeе>("Employee")
                        .FindAll().ToList();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}