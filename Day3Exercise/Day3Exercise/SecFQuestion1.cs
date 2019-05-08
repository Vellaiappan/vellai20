using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise
{
    class SecFQuestion1
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the String:");
            String sent = Console.ReadLine();
            int count = 0, count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0;
            char[] sen = new char[100];
            sen = sent.ToCharArray();
            for (int i = 0; i < sen.Length; i++)
            {
                if (sen[i].Equals('a') || sen[i].Equals('A'))
                    count1++;
                else if (sen[i].Equals('e') || sen[i].Equals('E'))
                    count2++;
                else if (sen[i].Equals('i') || sen[i].Equals('I'))
                    count3++;
                else if (sen[i].Equals('o') || sen[i].Equals('O'))
                    count4++;
                else if (sen[i].Equals('u') || sen[i].Equals('U'))
                    count5++;

             }
            count = count1 + count2 + count3 + count4 + count5;
            Console.WriteLine($"The count of vowel 'a/A' is {count1}");
            Console.WriteLine($"The count of vowel 'e/E' is {count2}");
            Console.WriteLine($"The count of vowel 'i/I' is {count3}");
            Console.WriteLine($"The count of vowel 'o/O' is {count4}");
            Console.WriteLine($"The count of vowel 'u/U' is {count5}");
            Console.WriteLine($"The count of vowels in {sent} is {count}");

        }

    }
}
