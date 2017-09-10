using System;

namespace ResizableArray
{
    class Program
    {
        static int[] arr = new int[4];
        static int count = 0;

        static void Push(int number)
        {
            if (count >= arr.Length)
            {
                IncreaseLength();
            }
            arr[count] = number;
            count++;
        }

        static void Pop()
        {
            count--;
        }

        static void RemoveAt(int index)
        {
            for (int i = index; i < count - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            count--;
        }

        static void Clear()
        {
            count = 0;
        }

        static void IncreaseLength()
        {
            int[] newArr = new int[2 * arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
        }

        static void PrintResizableArray()
        {
            if(count == 0)
            {
                Console.WriteLine("empty array");
            }
            else
            {
                for(int i = 0; i < count; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commandLine = input.Split(' ');
                string command = commandLine[0];
                switch (command)
                {
                    case "push":
                        Push(int.Parse(commandLine[1]));
                        break;
                    case "pop":
                        Pop();
                        break;
                    case "removeAt":
                        RemoveAt(int.Parse(commandLine[1]));
                        break;
                    case "clear":
                        Clear();
                        break;
                    default: break;
                }
            }
            PrintResizableArray();

        }
    }
}
