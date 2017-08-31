using System;

namespace CountOfCapitalLettersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int count = 0;
            foreach(string word in arr)
            {
                if (word.Length == 1 && word[0] >= 65 && word[0] <= 90) count++;
            }
            Console.WriteLine(count);
        }
    }
}
