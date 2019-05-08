using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise
{
    class SecDQuestion4
    {
        static void Main()
        {

            Console.WriteLine("Enter the Number:");
            int number=int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int guess = rnd.Next(0,number);
            double g=guess;
            //do
            //{
            //    if (Math.Abs((g * g)-number)<0.000001)
            //    {
            //        Console.WriteLine($"The square root of {number} is {g:#,0.000}");
            //        break;
            //    }
            //    else
            //    {
            //        g = (g + (number / g)) / 2;
            //    }

            //} while (g*g != number);

            while (g * g != number)
            {
                g = (g + (number / g)) / 2;
                if (Math.Abs((g * g) - number) < 0.000001)
                {

                    break;
                }
            }
            Console.WriteLine($"The square root of {number} is {g:#,0.000}");

        }
    }
}
