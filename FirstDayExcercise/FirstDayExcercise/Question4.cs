using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDayExcercise
{
    class Question4
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Number:");
            double number = double.Parse(Console.ReadLine());
            double square = number * number;
            Console.WriteLine($"The Square of {number} is {square}");
        }
    }
}
