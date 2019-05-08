using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exercise
{
    class SecHQuestion6
    {
        static void Main(String[] arg)
        {
            String value = Substitute("C Sharp Programming",'a','o');
            Console.WriteLine($"The new string is {value}");
        }
        static string Substitute(string str,char c1,char c2)
        {
            char[] arr = str.ToCharArray();
            for (int i= 0;i<arr.Length;i++)
            {
                if(arr[i].Equals(c1))
                {
                    arr[i] = c2;
                }
            }
            String newStr = String.Join("", arr);
            return newStr;
        }
    }
}
