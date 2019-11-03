using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 0; i==number;i++)
            {
                factorial = factorial * i;

            }
            Console.WriteLine(factorial);
        }       
        
