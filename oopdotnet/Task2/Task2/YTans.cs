using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Trans
    {
        public Trans() : this(0, 0)
        {

        }
        public Trans(int CarWeight, int MaxWeight)
        {
            this.CarWeight = CarWeight;
            this.MaxWeight = MaxWeight;
        }


        public string CarType { get; set; }
        public int CarWeight { get; set; }
        public int MaxWeight { get; set; }


        public abstract void GetTransInfo();

        public virtual string WeightInfo()
        {
            return string.Format("Грузоподъемность равна: {0}",
                (MaxWeight - CarWeight));
        }

        public virtual double WeightParam()
        {
            return (MaxWeight / CarWeight);
        }

    }

    public interface ITrans
    {
        string CarType { get; set; }
        int CarWeight { get; set; }
        int MaxWeight { get; set; }

        void GetTransInfo();
        string WeightInfo();
        double WeightParam();
    }

    public interface ITransMethos
    {
        void PrintInfo();
        void CalculetaCost();
    }

    public interface ITransAdditionalParam
    {
        string VinCode { get; set; }
        string Color { get; set; }
        bool IsAirplane { get; set; }
    }

    public class Transport : ITrans, ITransMethos, ITransAdditionalParam
    {
        //-1 interface
        public string CarType { get; set; }
        public int CarWeight { get; set; }
        public int MaxWeight { get; set; }

        public void GetTransInfo()
        {

        }

        public string WeightInfo()
        {
            return "";
        }

        public double WeightParam()
        {
            return 0;
        }

        //-2 inetrfeca
        public void PrintInfo()
        {

        }
        public void CalculetaCost()
        {

        }

        //- 3 interface
        public string VinCode { get; set; }
        public string Color { get; set; }
        public bool IsAirplane { get; set; }

        //add prop
        public int Cost { get; set; }
        public string TransportCode { get; set; }
    }
}
