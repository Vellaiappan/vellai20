using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDayExcercise
{
    class SecBQuestion9
    {
        static void Main(String[] arg)
        {
            Console.WriteLine("Please Enter the distance travelled in KM");
            double distance = double.Parse(Console.ReadLine());
            double fare =Math.Ceiling((2.40 + (distance * 0.4))*10)/10;
            Console.WriteLine($"The Fare is ${fare}");

        }
    }
}
