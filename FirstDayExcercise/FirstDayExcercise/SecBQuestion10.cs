using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDayExcercise
{
    class SecBQuestion10
    {
        static void Main(String[] args) { 
        Console.WriteLine("Enter value for a,b and c");
         int a=int.Parse(Console.ReadLine());
         int b=int.Parse(Console.ReadLine());
         int c=int.Parse(Console.ReadLine());
            double s = (a + b + c) / 2;
            double distance = s * (s - a) * (s - b) * (s - c);
            if(distance<0)
            {
                Console.WriteLine("Value cannot be calculated for these values ");
            }
            else
            {
                double sqrt = Math.Sqrt(distance);
                Console.WriteLine($"The Distance is {sqrt}");
            }
        }
     }
}
