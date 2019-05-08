using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise
{
    class SecFQuestion6
    {
        static void Main(String[] arg)
        {
            int digit1, digit2, digit3, digit4, digit5,Remainder;
            char checksum;
            char[] check = new char[5] {'O','P','Q','R','S'};
            Console.WriteLine("Enter your Matriculation ID(A00000X):");
            String Id= Console.ReadLine();
            if(Id.Length!=7)
            {
                Console.WriteLine("Marticulation ID is Invalid");
                return;
            }
            else
            {
                Id = Id.ToUpper();
                digit1 =(int) Id[1] * 6;
                digit2 = (int)Id[2] * 5;
                digit3 = (int)Id[3] * 4;
                digit4 = (int)Id[4] * 3;
                digit5 = (int)Id[5] * 2;
                Remainder = (digit1 + digit2 + digit3 + digit4 + digit5) % 5;
                checksum = check[Remainder];
                if(Id[6]==checksum)
                {
                    Console.WriteLine("Marticulation ID is Valid");
                }
                else
                {
                    Console.WriteLine("Marticulation ID is Invalid");
                }
            }
        }
    }
}
