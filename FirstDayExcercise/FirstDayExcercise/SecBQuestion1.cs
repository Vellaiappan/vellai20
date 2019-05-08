using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDayExcercise
{
    class SecBQuestion1
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Number:");
            double number = double.Parse(Console.ReadLine());
            double squareroot = Math.Sqrt(number);
            Console.WriteLine("Input\tOutput");
            Console.WriteLine($"{number}\t{squareroot}");
        }
    }
}
