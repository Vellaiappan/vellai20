using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class SecHQuestion8
    {
        static void Main(String[] arg)
        {
            Console.WriteLine("Enter the array size :");
            int i = int.Parse(Console.ReadLine());
            int[] arr = new int[i];
            for(int j=0;j<i;j++)
            {
                Console.WriteLine("Enter the value for element " + j);
                arr[j]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the new array size :");
            int value = int.Parse(Console.ReadLine());
            int[] valuearray = ResizeArray(arr, value);
            Console.WriteLine("The array is:" + String.Join(",", valuearray));
        }
        static int[] ResizeArray(int[] arr,int newsize)
        {
            int[] arr1 = new int[newsize];
            //arr.CopyTo(arr1,0);
            for (int i = 0; i < newsize; i++)
            {
                if(i<arr.Length)
                arr1[i] = arr[i];
            }
            return arr1;
        }
    }
}
