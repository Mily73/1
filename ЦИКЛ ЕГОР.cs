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
            int counter = 1;
            int sum = 0;
            double itog = 1;
           for(int i=-25;i<=154;i++)
            {
                counter = counter + 1;
                sum = sum + i;

            }
              itog = sum / counter;
            Console.WriteLine(itog);
            Console.ReadKey();
        }
    }
}
