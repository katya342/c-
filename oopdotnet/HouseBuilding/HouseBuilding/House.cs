using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public class House
    {
        private List<IPart> parts = new List<IPart>();
        public House()
        {

        }
        public void CreateHouse(int value)
        {
       
            switch (value)
            {
                case 1: 
                    Basement basement = new Basement();
                    basement.Color = null;
                    basement.InstallationTime = new TimeSpan(5, 8, 0, 0);
                    basement.Count = 1;
                    basement.PriceFabric = 9000;
                    parts.Add(basement);
                    for(int i = 0; i < 8; i++)
                    {
                        Walls walls = new Walls();
                        walls.Color = null;
                        walls.InstallationTime = new TimeSpan(0, 16, 1, 2);
                        walls.Count = 8;
                        walls.PriceFabric = 900;
                        parts.Add(walls);
                    }
      
                    for (int i = 0; i < 4; i++)
                    {
                        Door door = new Door();
                        door.Color = null;
                        door.InstallationTime = new TimeSpan(0, 2, 3, 0);
                        door.Count = 4;
                        door.PriceFabric = 100;
                        parts.Add(door);
                    }
                   
                    Roof roof = new Roof();
                    roof.Color = null;
                    roof.InstallationTime = new TimeSpan(0, 2, 2, 0);
                    roof.PriceFabric = 1000;
                    roof.Count = 1;
                    parts.Add(roof);
                    Window window = new Window();
                    window.Color = null;
                    window.InstallationTime = new TimeSpan(5, 0, 0, 0);
                    window.PriceFabric = 345;
                    window.Count = 1;
                    parts.Add(window);
                    break;
            }

        }
        public List<IWorker> CreateTeam()
        {
           List<IWorker> workerList = new List<IWorker>();
           Random rnd = new Random();
            for (int i = 0; i < rnd.Next(5, 50); i++)
            {
                Worker worker = new Worker();
                worker.Name = "Рабочий #" + i;
           
                worker.PricePerHour = rnd.Next(100, 5000);
                worker.WorkLists = new List<IPart>();
                workerList.Add(worker);
            }
 
            return workerList;
        }
        public void StartConstruction()
        {
            CreateHouse(1);
            List <IWorker> people = CreateTeam();
            int k = people.Count;
            Random rnd = new Random();
            foreach (IPart item in parts)
            {
                if(!item.IsCompleted)
                {
                    //people.FirstOrDefault(f => !f.isBusy);
                    people[rnd.Next(0, k - 1)].WorkLists.Add(item);
                    for (int i = 0; i < item.InstallationTime.Hours; i++)
                    {
                        Console.WriteLine("");
                        Thread.Sleep(100);
                    }
                    Console.WriteLine("Completed");
                    item.IsCompleted = true;
                }
            }
            foreach (Worker item in people.Where(w=>w.WorkLists.Count>0))
            {
                item.PrintSalaryInfo();
            }
            Console.WriteLine("--------------------------");
            foreach (Worker item in people.Where(w => w.WorkLists.Count < 0))
            {
                item.PrintSalaryInfo();
            }
        }
    }
}
