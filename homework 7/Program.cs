using System;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            {
                //int size = 5;
                //int[,] arr = new int[size, size];
                //int num = arr[0, 0];
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        arr[i, j] = new Random().Next(1, 101);
                //    }
                //}
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        Console.Write(arr[i, j] + "\t");
                //        if (num < arr[i, j])
                //        {
                //            num = arr[i, j];
                //        }
                //    }
                //    Console.WriteLine();
                //}
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        if (num == arr[i, j])
                //        {
                //            Console.WriteLine($"число {arr[i, j]}; строка {i + 1}; столбец {j + 1}");
                //            num = 0;
                //        }
                //    }
                //}
            }
            #endregion
            #region Task2
            {
                //Console.WriteLine("Enter an odd number");
                //int num = int.Parse(Console.ReadLine());
                //string[,] arr = new string[num, num];
                //for (int i = 0; i < num; i++)
                //{
                //    for (int j = 0; j < num; j++)
                //    {
                //        arr[i, j] = "_";
                //    }
                //}
                //for (int i = 0; i < num; i++)
                //{
                //    arr[i, i] = "*";
                //}
                //for (int i = 0; i < num; i++)
                //{
                //    arr[i, num - i - 1] = "*";
                //}
                //for (int i = 0; i < num; i++)
                //{
                //    arr[i, num / 2] = "*";
                //}
                //for (int i = 0; i < num; i++)
                //{
                //    arr[num / 2, i] = "*";
                //}
                //for (int i = 0; i < num; i++)
                //{
                //    for (int j = 0; j < num; j++)
                //    {
                //        Console.Write(arr[i, j] + " ");
                //    }
                //    Console.WriteLine("");
                //}
            }
            #endregion
            #region Task3
            {
                //int size = 5;
                //int[,] arr = new int[size, size];
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        arr[i, j] = new Random().Next(1, 101);
                //    }
                //}
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        Console.Write(arr[i, j] + "\t");
                //    }
                //    Console.WriteLine();
                //}
                //for (int i = 0; i < size; i++)
                //{
                //    int temp = arr[i, i];
                //    arr[i, i] = arr[size - i - 1, i];
                //    arr[size - i - 1, i] = temp;
                //}
                //Console.WriteLine();
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        Console.Write(arr[i, j] + "\t");
                //    }
                //    Console.WriteLine();
                //}
            }
            #endregion
            #region Task4
            {
                //Console.WriteLine("Enter a number of rows");
                //int n = int.Parse(Console.ReadLine());
                //Console.WriteLine("Enter a number of colums");
                //int m = int.Parse(Console.ReadLine());
                //int[,] arr = new int[n, m];
                //Console.WriteLine();
                //for (int i = 0; i < n; i++)
                //{
                //    for (int j = 0; j < m; j++)
                //    {
                //        arr[i, j] = new Random().Next(1, 101);
                //        Console.Write(arr[i, j] + "\t");
                //    }
                //    Console.WriteLine();
                //}
                //Console.WriteLine();
                //int[,] arr90 = new int[m, n];
                //for (int i = 0; i < m; i++)
                //{
                //    for (int j = 0; j < n; j++)
                //    {
                //        arr90[i, j] = arr[n-j-1,i];
                //        Console.Write(arr90[i,j]+"\t");
                //    }
                //    Console.WriteLine();
                //}
            }
            #endregion
        }
    }
}
