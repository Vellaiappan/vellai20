using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise
{
    class SecEQuestion5
    {
        static void Main(String[] args)
        {
            for(int number=5;number<=10000;number++)
            {
                Boolean flag = true;
                for (int a = 2; a <= number / 2; a++)
                {
                    if (number % a == 0)
                    {
                        flag = false;
                        break;
                    }

                }
                if(flag)
                   Console.WriteLine(number + " is a prime number");
            }
        }
    }
}
