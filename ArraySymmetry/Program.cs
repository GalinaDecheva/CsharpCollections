using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            Console.WriteLine(arr.SequenceEqual(arr.Reverse()) ? "Yes" : "No");


            //string[] arrReversed = arr.Reverse().ToArray();
            //if (arr.SequenceEqual(arrReversed))
            //{
            //    Console.WriteLine("Yes");
            //} else
            //{
            //    Console.WriteLine("No");
            //}


            //bool areSymetric = true;
            //for (int i = 0; i < arr.Length / 2; i++)
            //{
            //    if (arr[i] != arr[arr.Length - 1 -i])
            //    {
            //        areSymetric = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(areSymetric ? "Yes" : "No");
        }
    }
}
