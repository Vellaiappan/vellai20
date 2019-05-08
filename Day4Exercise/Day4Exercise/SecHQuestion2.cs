using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class SecHQuestion2
    {
        static void Main(String[] arg)
        {
            int[] arr = new int[10] {1,2,3,4,5,6,7,8,9,10 };
            PrintArray(arr);
        }
        static void PrintArray(int[] arr)
        {
            Console.Write("{");
            Console.Write(String.Join(",", arr));
            Console.WriteLine("}");
        }

    }
}
