using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 7;
            double y = 6;

            if (x>5)
            {
                Console.WriteLine(x +" is greater than "+y);
            }
            else
            {
                Console.WriteLine(x + " is less than " + y);
            }


            Console.ReadLine();

        }
    }
}
