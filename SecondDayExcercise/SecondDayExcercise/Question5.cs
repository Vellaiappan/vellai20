using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDayExcercise
{
    class Question5
    {
        static void Main(String[] arg)
        {
            Console.WriteLine("Enter the Number:");
            int num = int.Parse(Console.ReadLine());
            int num1 = num,rem;
            double total = 0;
            while (num1%10!=0)
            {
                rem = num1 % 10;
                total = total + Math.Pow(rem, num.ToString().Length);
                num1 = num1 / 10;
            }
            //double length = num.ToString().Length;
            //int[] digits = new int[(int)length];
            //for(int i=0;i<length;i++)
            //{
            //    digits[i] = num1 % 10;
            //    num1 = num1 / 10;
            //}
            //double power = 0;
            //for(int i=0;i<length;i++)
            //{
            //    power += Math.Pow(digits[i],length);
            //}
            if(total==num)
            {
                Console.WriteLine($"The number {num} is an armstrong number.");
            }
            else
            {
                Console.WriteLine($"The number {num} is not an armstrong number.");
            }

        }
    }
}
