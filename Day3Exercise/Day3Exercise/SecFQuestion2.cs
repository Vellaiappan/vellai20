using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise
{
    class SecFQuestion2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the String:");
            String sent = Console.ReadLine();
            char[] sen = new char[100];
            sen = sent.ToCharArray();
            string sent2 = "";
            for(int i=sen.Length-1;i>=0;i--)
            {
                sent2 = sent2 + sen[i];
            }
            Console.WriteLine(String.Join("",sen));
            if(sent2==sent)
            {
                Console.WriteLine($"{sent} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{sent} is not a palindrome");
            }
        }
    }
}
