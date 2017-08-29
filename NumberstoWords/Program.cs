using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberstoWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number;
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                Console.WriteLine(Letterize(number));
            }


        }


        static string Letterize(int number)
        {
            if (number > 999)
            {
                return "too large";
            }
            else if (number < -999)
            {
                return "too small";
            }
            else if (number < -99 && number >= -999)
            {
                return "minus";
            }
            else if (number > 0 && number < 99)
            {
                return "";
            }
            else if (number > 100 && number < 999)
            {

                int hundreds = number / 100;



                if (number % 100 == 0)
                {

                    return fromZeroToNineteen(hundreds) + "-hundred";
                    if (number % 100 == 0 && number / 10 == 0)
                    {
                        return fromZeroToNineteen(number) + tweens(number);
                    }
                }
                else
                {
                    return fromZeroToNineteen(hundreds) + "-hundred and " + fromZeroToNineteen(number % 100);
                }
            }
            return "";
        }

        static string fromZeroToNineteen(int number)
        {
            switch (number)
            {
                case 0: return ("zero");
                case 1: return ("one");
                case 2: return ("two");
                case 3: return ("three");
                case 4: return ("four");
                case 5: return ("five");
                case 6: return ("six");
                case 7: return ("seven");
                case 8: return ("eight");
                case 9: return ("nine");
                case 10: return ("ten");
                case 11: return ("eleven");
                case 12: return ("twelwe");
                case 13: return ("thirteen");
                case 14: return ("fourteen");
                case 15: return ("fivteen");
                case 16: return ("sixteen");
                case 17: return ("seventeen");
                case 18: return ("eighteen");
                case 19: return ("nineteen");
                default: return "";

            }
        }

        static string Hundreds(int number)
        {
            switch (number)
            {
                case 100: return ("one-hundred");
                case 200: return ("two-hundred");
                case 300: return ("three-hundred");
                case 400: return ("four-hundred");
                case 500: return ("five-hundred");
                case 600: return ("six-hundred");
                case 700: return ("seven-hundred");
                case 800: return ("eight-hundred");
                case 900: return ("nine-hundred");


                default: return "";

            }
        }

        static string tweens(int number)
        {
            switch (number)
            {
                case 20: return ("twenty");
                case 30: return ("thirty");
                case 40: return ("fourty");
                case 50: return ("fivty");
                case 60: return ("sixty");
                case 70: return ("seventy");
                case 80: return ("eighty");
                case 90: return ("ninety");


                default: return "";

            }
        }

        static string fromNineteenTo99(int number)
        {
            int tens = number / 10;
            return tweens(tens) + fromZeroToNineteen(number % 10);
        }
    }

}


 //if (number > 119 && number< 999)
 //               {
 //                   if (number / 10 == 0)
 //                   {
 //                       return Hundreds(number) + tweens(number);
 //                   }
 //                   else
 //                   {
 //                       return fromNineteenTo99(number);
 //                   }
 //               }




