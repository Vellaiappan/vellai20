using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDayExcercise
{
    class SecBQuestion4
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Degree in Centigrade:");
            int centigrade = int.Parse(Console.ReadLine());
            double fahrenreit = (1.8*centigrade)+32;
            int fahren = (int)fahrenreit;
            Console.WriteLine("Input\tOutput");
            Console.WriteLine($"{centigrade}\t{fahren}\t{fahrenreit}");
        }
    }
}
