using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class SecHQuestion9
    {
        static void Main(String[] arg)
        {
            for(int i=0;i<=1000;i++)
            {
                bool valid = isPrime(i);
                if (valid)
                    Console.WriteLine(i + " is a prime number");
            }
        }
        static bool isPrime(int num)
        {
            if (num == 0 || num == 1)
                return false;

            for(int i=2;i<=num/2;i++)
            {
                if(num%i==0)
                {
                    return false;
                }
            }
            return true; 
        }
    }
}
