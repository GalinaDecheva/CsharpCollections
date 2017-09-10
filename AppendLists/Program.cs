using System;
using System.Collections.Generic;
using System.Linq;


namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split('|').Reverse().ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                List<int> temp = list[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                result.AddRange(temp);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
