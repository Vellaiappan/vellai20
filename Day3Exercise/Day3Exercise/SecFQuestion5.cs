using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercise
{
    class SecFQuestion5
    {
        static void Main(String[] arg)
        {
            //string[,] arr = new string[6, 2] {
            //   {"Name","Mark" },{"John","63"},{"Venkat","29"},{"Mary","75"},{"Victor","82"},{"Betty","55"}
            //};
            //for(int i=0;i<arr.GetLength(0);i++)
            //{
            //    for(int j=0;j<arr.GetLength(1);j++)
            //    {
            //        Console.Write(arr[i,j]+"\t");
            //    }
            //    Console.WriteLine();
            //}
            //DataTable dt = new DataTable();
            //// Add value to rows and coumns
            //for (int col = 0; col < arr.GetLength(1); col++)
            //{
            //    dt.Columns.Add(arr[0, col]);
            //}
            //for (int rowindex = 1; rowindex < arr.GetLength(0); rowindex++)
            //{
            //    DataRow row = dt.NewRow();
            //    for (int col = 0; col < arr.GetLength(1); col++)
            //    {
            //        row[col] = arr[rowindex, col];
            //    }
            //    dt.Rows.Add(row);
            //}
            ////Display initial array
            //DataView dv = new DataView(dt);
            //dt = dv.ToTable();
            //Console.WriteLine("Initial Array:");
            //Console.WriteLine("Name\tMark");
            //foreach (DataRow row in dt.Rows)
            //{
            //    Console.WriteLine($"{row["Name"].ToString()}\t{row["Mark"].ToString()}");
            //}
            //Console.WriteLine();
            ////display sorted array by name
            //dv.Sort = "Name";
            //dt = dv.ToTable();
            //Console.WriteLine("Sorted Array by Name:");
            //Console.WriteLine("Name\tMark");
            //foreach (DataRow row in dt.Rows)
            //{
            //    Console.WriteLine($"{row["Name"].ToString()}\t{row["Mark"].ToString()}");
            //}
            //Console.WriteLine();
            ////display sorted array by mark
            //dv.Sort = "Mark DESC";
            //dt = dv.ToTable();
            //Console.WriteLine("Sorted Array by Mark:");
            //Console.WriteLine("Name\tMark");
            //foreach (DataRow row in dt.Rows)
            //{
            //    Console.WriteLine($"{row["Name"].ToString()}\t{row["Mark"].ToString()}");
            //}
            //------------------------method 2----------------------------------
            //string temp;
            //string temp1;
            //for(int i=1;i<arr.GetLength(0);i++)
            //{
            //    for(int j=0;j<arr.GetLength(1)-1;j++)
            //    {
            //        for(int k=i+1;k<arr.GetLength(0);++k)
            //        { 
            //        if(arr[i,j].CompareTo(arr[k, j])>0)
            //        {
            //            temp = arr[i, j];
            //            arr[i, j] = arr[k, j];
            //            arr[k, j] = temp;
            //            temp1 = arr[i, j + 1];
            //            arr[i, j + 1] = arr[k, j + 1];
            //                arr[k, j + 1] = temp1;
            //        }
            //        }
            //    }
            //}
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //-----------------------------------end---------------------
            //-----------------------------------method-3-------------------------
            //int column_index = 1;
            //string temp;
            //for (int i = 1; i < arr.GetLength(0); i++)
            //{
            //    int index = i;
            //    for (int j = i - 1; j > 0; j--, index--)
            //        if (arr[j, column_index].CompareTo(arr[index, column_index]) > 0)
            //        {

            //            for (int k = 0; k < arr.GetLength(1); k++)
            //            {
            //                temp = arr[j, k];
            //                arr[j, k] = arr[index, k];
            //                arr[index, k] = temp;
            //            }
            //        }
            //        else
            //            break;
            //}
            //-----------------------End-------------------------------------------
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            string[] arr1 = new string[5] {"John","Venkat","Mary","Victor","Betty"};
            int[] arr2 = new int[5] {63,29,75,82,55 };
            Console.WriteLine("Name\tMark");
            for (int i=0;i<5;i++)
            {
                Console.WriteLine(arr1[i]+"\t"+arr2[i]);
            }
            String temp;
            int temp1;
            for(int i=0;i<5;i++)
            {
                for(int j = i + 1;j<5;j++)
                { 
                    if(arr1[i].CompareTo(arr1[j])>0)
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                        temp1 = arr2[i];
                        arr2[i] = arr2[j];
                        arr2[j] = temp1;
                    }
                }
            }
            Console.WriteLine("Name\tMark");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr1[i] + "\t" + arr2[i]);
            }

        }
    }
}
