using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class SecHExercise1
    {
        static void Main(String[] arg)
        {
            String message = "Enter an Intger Input:";
            int value=ReadInteger(message);
            Console.WriteLine("The value is :"+value);
        }
        static int ReadInteger(String message)
        {
            String value;
            bool check;
            do
            {
                Console.WriteLine(message);
                value = Console.ReadLine();
                check = int.TryParse(value,out int x);
                if(check)
                {
                    return x;
                }
            } while (check!=true);
            return 0;
        }
    }
}
