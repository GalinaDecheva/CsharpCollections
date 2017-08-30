using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isIncreasing = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] >= arr[i + 1])
                {
                    isIncreasing = false;
                    break;
                }

            }
            Console.WriteLine(isIncreasing ? "Yes" : "No");
            //if(isIncreasing)
            //{
            //    Console.WriteLine("Yes");
            //} else
            //{
            //    Console.WriteLine("No");
            //}
            //Console.WriteLine(IsInreasing(arr));
        }

        //static string IsInreasing(int[] array)
        //{
        //    for (int i = 0; i < array.Length - 1; i++)
        //    {
        //        if (array[i] >= array[i + 1])
        //        {
        //            return "No";
        //        }

        //    }
        //    return "Yes";
        //}
    }
}
