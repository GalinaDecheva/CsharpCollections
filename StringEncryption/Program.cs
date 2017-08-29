using System;

namespace StringEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] arr = new char[n];
            string output = string.Empty;
            for (int i = 0; i < n; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }
            foreach(char letter in arr)
            {
                output += Encrypt(letter);
            }
            Console.WriteLine(output);
        }

        static string Encrypt(char letter)
        {
            string result = string.Empty;
            result += GetFirstChar(letter);
            result += ConvertIntToChar(GetFirstDigit(letter));
            result += ConvertIntToChar(GetLastDigit(letter));
            result += GetLastChar(letter);
            return result;
        }

        static int GetFirstDigit(char letter)
        {
            if (letter > 99) return letter / 100;
            return letter / 10;
        }

        static int GetLastDigit(char letter)
        {
            return letter % 10;
        }

        static char GetFirstChar(char letter)
        {
            return (char)(letter + GetLastDigit(letter));
        }

        static char GetLastChar(char letter)
        {
            return (char)(letter - GetFirstDigit(letter));
        }

        static char ConvertIntToChar(int input)
        {
            return (char)(input + 48);
        }
    }
}
