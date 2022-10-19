using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dz_2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello application aaaa avfev efef";
            //for(int i = 0; i < str.Length; i++)
            // {
            //     if(str[i] == 'a')
            //     {
            //         str = str.Substring(0, 'a');
            //     }
            // }
            //string str = @"фаыв ппперре вфа ккур а афыв";
            //str = string.Join(" ", str.Split().Where(x => !x.Contains('а')));
            //Console.WriteLine(str);
            str = string.Join(" ", str.Split().Where(x => !x.Contains('a')));
            Console.WriteLine(str);
            // Console.WriteLine("Enter string: ");
            // string str = Console.ReadLine();
            // char [] mass = str.ToCharArray();
            //// string str = Console.ReadLine();
            // for(int i = 0; i < mass.Length; i++)
            // {
            //     if(mass[i] == 'a')
            //     {
            //         mass[i] = ' ';
            //     }
            //     Console.Write(mass[i]);
            // }
            // int[] arr = new int[10];
            //#region old
            //#endregion

            //method();
            //insert(arr, -5, 2);

        }
        
        //static void method()
        //{
        //    int[] arr = new int[10];
        //    int i = 0;
        //    Random rnd = new Random();

        //    for (i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = rnd.Next(20);
        //    }
        //    for (i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //    int max = arr[0];
        //    int temp = 0;
        //    int count = 0;

        //    for (i = 0; i < arr.Length; i++)
        //    {
        //        if(arr[i] > max)
        //        {
        //            max = arr[i];
        //            temp = i;
        //        }

        //       else if(arr[i] > max && arr[i] % 2 == 0)
        //            {
        //            count = i;
        //        }
        //    }
        //    // Console.WriteLine("max: " + max);
        //    Console.WriteLine("index of max el: " + temp);
        //    Console.WriteLine("index of maximum chetnogo el is: " + count);
        //    Console.WriteLine("Enter deleting index: ");
        //    int indexToRm = Convert.ToInt32(Console.ReadLine());
        //    //   arr = arr.Where((source, index) => index !== indexToRm).ToArray();
        //    arr = arr.Where((source, index) => index != indexToRm).ToArray();
        //    Console.WriteLine("Array after deletion: ");
        //    for (i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }

        //}
        //static void insert(int [] array, int value, int index)
        //{
        //   int[] newArray = new int[array.Length + 1];
        //    newArray[index] = value;
        //    for (int i = 0; i < index; i++)
        //    {
        //        newArray[i] = array[i];
        //    }
        //    for (int i = index; i < array.Length; i++)
        //    {
        //        newArray[i + 1] = array[i];
        //    }
        //    array = newArray;
        //}
       

    }
}
