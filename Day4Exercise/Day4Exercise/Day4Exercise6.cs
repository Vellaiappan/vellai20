using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class Day4Exercise6
    {
        static void Main(String[] arg)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter the value for element {i + 1}:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sorted Array :");
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine(String.Join(",", arr));
        }
    }
}
