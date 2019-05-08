using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDayExcercise
{
    class SecBQuestion5
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter value for X:");
            int X = int.Parse(Console.ReadLine());
            int Y =  (5 * X * X) - (4 * X) + 3;
            Console.WriteLine("Input\tOutput");
            Console.WriteLine($"{X}\t{Y}");

        }
    }
}
