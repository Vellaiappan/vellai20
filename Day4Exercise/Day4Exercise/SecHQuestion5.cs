using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class SecHQuestion5
    {
        static void Main(String[] arg)
        {
            for(int i=0;i<=100;i++)
            { 
            String decToHex = DecimalToHexa(i);
            Console.WriteLine("The hexa decimal value for "+i+" is "+ decToHex);
            //Console.WriteLine("The hexa decimal value for " + i + " is " + i.ToString("X"));
            }
        }
        static String DecimalToHexa(int num)
        {
            String[] hexa = new string[16] {"0","1","2","3","4","5","6","7","8","9", "A", "B", "C", "D", "E", "F" };
            int Remainder;
            String decToHex = "";
            do
            {
                Remainder = num % 16;
                num = num / 16;
                decToHex =hexa[Remainder]+decToHex;
            } while (num != 0);
            return decToHex;
        }
    }
}
