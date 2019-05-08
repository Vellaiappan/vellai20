using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise
{
    class SecDQuestion2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter two values a and b :");
            int a=int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int a1 = a;
            int b1 = b;
            while(a1!=b1)
            {
                if(a1>b1)
                {
                    a1 = a1 - b1;
                }
                else
                {
                    b1 = b1 - a1;
                }

            }
            int hcf = a1;
            int lcm = (a * b) / hcf;
            Console.WriteLine("A\tB\tHCF\tLCM");
            Console.WriteLine($"{a}\t{b}\t{hcf}\t{lcm}");
        }
    }
}
