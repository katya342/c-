using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public enum TypeFabric { brick, wool}
   
    public class Program
    {
        static void Main(string[] args)
        {

            House house = new House();
            house.CreateHouse(4);
            house.CreateTeam();
            house.StartConstruction();
           // evalEnum();
            //var data = (int)TypeFabric.brick;
            //var data_s = TypeFabric.brick.ToString();
            //TypeFabric typeFabric = TypeFabric.brick;
            //EvalEnum(typeFabric);
            //var ch = 5;
            //if(!Enum.IsDefined(typeof(TypeFabric), ch))
            //{

            //}
            //string typeMaterialCwl = Console.ReadLine();
            //TypeFabric rezult = (TypeFabric)Enum.Parse(typeof(TypeFabric), typeMaterialCwl);
            //Door door = new Door();
            //if(door?.Color == "")
            //{

            //}
            //if(door != null && door.Color == "")
            //{

            //}
        }
        public void evalEnum(System.Enum e)
        {
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine(enumData.Length);
            for(int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0} Value: {1}", enumData.GetValue(i));
            }
        }
    }
}
