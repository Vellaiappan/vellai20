using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDayExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your gender(M/F):");
            char gender = char.Parse(Console.ReadLine());
            if(gender.Equals('M'))
            {
                Console.WriteLine($"\tGood Morning Mr.{name}");
                Console.WriteLine($"where you entered {name} for name and {gender} for gender.");
            }
            else if(gender.Equals('F'))
            {
                Console.WriteLine($"\tGood Morning Ms/Mrs.{name}");
                Console.WriteLine($"where you entered {name} for name and {gender} for gender.");
            }
            else
            {
                Console.WriteLine($"Enter a valid gender(M/F).");
            }
        }
    }
}
