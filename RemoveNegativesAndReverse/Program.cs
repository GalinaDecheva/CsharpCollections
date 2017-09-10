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
            List<int> list1 = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                list.Remove(-list[i]);
                

            }
            

        }
    }
}
