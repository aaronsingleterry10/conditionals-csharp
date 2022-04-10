using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            Console.WriteLine("Aaron Test");
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's Morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's Afternoon.");
            }
            else
            {
                Console.WriteLine("It's Evening");
            }
        }
    }
}
