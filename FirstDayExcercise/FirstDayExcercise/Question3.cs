using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDayExcercise
{
    class Question3
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Number:");
            int number = int.Parse(Console.ReadLine());
            int square = number * number;
            Console.WriteLine($"The Square of {number} is {square}");
        }
    }
}
