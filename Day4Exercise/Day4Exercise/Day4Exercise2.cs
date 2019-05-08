using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class Day4Exercise2
    {
        static void Main(string[] arg)
        {
            int[] arr = { 10, 7, 3, 1, 9, 7, 4, 3 };
            Console.Write("Initial Array : ");
            Console.WriteLine(String.Join(" ", arr));
            selectionSort(arr);
        }
        //Sorting in decending order
        public static void selectionSort(int[] arr)
        {
            int N = arr.Length;
            //int index = 0;
            //int small,pos=index;
            //while (index != N - 1)
            //{
            //    small = arr[index];
            //    for (int i = index + 1; i < N; i++)
            //    {
            //        if (small > arr[i])
            //        {
            //            small = arr[i];
            //            pos = i;
            //        }
            //    }
            //    int temp = arr[pos];
            //    arr[pos] = arr[index];
            //    arr[index] = temp;
            //    Console.Write("After pass " + index + "  : ");
            //    Console.WriteLine(String.Join(" ", arr));
            //    index++;
            //}


            for (int i = 0; i < N; i++)
            {
                int large = arr[i];
                int pos = i;

                for (int j = i + 1; j < N; j++)
                {
                    if (arr[j] < large)
                    {
                        large = arr[j];
                        pos = j;
                    }
                }

                int temp = arr[pos];
                arr[pos] = arr[i];
                arr[i] = temp;
                Console.Write("After pass " + i + "  : ");
                //Printing array after pass
                Console.WriteLine(String.Join(" ", arr));
            }

        }
    }
}
