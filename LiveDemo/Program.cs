using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>(8)
            //{
            //    1,
            //    2,
            //    2,
            //    10
            //};

            //list.Add(1);
            //list.Add(2);
            //list.Add(4);
            //Console.WriteLine("Before:");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //list.Remove(10);
            //list.RemoveAt(0);
            //list.RemoveAll(a => a == 2);
            //list.Insert(1, 100);
            //Console.WriteLine("After:");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}


            //List<int> list = new List<int>();
            //string[] input = Console.ReadLine().Split(' ');
            //for (int i = 0; i < input.Length; i++)
            //{
            //    list.Add(int.Parse(input[i]));
            //}
            //Console.WriteLine(string.Join("\n",list));
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            List<string> list = new List<string>()
            {
                "Ivan",
                "Galina",
                "Malina",
                "Aneliq"
            };
            list.Sort();
            list.Reverse();
            Console.WriteLine(String.Join(",", list));

        }
    }
}
