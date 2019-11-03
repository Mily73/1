using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i= 1;
            double sum=1,sum2=1,itog=1;
            double x = double.Parse(Console.ReadLine());
            double number = int.Parse(Console.ReadLine());
            for (int counter = 1; counter <= number;counter++)
            {
                sum = (x - Math.Pow(2, i));
                sum2 = (x - (Math.Pow(2, i) - 1));
                i++;
                sum*= sum;
                sum*= sum2;

            }
            Console.WriteLine(itog = sum / sum2);
            Console.ReadKey();
        }
    }
}
