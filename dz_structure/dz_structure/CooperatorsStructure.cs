using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_structure
{
    public struct CooperatorsStructure : ICooperators
    {

        private int AverageSalary_;
        public int AverageSalary
        {
            set
            {
                this.AverageSalary_ = 250;
            }
            get
            {
                return this.AverageSalary_;
            }
        }
        public int Salary { get; set; }
        
        public string HireDate { get; set; }
        public string Sex { get; set; }
        int ICooperators.AverageSalary { get; set; }
        string ICooperators.Salary { get; set; }
        public List<int> AddSalaryToList()
        {
            List<int> addSal = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
               int temp = rnd.Next(200, 500);
               addSal.Add(temp);
               Console.WriteLine("{0} (тыс. тенге)", addSal[i]);
                if (addSal[i] > AverageSalary)
                {
                    Console.WriteLine("Name: {0} Surname: {1}", Name.Nurzhan, Surname.IvanovSecond);
                }
                else if(addSal[i] < AverageSalary)
                {
                    Console.Write("None found");
                }
            }
            return  addSal;
        }
       
        public DateTime GetHireDate()
        {
            List<DateTime> list = new List<DateTime>();
            DateTime data = new DateTime();
            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                DateTime temp = data.AddYears(random.Next(2000, 2022));
                DateTime tempSec = data.AddMonths(random.Next(1, 12));
                DateTime tempThird = data.AddDays(random.Next(1, 31));
               // string dates = Convert.ToString(tempThird + "." + tempSec + "." + temp);
                list.Add(data);
                Console.WriteLine(data);
            }
            return data;
        }
        
        public void GetSex(string sex)
        {
            this.Sex = sex;
            Console.WriteLine("Sex is: {0}", sex);
        }
        public void PrintJobInfo()
        {
            List<Jobs> enumColectionJobs = Enum.GetValues(typeof(Jobs)).Cast<Jobs>().ToList();
            List<Name> enumCollectionName = Enum.GetValues(typeof(Name)).Cast<Name>().ToList();
            List<Surname> enumCollectionSurnames = Enum.GetValues(typeof(Surname)).Cast<Surname>().ToList();
            for (int i = 0; i < enumCollectionName.Count; i++)
            {
                Console.WriteLine("Name: {0} ------>  Surname: {1} -------> Job: {2}", enumCollectionName[i], enumCollectionSurnames[i], enumColectionJobs[i]);
            }
           
        }
        
        public void SearchByJob(int value)
        {
           switch(value)
            {
                case 0: Console.WriteLine("Name is..... {0} | Surname is.......{1}", Name.Katya, Surname.Ivanov);
                    break;
                    case 1: Console.WriteLine("Name is..... {0} | Surname is.......{1}", Name.Nurzhan, Surname.IvanovSecond);
                    break;
                case 2: Console.WriteLine("Name is..... {0} | Surname is.......{1}", Name.Asir, Surname.IvanovThird);
                    break;
                case 3: Console.WriteLine("Name is..... {0} | Surname is.......{1}", Name.Dimitry, Surname.IvanovFourth);
                    break;
                case 4: Console.WriteLine("Name is..... {0} | Surname is.......{1}", Name.EvgenBro, Surname.IvanovFive);
                    break;
                case 5: Console.WriteLine("Name is..... {0} | Surname is.......{1}", Name.cat, Surname.IvanovSixth);
                    break;
            
                    
            }

        }
    }
}
