using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.WriteLine("Enter the number");
                number = int.Parse(Console.ReadLine());
                if(number==88)
                {
                    Console.WriteLine("\t\"Lucky you...\"");
                }
                else
                {
                    Console.WriteLine("Try Again");
                }
            } while (number != 88);
        }
    }
}
