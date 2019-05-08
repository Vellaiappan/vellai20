using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise
{
    class SecEQuestion2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("NO\tINVERSE\tSQUAREROOT\tSQUARE");
            double i = 0;
            do
            {
                i = i + 1;
                Console.WriteLine($"{i:#.0##}\t{1/i:0.0##}\t{Math.Sqrt(i):#.0##}\t\t{i*i:#.0##}");
            } while (i != 10);

        }
    }
}
