using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money money_1 = new Money(100, "USD");
            Money money_2 = new Money(300, "USD");
            Console.WriteLine(money_1);
            Money money_3 = money_1 + money_2;
            Number num = (Number)money_1;
            var data = "";
        }
    }
}
