using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            list.RemoveAll(a => a < 0);
            list.Reverse();
            Console.WriteLine(list.Count == 0 ? "empty": string.Join(" ", list));

        }
    }
}

