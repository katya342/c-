using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_dz
{
    internal class Stationery
    {
        public static string Color { get; set; }
        public static string Quality { get; set; }
        private int Count { get; set; }
        private string Name { get; set; }
        private int PricePerOne { get; set; }

        private string State { get; set; }
        private string Description { get; set; }
        public Stationery()
        {

        }
        static Stationery()
        {
            Quality = "OK";
            Color = "red";
        }
        public Stationery(string nm, string st)
        {
            this.Name = nm;
            this.State = st;     
        }
        public Stationery(string nm, string st, string descrp) : this(nm, st)
        {
            this.Description = descrp;
        }
        public Stationery(string nm, string st, string descrp, int cnt, int prcpone) : this(nm, st, descrp)
        {
            this.Count = cnt;
            this.PricePerOne = prcpone;
        }
        public void SetName (string nm)
        {
            this.Name = nm;
        }
        public string GetName()
        {
            return this.Name;
        }
        public void setCount (ref int cnt)
        {
            this.Count = cnt;
        }
        public void SetPricePerOne(ref int pr)
        {
            this.PricePerOne = pr;
        }
        public int FullPrice()
        {
            return this.Count * this.PricePerOne;
        }
        public void Display ()
        {
            Console.WriteLine("Название {0}, Кол-во {1}, Цена {2}, Описание {3}, Состояние {4}", Name, Count, PricePerOne, Description, State);
        }

        
    }
}
