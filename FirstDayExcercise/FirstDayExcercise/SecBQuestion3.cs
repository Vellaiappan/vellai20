using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDayExcercise
{
    class SecBQuestion3
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter your salary:");
            double salary = double.Parse(Console.ReadLine());
            double housingAllowance = 0.1 * salary;
            double transportAllowance = 0.03 * salary;
            double total = salary + housingAllowance + transportAllowance;
            String currencyFormat1 = total.ToString("C2");
            Console.WriteLine("Input\tOutput");
            Console.WriteLine($"{salary}\t{currencyFormat1}");
        }
    }
}
