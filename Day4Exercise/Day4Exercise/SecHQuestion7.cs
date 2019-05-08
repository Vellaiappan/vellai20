using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class SecHQuestion7
    {
        static void Main(String[] arg)
        {
            Console.WriteLine("Enter the array size and value to store all elements in array");
            int i=int.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());
            int[] arr = new int[i];
            int[] valuearray = SetArray(arr, value);
            Console.WriteLine("The array is:"+String.Join(",", valuearray));
        }
        static int[] SetArray(int[] arr,int value)
        {
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = value;
            }
            return arr;
        }
    }
}
