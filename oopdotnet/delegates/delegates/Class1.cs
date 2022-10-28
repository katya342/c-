using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{

    public delegate void GetMessage();
    public class Class1
    {
        public void ShowMessage(GetMessage _del)
        {
            GetMessage del = _del ; // Создаем переменную делегат
         
            del.Invoke(); // вызов метода
        }
        
    }
}
