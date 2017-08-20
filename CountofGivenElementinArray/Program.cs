using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountofGivenElementinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int input2 = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] == input2)
                {
                    count += 1;

                }
            }
            Console.WriteLine(count);
        }
        }
}
