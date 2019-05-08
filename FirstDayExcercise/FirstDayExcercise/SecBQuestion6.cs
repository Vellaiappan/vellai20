using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDayExcercise
{
    class SecBQuestion6
    {
        static void Main(String[] args)
        {
            int[] x = new int[3];
            int[] y = new int[3];
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Enter value for X" + i);
                x[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter value for Y" + i);
                y[i] = int.Parse(Console.ReadLine());
            }
            double Distance = Math.Sqrt(((x[2]-x[1])*(x[2]-x[1]))+((y[2]-y[1])*(y[2]-y[1])));
            Console.WriteLine("X1\tY1\tX2\tY2\tOutput");
            Console.WriteLine($"{x[1]}\t{y[1]}\t{x[2]}\t{y[2]}\t{Distance}");
        }
    }
}
