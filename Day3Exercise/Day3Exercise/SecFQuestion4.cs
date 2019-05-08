using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise
{
    class SecFQuestion4
    {
        static void Main(String[] Args)
        {
            Console.WriteLine("Enter the String:");
            String sent = Console.ReadLine();
            char[] sen = new char[100];
            sen = sent.ToCharArray();
            if (!char.IsUpper(sen[0]))
            {
                sen[0] = char.ToUpper(sen[0]);
            }
            for (int i = 0; i < sen.Length; i++)
            {
                if (sen[i].Equals(' '))
                {
                    sen[i + 1] = char.ToUpper(sen[i + 1]);
                }
            }
            String str = "";
            for (int i = 0; i < sen.Length; i++)
            {
                str = str + sen[i];
            }
            Console.WriteLine($"Title Case:{str}");
        }
    }
}
