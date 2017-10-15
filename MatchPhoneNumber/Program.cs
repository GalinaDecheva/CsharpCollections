using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {   
            Regex pattern = new Regex(@"\+359([ -])2\1\d{3}\1\d{4}\b");
            String input = Console.ReadLine();

            MatchCollection matchCollection = pattern.Matches(input);
            StringBuilder builder = new StringBuilder();

            foreach (Match m in matchCollection) {
                builder.Append(m + ", ");
            }
            if (builder.Length >= 2)
            {
                builder.Remove(builder.Length - 2, 2);
            }
            Console.WriteLine(builder.ToString());

        }
    }
}
