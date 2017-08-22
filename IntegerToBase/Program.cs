using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(IntegerToBase(number, toBase));
        }

        static string IntegerToBase(long number, int toBase)
        {
            string result = string.Empty;
            while (number > 0)
            {
                result += Convert.ToString(number % toBase);
                number /= toBase;
            }
            return new string(result.ToCharArray().Reverse().ToArray());
        }
    }
}

