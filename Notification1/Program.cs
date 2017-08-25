using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string operation;
                string message;
                int code;
                if (command == "success")
                {
                    operation = Console.ReadLine();
                    message = Console.ReadLine();
                    Console.WriteLine(ShowSuccess(operation, message));
                }
                else if (command == "error")
                {
                    operation = Console.ReadLine();
                    code = int.Parse(Console.ReadLine());
                    Console.WriteLine(ShowError(operation, code));
                }
                else
                {
                    continue;
                }
            }
        }

        static String ShowSuccess(string operation, string message)
        {
            return ("Successfully executed" + operation + ".\n" + "==============================\n" +
             "Message: " + message + ".");
        }

        static String ShowError(string operation, int code)
        {
            return ("Error: Failed to execute " + operation + ".\n" + "==============================\n" +
             "Error Code: " + code + ".\n" + "Reason: " + Reason(code) + ".");

        }

        static string Reason(int code)
        {
            if (code > 0)
            {
                return ("Invalid Client Data");
            }
            else
            {
                return ("Internal System Failure");
            }
        }
    }
}





