using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise
{
    class SecEQuestion4
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());
            int perfectnumber = 0;
            for(int i=1;i<number;i++)
            {
                if(number%i==0)
                {
                    perfectnumber = perfectnumber + i;  
                }
            }
            if(perfectnumber==number)
            {
                Console.WriteLine($"{number} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{number} is not a perfect number");
            }
        }
    }
}
