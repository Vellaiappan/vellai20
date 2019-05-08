using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise
{
    class SecEQuestion6
    {
        static void Main(String[] args)
        {
            
            for(int number=1;number<=1000;number++)
            { 
              int perfectnumber = 0;
              for (int i = 1; i < number; i++)
                {
                  if (number % i == 0)
                  {
                    perfectnumber = perfectnumber + i;
                  }
                }
               if (perfectnumber == number)
               {
                Console.WriteLine($"{number} is a perfect number");
               }
            }
        }
    }
}
