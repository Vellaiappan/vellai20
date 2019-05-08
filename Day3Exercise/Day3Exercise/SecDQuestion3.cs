using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise
{
    class SecDQuestion3
    {
        static void Main(String[] args)
        {
            Random rnd = new Random();
            int secret = rnd.Next(10);
            int number;
            int i = 0;
            do
            {
                Console.WriteLine("Enter the number:");
                number = int.Parse(Console.ReadLine());
                i = i + 1;
                if (number == secret)
                {
                    if (i<= 2)
                        Console.WriteLine("You are a Wizard");
                    else if (i <= 5)
                        Console.WriteLine("You are a good guess");
                    else
                        Console.WriteLine("You are lousy!");
                    Console.WriteLine($"Congrats you find the number in {i} attempts.");
                }
                else
                {
                    Console.WriteLine("Try Again");
                }
            } while (number != secret);
        }
    }
}
