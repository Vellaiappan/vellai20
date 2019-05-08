using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise
{
    class SecEQuestion3
    {
        static void Main(String[] args)
        {
            int number;
            Console.WriteLine("Enter the number:");
            number = int.Parse(Console.ReadLine());
            if (number == 0 || number == 1)
            {
                Console.WriteLine(number + " is not prime number");
            }
            else
            {
                for (int a = 2; a <= number / 2; a++)
                {
                    if (number % a == 0)
                    {
                        Console.WriteLine(number + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(number + " is a prime number");
            }
        }
    }
}
