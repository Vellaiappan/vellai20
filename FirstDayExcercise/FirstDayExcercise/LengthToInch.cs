using System;

namespace FirstDayExcercise
{
    class LengthToInch
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Length in 'CM'");
            int length =int.Parse( Console.ReadLine());
            double inch = length / 2.54;
            Console.WriteLine($"The inch for the length {length}CM is {inch:0.000}inches");
 
       }


    }
}