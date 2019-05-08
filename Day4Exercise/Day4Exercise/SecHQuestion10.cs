using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class SecHQuestion10
    {
        static void Main(String[] arg)
        {
            Console.WriteLine(" Enter number of rows and columns for matrix 1:");
            int r1 = int.Parse(Console.ReadLine());
            int c1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter number of rows and columns for matrix 2:");
            int r2 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());
            int[,] m1 = new int[r1, c1];
            int[,] m2 = new int[r2, c2];
            int[,] m3 = new int[r1, c2];
            Console.WriteLine(" Enter the values for matrix 1:");
            for(int i=0;i<r1;i++)
            {
                for(int j=0;j<c1;j++)
                {
                    Console.WriteLine($"Enter values for Element [{i},{j}]:");
                    m1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(" Enter the values for matrix 2:");
            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.WriteLine($"Enter values for Element [{i},{j}]:");
                    m2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix 1:");
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    Console.Write($"{m1[i,j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix 2:");
            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write($"{m2[i, j]}\t");
                }
                Console.WriteLine();
            }
            m3= MatrixMul(m1,m2);
            Console.WriteLine("Matrix 3:");
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write($"{m3[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        static int[,] MatrixMul(int[,] m1,int[,] m2)
        {
            int[,] newArr = new int[m1.GetLength(0),m2.GetLength(1)];
            for(int i=0;i< m1.GetLength(0);i++)
            {
                for(int j=0;j<m2.GetLength(1);j++)
                {
                    newArr[i, j] = 0;
                    for(int k=0;k<m1.GetLength(1);k++)
                    {
                        newArr[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }
            return newArr;
        }
    }
}
