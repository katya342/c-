using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    
    public class Tank
    {
        public int ArmorName;
        public int AmmunitionName;
        public string TankName;
        public int Maneuverability;
        
        
        public Tank ()
        {
           //this.TankName = nm;
        }

        //{
        //       new Tank()
        //       {
        //           TankName = "Pantera", ArmorName = rnd.Next(0, 100), AmmunitionName = rnd.Next(0, 100), Maneuverability = rnd.Next(0,100)
        //       },
        //        new Tank()
        //       {
        //           TankName = "Pantera", ArmorName = rnd.Next(0, 100), AmmunitionName = rnd.Next(0, 100), Maneuverability = rnd.Next(0,100)
        //       },
        //         new Tank()
        //       {
        //           TankName = "Pantera", ArmorName = rnd.Next(0, 100), AmmunitionName = rnd.Next(0, 100), Maneuverability = rnd.Next(0,100)
        //       },
        //          new Tank()
        //       {
        //           TankName = "Pantera", ArmorName = rnd.Next(0, 100), AmmunitionName = rnd.Next(0, 100), Maneuverability = rnd.Next(0,100)
        //       },
        //           new Tank()
        //       {
        //           TankName = "Pantera", ArmorName = rnd.Next(0, 100), AmmunitionName = rnd.Next(0, 100), Maneuverability = rnd.Next(0,100)
        //       },
        //};

        //    {
        //        new Tank()
        //        {
        //            TankName = "t34", ArmorName = rnd.Next(0, 100), AmmunitionName = rnd.Next(0, 100), Maneuverability = rnd.Next(0,100)
        //        },
        //         new Tank()
        //        {
        //            TankName = "t34", ArmorName = rnd.Next(0, 100), AmmunitionName = rnd.Next(0, 100), Maneuverability = rnd.Next(0,100)
        //        },
        //          new Tank()
        //        {
        //            TankName = "t34", ArmorName = rnd.Next(0, 100), AmmunitionName = rnd.Next(0, 100), Maneuverability = rnd.Next(0,100)
        //        },
        //           new Tank()
        //        {
        //            TankName = "t34", ArmorName = rnd.Next(0, 100), AmmunitionName = rnd.Next(0, 100), Maneuverability = rnd.Next(0,100)
        //        },
        //            new Tank()
        //        {
        //            TankName = "t34", ArmorName = rnd.Next(0, 100), AmmunitionName = rnd.Next(0, 100), Maneuverability = rnd.Next(0,100)
        //        },

        //    };

        //public void CountWinsT35()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        int CountWinT34 = 0;

        //        if (t34[i].AmmunitionName > pantera[i].AmmunitionName && t34[i].Maneuverability > pantera[i].Maneuverability || t34[i].ArmorName > pantera[i].ArmorName && t34[i].Maneuverability > pantera[i].Maneuverability)
        //        {
        //            CountWinT34++;
        //            Console.WriteLine("Кол-во очков победы танка t34 в бою: {0}", CountWinT34);
        //        }

        //    }
        //}
        public void ListingAddPantera()
        {
            Random rnd = new Random();
            List<Tank> t34 = new List<Tank>
                    {
                        new Tank()
                        {
                            TankName = "t34", ArmorName = rnd.Next(0, 100), AmmunitionName = rnd.Next(0, 100), Maneuverability = rnd.Next(0,100)
                        },
                         new Tank()
                        {
                            TankName = "t34", ArmorName = rnd.Next(0, 100), AmmunitionName = rnd.Next(0, 100), Maneuverability = rnd.Next(0,100)
                        },
                          new Tank()
                        {
                            TankName = "t34", ArmorName = rnd.Next(0, 100), AmmunitionName = rnd.Next(0, 100), Maneuverability = rnd.Next(0,100)
                        },
                           new Tank()
                        {
                            TankName = "t34", ArmorName = rnd.Next(0, 100), AmmunitionName = rnd.Next(0, 100), Maneuverability = rnd.Next(0,100)
                        },
                            new Tank()
                        {
                            TankName = "t34", ArmorName = rnd.Next(0, 100), AmmunitionName = rnd.Next(0, 100), Maneuverability = rnd.Next(0,100)
                        },

                };
            List<Tank> pantera = new List<Tank>
            {
                new Tank()
                {
                    TankName = "Pantera",
                    ArmorName = rnd.Next(0, 100),
                    AmmunitionName = rnd.Next(0, 100),
                    Maneuverability = rnd.Next(0, 100)
                },
                    new Tank()
                    {
                        TankName = "Pantera",
                        ArmorName = rnd.Next(0, 100),
                        AmmunitionName = rnd.Next(0, 100),
                        Maneuverability = rnd.Next(0, 100)
                    },
                     new Tank()
                     {
                         TankName = "Pantera",
                         ArmorName = rnd.Next(0, 100),
                         AmmunitionName = rnd.Next(0, 100),
                         Maneuverability = rnd.Next(0, 100)
                     },
                      new Tank()
                      {
                          TankName = "Pantera",
                          ArmorName = rnd.Next(0, 100),
                          AmmunitionName = rnd.Next(0, 100),
                          Maneuverability = rnd.Next(0, 100)
                      },
                       new Tank()
                       {
                           TankName = "Pantera",
                           ArmorName = rnd.Next(0, 100),
                           AmmunitionName = rnd.Next(0, 100),
                           Maneuverability = rnd.Next(0, 100)
                       },
            };
            foreach (var item in pantera)
            {
               Console.WriteLine("Номер танка: {0} Маневренность танка Pantera: {1}(%), Уровень брони танка Pantera {2}(%), Уровень боекомплекта танка Pantera {3}(%)", item.TankName, item.Maneuverability, item.ArmorName, item.AmmunitionName);

            };
            foreach (var item in t34)
            {
                Console.WriteLine("Номер танка: {0} Маневренность танка t34: {1}(%), Уровень брони танка t34 {2}(%), Уровень боекомплекта танка t34 {3}(%)", item.TankName, item.Maneuverability, item.ArmorName, item.AmmunitionName);

            }
            for (int i = 0; i < 5; i++)
            {
                int CountWinT34 = 0;

                if (t34[i].AmmunitionName > pantera[i].AmmunitionName && t34[i].Maneuverability > pantera[i].Maneuverability || t34[i].ArmorName > pantera[i].ArmorName && t34[i].Maneuverability > pantera[i].Maneuverability)
                {
                    CountWinT34++;
                    Console.WriteLine("Кол-во очков победы танка t34 в бою: {0}", CountWinT34);
                }
               

            }
            
//for (int i = 1; i < 6; i++)
          //  {
                //pantera.Add(ArmorName = rnd.Next(0, 100));
                //pantera.Add(Maneuverability = rnd.Next(0, 100));
                //pantera.Add(AmmunitionName = rnd.Next(0, 100));
                //Console.WriteLine("Номер танка: {0} Маневренность танка Pantera: {1}(%), Уровень брони танка Pantera {2}(%), Уровень боекомплекта танка Pantera {3}(%)", Maneuverability, ArmorName, AmmunitionName);

            //}
        }
        //public void ListingAddTank34()
        //{
        //    List<int> t34 = new List<int>();
        //    Random rnd = new Random();
        //    for (int i = 0; i < 5; i++)
        //    {
        //        t34.Add(ArmorName = rnd.Next(0, 100));
        //        t34.Add (Maneuverability = rnd.Next(0, 100));
        //        t34.Add(AmmunitionName = rnd.Next(0, 100));
        //        Console.WriteLine("Номер танка: {0} Маневренность танка t34: {1}(%), Уровень брони танка t34 {2}(%), Уровень боекомплекта танка t34 {3}(%)", i, Maneuverability, ArmorName, AmmunitionName);
        //    }           
        //}
   
    }
}
