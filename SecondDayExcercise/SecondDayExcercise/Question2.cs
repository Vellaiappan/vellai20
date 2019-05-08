using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDayExcercise
{
    class Question2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your gender(M/F):");
            char gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            if (gender.Equals('M') && age>=40)
            {
                Console.WriteLine($"\tGood Morning Uncle {name}");
            }
            else if (gender.Equals('M') && age< 40 && age>0)
            {
                Console.WriteLine($"\tGood Morning Mr.{name}");
            }
            else if (gender.Equals('F') && age>=40)
            {
                Console.WriteLine($"\tGood Morning Aunty {name}");
            }
            else if (gender.Equals('F') && age < 40 && age > 0)
            {
                Console.WriteLine($"\tGood Morning Ms.{name}");
            }
            else
            {
                Console.WriteLine($"Enter a valid gender(M/F) and age>0.");
            }
        }
    }
}
