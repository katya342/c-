using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public class Program
    {
        delegate void GetMessage();
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {

            Operation del = new Operation(Add);
            int rezult = del.Invoke(4, 5);
           // ShowMessage(GoodMornin);
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Good mornin");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good evening");
        }
        private static int Add(int x, int y)
    {
        return x + y;
    }
    private static int Multiply(int x, int y)
    {
        return x * y;
    }
        private static void ShowMessage(GetMessage delM)
        {
            delM.Invoke();
        }
    }
    public class Account
    {
        int _sum;
        int _percentage;
        public Account(int _sum, int _percentage)
        {
            this._sum = _sum;
            this._percentage = _percentage;
        }
        public delegate void AccountStateHandler(string message);
        AccountStateHandler del;
        public void RegisterHandler(AccountStateHandler _del)
        {
            del = _del;
        }
    }
}
