using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая
{
    class Program
    {
        static void Main(string[] args)
        {double number_x = double.Parse(Console.ReadLine());
            const double e = 2.71;
            if (number_x == 2)
            {
                Console.WriteLine(((Math.Cos(3 * number_x) + Math.Pow(number_x, 3)) / (Math.Pow(Math.Sin(number_x), 3) - 3 * number_x)));
            }
            else if (number_x > 2)
            {
                Console.WriteLine(Math.Pow(Math.Sin(number_x), 2) + Math.Sqrt(Math.Pow(number_x, 2) + 2));
            }
            else if (number_x < 2)
            {
                Console.WriteLine(Math.Pow(number_x, 3) * (Math.Log(Math.Abs(Math.Atan(number_x) - Math.Pow(e, -number_x)))));
            }
            Console.ReadKey();
        }
    }
}
