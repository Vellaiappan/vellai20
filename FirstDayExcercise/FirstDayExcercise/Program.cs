using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDayExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name:");
            String name = Console.ReadLine();
            Console.Write("Enter your Email Address:");
            String email = Console.ReadLine();
            Console.WriteLine($"{name}");
            Console.WriteLine($"{email}");
        }
    }
}
