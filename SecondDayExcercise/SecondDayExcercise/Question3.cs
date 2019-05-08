using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDayExcercise
{
    class Question3
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter your score:");
            int score = int.Parse(Console.ReadLine());
            if (score >= 80 && score<=100)
            {
                Console.WriteLine($"You scored {score} Marks which is A grade.");
            }
            else if (score>=60 && score<80)
            {
                Console.WriteLine($"You scored {score} Marks which is B grade.");
            }
            else if (score >= 40 && score<60)
            {
                Console.WriteLine($"You scored {score} Marks which is C grade.");
            }
            else if (score>=0 && score<40)
            {
                Console.WriteLine($"You scored {score} Marks which is F grade.");
            }
            else
            {
                Console.WriteLine($"Enter your score between 0-100.");
            }
        
    }
    }
}
