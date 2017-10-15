using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



class Program
{
    static void Main(string[] args)
    {
        Regex pattern = new Regex("(?:https?|ftp)://([^/]+)(/.*)");
        String text = @"sfdafsdfa gdhdg
                            http://alabala.bg/resource
                            Text messaging, or texting, ";
        

        //if (pattern.IsMatch(text))
        //{
        //    Console.WriteLine("Pattern matches text");

        //}
        Match match = pattern.Match(text);
        match = pattern.Match(text);
        //Console.WriteLine("First match found: {0}", match.Groups[0]);
        //Console.WriteLine(match.Groups[1]);
        //Console.WriteLine(match.Groups[2]);
        MatchCollection matches = pattern.Matches(text);

        //foreach (Match m in matches)
        //{
        //    Console.WriteLine("Match found: {0}", m.Groups[0]);
        //}
        //return;

        foreach (Group g in match.Groups)
        {
            Console.WriteLine("Group: {0}",g);
        }
        //return;

        string result = pattern.Replace(text,"****");
        Console.WriteLine(result);
    }
}

