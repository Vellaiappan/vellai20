using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day3Exercise
{
    class SecFQuestion3
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the String:");
            String sent = Console.ReadLine();
            String sent1 = sent;
            string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "-", "_", "(", ")", ":", "|", "[", "]"," " };
            for (int i = 0; i < chars.Length; i++)
            {
                if (sent.Contains(chars[i]))
                {
                    sent = sent.Replace(chars[i], "");
                }
            }
            Console.WriteLine(sent);
            char[] sen = new char[100];
            sen = sent.ToCharArray();
            string sent2 = "";
            for (int i = sen.Length - 1; i >= 0; i--)
            {
                
                    sent2 = sent2 + sen[i];
                
            }
            if (sent2.ToLower() == sent.ToLower())
            {
                Console.WriteLine($"{sent1} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{sent1} is not a palindrome");
            }
        }
    }
}
