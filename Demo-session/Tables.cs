using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_session
{
    class Tables
    {
        public static void table()
        {
            Console.WriteLine("Enter a number");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(input * i);
            }
        }
    }
}
