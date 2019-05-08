using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDayExcercise
{
    class SecBQuestion2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Number:");
            double number = double.Parse(Console.ReadLine());
            double squareroot = Math.Sqrt(number);
            Console.WriteLine(squareroot);
            Console.WriteLine(Math.Truncate(squareroot));
            Console.WriteLine($"For Full Hash {squareroot :#.###}");
            Console.WriteLine($"For Whole Hash {squareroot:#.000}");
            Console.WriteLine($"For Full Zero {squareroot:0.000}");
            String sqrt = squareroot.ToString("N3");
            Console.WriteLine("Input\tOutput");
            Console.WriteLine($"{number}\t{sqrt}");

            Console.WriteLine($"squareroot:{ squareroot.ToString("C3")}");
        }
    }
}
