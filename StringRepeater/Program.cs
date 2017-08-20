using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string input1 = Console.ReadLine();
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine(StringRepeater(input1, input2));
        }

        static string StringRepeater(string str, int count)
        {
            string StringRepeater = string.Empty;

            for (int i = 0; i < count; i++)
            {
                StringRepeater += str;
            }
            return StringRepeater;
        }

        
    }
}
