using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class Day4Exercise7
    {
        static void Main()
        {
            String[] name = new String[4] { "Dennis", "Bob", "Alice", "Charlie" };
            int[] score = new int[4] { 80, 90, 100, 120 };
            Console.WriteLine("Name\tScore");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{name[i]}\t{score[i]}");
            }
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = i + 1; j < name.Length; j++)
                {
                    if (name[i].CompareTo(name[j])>0)
                    {
                        String temp = name[i];
                        name[i] = name[j];
                        name[j] = temp;
                        int temp1 = score[i];
                        score[i] = score[j];
                        score[j] = temp1;
                    }
                }
            }
            Console.WriteLine("Sorted array:");
            Console.WriteLine("Name\tScore");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{name[i]}\t{score[i]}");
            }
        }
    }
}
