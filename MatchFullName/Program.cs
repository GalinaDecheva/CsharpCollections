using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            String names = Console.ReadLine();
            MatchCollection matches = pattern.Matches(names);
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Groups[0] + " ");
            }
            Console.WriteLine();
        }
    }
}
