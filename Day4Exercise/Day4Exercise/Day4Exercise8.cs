using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class Day4Exercise8
    {
        static void Main(String[] arg)
        {
            int[,] arr = new int[4,4];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter the value for element [{i},{j}] :");
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter the value to find its index in array:");
            int value = int.Parse(Console.ReadLine());
            Boolean flag = false;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] == value)
                    {
                        Console.WriteLine($"The index of value {value} is [{i},{j}]. ");
                        flag = true;
                        break;
                    }
                }
            }
            if (!flag)
            {
                Console.WriteLine($"The index of value {value} is -1. ");
            }
        }
    }
}
