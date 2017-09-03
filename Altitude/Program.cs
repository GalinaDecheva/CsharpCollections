using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            bool isCrashed = false;
            int altitude = int.Parse(arr[0]);
            for (int i = 1; i < arr.Length; i+=2)
            {
                if (altitude <= 0)
                {
                    isCrashed = true;
                    break;
                }
                int change = int.Parse(arr[i + 1]);
                if(arr[i] == "up")
                {
                    altitude += change;
                } else
                {
                    altitude -= change;
                }
                if (altitude <= 0)
                {
                    isCrashed = true;
                    break;
                }


            }
            if(isCrashed)
            {
                Console.WriteLine("crashed");
            } else
            {
                Console.WriteLine("got through safely. current altitude: {0}m", altitude);
            }
          
        }
    }
}
