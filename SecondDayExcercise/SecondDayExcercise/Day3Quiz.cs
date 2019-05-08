using System;

namespace SecondDayExcercise
{
    class Day3Quiz
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to ISS gadget shop");
            Console.WriteLine("Number of items to purchase:");
            int quantity = int.Parse(Console.ReadLine());
            double total = quantity * 500;
            double discountedtotal = 0;
            if (total > 2000 && total <= 3000)
            {
                discountedtotal =total- (total * 0.03);
            }
            else if (total > 3000 && total <= 6000)
            {
                discountedtotal =total- (total * 0.05);
            }
            else if (total > 6000)
            {
                discountedtotal = total-(total * 0.08);
            }
            else if (total >= 0 && total <= 2000)
            {
                discountedtotal = total;
            }
            else
            {
                Console.WriteLine("Enter a valid quantity which is 0 or more");
            }
            if(quantity>=0)
            Console.WriteLine($"Please pay {discountedtotal:#,0.00}");
        }
    }
}