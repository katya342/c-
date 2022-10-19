using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Transport transport = new Transport();
            
            transport.CarType = "";
            transport.CarWeight = 0;
            transport.MaxWeight = 0;
            //add
            transport.Cost = 0;
            transport.TransportCode = "";

            ITrans trans = new Transport();
            trans.CarType = "";
            trans.CarWeight = 0;
            trans.MaxWeight = 0;

            
            //Random rnd = new Random();
            //CarListing carListing = new CarListing();
            //for(int i = 0; i < 5; i++)
            //{
            //    var cr = new Car();
            //    cr.CarType = "dwmwkdw" + i;
            //    cr.Speed = rnd.NextDouble();
            //    carListing.ListingAdd(new Car())
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    carListing.ListingAdd(new Motorcycle(rnd.Next(0, 2500), rnd.Next(0, 500)));
            //}
        }
    }
}
