using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = new string[12] {"January","Febuary","March","April","May","June","July","August","September","October","November","December"};
            int[] sales = new int[12] { 20, 40, 30, 10, 15, 35, 25, 60, 50, 45, 65, 55 };
            Console.WriteLine("The maximun sales month is "+months[Array.IndexOf(sales,sales.Max())]);
            Console.WriteLine("The minimum sales month is "+months[Array.IndexOf(sales, sales.Min())]);

            var nearest = sales.OrderBy(x => Math.Abs((long)x - sales.Average())).First();
            Console.WriteLine("Nearest value in Array "+nearest+" "+"The actual average value is "+sales.Average());
            Console.WriteLine("The average sales month is" + months[Array.IndexOf(sales, nearest)]);

            
        }
    }
}
