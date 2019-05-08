using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDayExcercise
{
    class SecBQuestion7
    {
        static void Main(String[] arg)
        {
            Console.WriteLine("Please Enter the distance travelled");
            double distance = double.Parse(Console.ReadLine());
            double fare = 2.40 + (distance*0.4);
            Console.WriteLine($"The Fare is ${fare}");
            
        }
    }
}
