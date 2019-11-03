using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            double counter = 0;
            double sum = 0;
            double itog ;
           for(int i=0;i<=3;i++)
            {
                counter++;
                sum = sum + i;

            }
            Console.WriteLine(sum);
            Console.WriteLine(counter);
            Console.WriteLine(itog = sum / counter);
            Console.ReadKey();
        }
    }
}
