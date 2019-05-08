using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise
{
    class SecEQuestion1
    {
        static void Main(String[] args)
        {
            input:
            Console.WriteLine("Enter the Method to use:");
            Console.WriteLine("1.Increment Counter \n2.Decrement Counter");
            int method = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());
            int fact = 1;
            if(method==1)
            {
                for(int i=1;i<=number;i++)
                {
                    fact = fact * i;
                }
            }
            else if(method==2)
            {
                for (int i =  number; i >= 1; i--)
                {
                    fact = fact * i;
                }
            }
            else
            {
                Console.WriteLine("Enter a valid Method");
                goto input;
            }
            Console.WriteLine($"The factorial of {number} is {fact}");

        }
    }
}
