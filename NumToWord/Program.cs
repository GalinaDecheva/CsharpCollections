using System;

namespace NumToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(Letterize(input));
            }
        }

        static string Letterize(int number)
        {
            bool isNegative = number < 0;
            string result = string.Empty;

            string[] words = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

            string[] wordsDecades = { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number > 999)
            {
                result = "too large";
            }

            if (number < -999)
            {
                result = "too small";
            }

            if (isNegative) number = -number;
            bool isThreeDigit = (number > 99) && (number < 1000);

            if (isThreeDigit)
            {
                if (isNegative)
                {
                    result += "minus ";
                }
                result += words[number / 100] + "-hundred";
                number %= 100;
                if(number != 0)
                {
                    result += " and ";
                    if(number < 20)
                    {
                        result += words[number];
                    }
                    else
                    {
                        result += wordsDecades[number / 10] + " " + words[number % 10];
                    }
                }
            }

            return result;
        }
    }
}