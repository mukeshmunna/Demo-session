using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_session
{
    internal class Swap
    {
        public static void num()
        {
            Console.WriteLine("Enter a value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b value");
            int b = Convert.ToInt32(Console.ReadLine()); 
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a + " " + b);




        }
    }
}
