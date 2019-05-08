using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class SecHQuestion3
    {
        static void Main(String[] arg)
        {
            Console.WriteLine("Enter Two strings:");
            String str1 = Console.ReadLine();
            String str2 = Console.ReadLine();
            bool check=InString(str1,str2);
            Console.WriteLine(check);
        }
        static bool InString(String s1,String s2)
        {
            string str;
            //s1 = s1.ToLower();
            //s2 = s2.ToLower();
            //if (s1.Contains(s2))
            //    return true;
            //else
            //    return false;
            for(int i=0;i<s1.Length;i++)
            {
                str = "";
                if (s1[i]==s2[0])
                {
                    str = str + s1.Substring(i,s2.Length);
                    if (str == s2)
                        return true;
                }
            }
            return false;
        }
    }
}
