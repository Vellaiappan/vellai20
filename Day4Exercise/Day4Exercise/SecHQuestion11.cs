using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate double DoubleOps(double x);
namespace Day4Exercise
{
    class SecHQuestion11
    {
        public static double squareRoot(double x)
        {
            return Math.Sqrt(x);
        }
        public static double square(double x)
        {
            return (x*x);
        }
        static double[] ProcessArray(double[] arr,DoubleOps ops)
        {
            double[] newArr = new double[arr.Length];
            for(int i=0;i<arr.Length;i++)
            {
                newArr[i] = ops(arr[i]);
            }
            return newArr;
        }
        static void Main()
        {
            double[] arr = new double[10] {4,9,16,25,36,2,3,4,5,6 };
            DoubleOps ops=new DoubleOps(squareRoot);
            DoubleOps ops1 = new DoubleOps(square);
            double[] arr1 = ProcessArray(arr, ops);
            double[] arr2 = ProcessArray(arr, ops1);
            Console.WriteLine($"The Initial array is {String.Join(",",arr)}");
            Console.WriteLine($"The SQRT array is {String.Join(",", arr1)}");
            Console.WriteLine($"The SQ array is {String.Join(",", arr2)}");
        }
         
    }
}
