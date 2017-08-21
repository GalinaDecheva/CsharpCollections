using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number, index));

        }

        static int FindNthDigit(long number, int index)
        {
            while (number > 0 )
            {
                if (index == 1)
                {
                    return (int)(number % 10);
                }
                number /= 10;
                index--;
            }
            return 0;
        }

    }


}

    

