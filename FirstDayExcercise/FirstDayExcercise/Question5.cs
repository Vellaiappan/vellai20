using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDayExcercise
{
    class Question5
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Number:");
            double number = double.Parse(Console.ReadLine());
            String decimalPlaces = number.ToString("N3");
            Console.WriteLine("Input\tOutput");
            Console.WriteLine($"{number}\t{decimalPlaces}");
            Console.WriteLine(Math.Round(number,3));
        }
    }
}
