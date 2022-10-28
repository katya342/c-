using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region old
            //List<int> arr = new List<int>();
            //Random rnd = new Random();

            //int totalNumbers = rnd.Next(1, 10);

            //for (int i = 0; i <= totalNumbers; i++)
            //{
            //    arr.Add(rnd.Next());
            //    Console.WriteLine(arr[i] + " ");
            //}


            //int k = 0;
            //while(k == totalNumbers)
            //{
            //    Console.WriteLine(arr[k++]);
            //}
            //do
            //{
            //    Console.WriteLine(arr[k++]);
            //}
            //while(k < totalNumbers);
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //int sex = 1;

            //switch(sex)
            //{
            //    case 1:
            //        Console.WriteLine(" "); break;

            //        case 2:
            //        Console.WriteLine(" "); break;
            //    default:
            //        Console.WriteLine(" "); break;
            //}
            //int[] myArr = new int[5];
            //for (int i = 0; i < 4; i++)
            //{
            //    myArr[i] = rnd.Next();
            //}

            //int[,] myArr2 = new int[5, 5];
            //for (int i = 0;i < myArr2.Length; i++)
            //{
            //    for (int j = 0; j < myArr2.Length; j++)
            //    {
            //        myArr2[i, j] = rnd.Next();
            //    }
            //}

            //string name = "Katya";
            //string fName = "Bezverkhova";

            //if(name.CompareTo(fName) > 0)
            //{

            //}
            //if(name.Equals(fName))
            //{

            //}

            //string fulName = string.Concat(name, " ", fName);

            //bool exist = fulName.Contains("Bezverkhova");

            //string cardNumber = "3535 535 5353 535";
            //cardNumber = cardNumber.Trim();
            //cardNumber = cardNumber.Replace("", "");                    // toLower           // toPower// 

            //string TypeCard = cardNumber.Substring(0, 3);
            //if(cardNumber.StartsWith("3535"))
            //{
            //    Console.WriteLine("Visa");
            //}

            //else if(cardNumber.StartsWith("4444"))
            //{
            //    Console.WriteLine("MassterCard");
            //}
            //else
            //{
            //    Console.WriteLine("Undefine");
            //}

            //string url = "http://www.phaeton.kz";
            //int pos1 = url.IndexOf("&");

            //string[] arrCardNumber = cardNumber.Split(' ');
            //var temp = string.Join("*", arrCardNumber);
            //Console.WriteLine("Nomer card: " + arrCardNumber[0] + "****" + arrCardNumber[1] + "****" + arrCardNumber[2]);

            //string email = "katya.bezverkhova@mail.ru";
            //string mailCompany = email.Substring(email.IndexOf("@") + 1);
            //string shortName = name[0].ToString();

            //if(name == shortName)
            //{
            //    Console.WriteLine("555" + "123");
            //}
            //foreach(char item in name)
            //{

            //}
            #endregion

            Task1();

        }
   
        static void Task1()
        {
            

            Random random = new Random();
            int[] A = new int[5];
            int first = A[0];
            int last = A[0];
            double[,] B = new double[3, 4];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = random.Next();
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]);
            }
            Console.WriteLine("");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine("");
            }
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > first)
                {
                    first = A[i];
                }
                else if(A[i] < last)
                {
                    last = A[i];
                }

            }
            Console.WriteLine("Maximum: " + first);
            Console.WriteLine("Minimum: " + last);
            for (int i = 0; i < A.Length; i++)
            {
                sum = sum + A[i];
            }
            Console.WriteLine("Summa elementov: " + sum);
            int p = 1;
            for (int i = 0; i < A.Length; i++)
            {
                p = p * A[i];
            }
            Console.WriteLine("Proizvedenie: " + p);
            int sum_2 = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] % 2 == 0)
                {
                    sum_2 = sum_2 + A[i];
                }
                
            }
            Console.WriteLine("Summa chetnih el: " + sum_2);
            double summa = 0;
            for (int j = 0; j < 4; j++)
            {
               
                if(B[0, j] % 2 != 0)
                {
                    summa = summa + B[0, j];
                }
            }
            Console.WriteLine("Summa nechetnih elem massiva B: " + summa);
        }

    }
}
