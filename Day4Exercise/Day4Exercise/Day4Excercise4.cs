using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class Day4Excercise4
    {
        static void Main(String[] arg)
        {
            int[] arr = new int[10];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine($"Enter the value for element {i+1}:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("[");
            Console.Write(string.Join(",", arr));
            Console.Write("]");
            

        }
    }
}
