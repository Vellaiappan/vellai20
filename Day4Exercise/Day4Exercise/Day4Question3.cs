using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class Day4Question3
    {
        static void Main(String[] arg)
        {
            int[,] Class = new int[12, 4]{
            {56,84,68,29},{94,73,31,96},{41,63,36,90},{99,9,18,17},{62,3,65,75},{40,96,53,23},{81,15,27,30},{21,70,100,22},{88,50,13,12},{48,54,52,78},{64,71,67,25},{16,93,46,72}
            };
            int total;
            double varience,stdvar;
            double avg;
            Console.WriteLine("Sub1\tSub2\tSub3\tSub4\tTotal\tAvg\tStdDeviation");
            for(int i=0;i<Class.GetLength(0);i++)
            {
                total = 0;
                varience = 0;
                for (int j=0;j<Class.GetLength(1);j++)
                { 
                    total = total + Class[i, j];
                    Console.Write($"{Class[i,j]}\t");
                }
                avg = (double)total / Class.GetLength(1);
                for(int k=0;k<Class.GetLength(1);k++)
                {
                    varience =varience+Math.Pow((Class[i,k]-avg),2);
                }
                varience = varience / Class.GetLength(1);
                stdvar = Math.Sqrt(varience);
                Console.WriteLine($"{total}\t{avg}\t{stdvar:#.#####}");
                Console.WriteLine();
            }
            Console.WriteLine("Average Per Subject:");
            for(int j=0;j<Class.GetLength(1);j++)
            {
                total = 0;
                for(int i=0;i<Class.GetLength(0);i++)
                {
                    total = total + Class[i, j];
                }
                avg =(double) total / Class.GetLength(0);
                Console.Write($"{avg:#.#####}\t");
            }
        }
    }
}
