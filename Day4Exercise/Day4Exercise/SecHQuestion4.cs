using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class SecHQuestion4
    {
        static void Main(String[] arg)
        {
            Console.WriteLine("Enter Two strings:");
            String str1 = Console.ReadLine();
            String str2 = Console.ReadLine();
            int check = FindWord(str1, str2);
            Console.WriteLine(check);
        }
        static int FindWord(String s1, String s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            if (s1.Contains(s2))
                return s1.IndexOf(s2[0]);
            else
                return -1;

        }
    }
}
