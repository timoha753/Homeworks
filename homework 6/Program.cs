using System;

namespace homework10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            {
                //int size = 10;
                //int[,] arr = new int[size, size];
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        arr[i, j] = new Random().Next(1, 101);
                //        if (i == 1)
                //        {
                //            Console.Write(arr[i, j] + "  ");
                //        }
                //    }
                //}
            }
            #endregion
            #region Task2
            {
                //int size = 5;
                //int[,] arr1 = new int[size, size];
                //int[,] arr2 = new int[size, size];
                //int sum = 0;
                //int mult = 1;
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        arr1[i, j] = new Random().Next(1,4);
                //        Console.Write(arr1[i,j]+"  ");
                //    }
                //    Console.WriteLine();
                //}
                //Console.WriteLine();
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        arr2[i, j] = new Random().Next(1,4);
                //        Console.Write(arr2[i,j]+"  ");
                //    }
                //    Console.WriteLine();
                //}
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        sum += arr1[i, j];
                //        sum += arr2[i, j];
                //        mult *= arr1[i, j];
                //        mult *= arr2[i, j];
                //    }
                //}
                //Console.WriteLine(sum);
                //Console.WriteLine(mult);
            }
            #endregion
            #region Task3
            {
                //int size = 5;
                //int[,] arr = new int[size, size];
                //int total = 0;
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        arr[i, j] = new Random().Next(1, 151);
                //        Console.Write(arr[i, j] + "  ");
                //        for (int a = 0; a < size; a++)
                //        {
                //            for (int b = 0; b < size; b++)
                //            {
                //                if (arr[i, j] == arr[a, b])
                //                {
                //                    if (i == a & j == b) { }
                //                    else
                //                    {
                //                        total = 1;
                //                    }
                //                }
                //            }
                //        }
                //    }
                //    Console.WriteLine();
                //}
                //if (total == 1)
                //{
                //    Console.WriteLine("В массиве есть повторяющиеся значения");
                //}
                //else
                //{
                //    Console.WriteLine("В массиве нет повторяющихся значений");
                //}
            }
            #endregion
            #region Task4
            {
                //int size = 5;
                //int[,] arr = new int[size, size];
                //int total = 25;
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        arr[i, j] = new Random().Next(1, 151);
                //        Console.Write(arr[i, j] + "  ");
                //    }
                //    Console.WriteLine();
                //}
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        for (int a = 0; a < size; a++)
                //        {
                //            for (int b = 0; b < size; b++)
                //            {
                //                if (arr[i, j] == arr[a, b])
                //                {
                //                    if (i == a & j == b) { }
                //                    else
                //                    {
                //                        total -= 1;
                //                    }
                //                }
                //            }
                //        }
                //    }
                //}
                //Console.WriteLine("\n"+total);               
            }
            #endregion
            #region Task5
            {
                //int size = 5;
                //int[,] arr = new int[size,size];
                //int col = 0;
                //int line = 0;
                //int lich = 0;
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        arr[i, j] = new Random().Next(-5,11);
                //        Console.Write(arr[i,j]+"\t");
                //    }
                //    Console.WriteLine();
                //}
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        if (arr[i, j] >= 0)
                //        {
                //            lich += 1;
                //            if (lich == size)
                //            {
                //                line += 1;
                //            }
                //        }
                //    }
                //    lich = 0;
                //}
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        if (arr[j, i] >= 0)
                //        {
                //            lich += 1;
                //            if (lich == size)
                //            {
                //                col += 1;
                //            }
                //        }
                //    }
                //    lich = 0;
                //}
                //Console.WriteLine($"Количество линий в которых нет отрицательных элементов {line}; количество столбцов в которых нет отрицательных элементов {col}");
            }
            #endregion
            #region Task6
            {
                //int size = 5;
                //int[,] arr = new int[size, size];
                //int colum1 = 0;
                //int colum2 = 0;
                //int colum3 = 0;
                //int colum4 = 0;
                //int colum5 = 0;
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        arr[i, j] = new Random().Next(1,21);
                //    }
                //}
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        switch (i)
                //        {
                //            case 0:
                //                colum1 += arr[i, j];
                //                break;
                //            case 1:
                //                colum2 += arr[i, j];
                //                break;
                //            case 2:
                //                colum3 += arr[i, j];
                //                break;
                //            case 3:
                //                colum4 += arr[i, j];
                //                break;
                //            case 4:
                //                colum5 += arr[i, j];
                //                break;
                //        }
                //    }
                //}

            }
            #endregion
            #region Task7
            {
                //int size = 5;
                //int[,] arr = new int[size, size];
                //int total = 0;
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        arr[i, j] = new Random().Next(1,101);
                //    }
                //}
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        total += arr[i, j];
                //    }
                //}
                //Console.WriteLine(total);
            }
            #endregion
            #region Task8
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
                //    arr[i, i] = 0;
                //}
                //int num = 0;
                //for (int i = size - 1; i >= 0; i--)
                //{
                //    arr[num, i] = 0;
                //    num++;
                //}
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        Console.Write(arr[i,j]+"\t");
                //    }
                //    Console.WriteLine();
                //}
            }
            #endregion
            #region Task9
            {
                //int size = 5;
                //int[,] arr = new int[size, size];
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        arr[i, j] = new Random().Next(-10, 11);
                //        Console.Write(arr[i, j] + "\t");
                //    }
                //    Console.WriteLine();
                //}
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        if (arr[i, j] < 0)
                //        {
                //            Console.WriteLine($"Строка {i + 1}, номер {j + 1}");
                //        }
                //    }
                //}
            }
            #endregion
            #region Task10
            {
                //int size = 5;
                //int[,] arr = new int[size, size];
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        arr[i, j] = new Random().Next(1, 51);
                //        Console.Write(arr[i,j]+"\t");
                //    }
                //    Console.WriteLine();
                //}
                //int max = arr[0,0];
                //int imax = 0;
                //int jmax = 0;
                //int imin = 0;
                //int jmin = 0;
                //int min = arr[0, 0];
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        if (max < arr[i, j])
                //        {
                //            max = arr[i, j];
                //            imax = i;
                //            jmax = j;
                //        }
                //    }
                //}
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        if (min > arr[i, j])
                //        {
                //            min = arr[i, j];
                //            imin = i;
                //            jmin = j;
                //        }
                //    }
                //}
                //int temp = arr[imax, jmax];
                //arr[imax,jmax]=arr[imin,jmin];
                //arr[imin, jmin]=temp;
                //Console.WriteLine("\n"+ arr[imax, jmax]);
                //Console.WriteLine(arr[imin, jmin]+"\n");
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
            #region Task11
            {
                //int size = 5;
                //int[,] arr = new int[size, size];
                //int num = int.Parse(Console.ReadLine());
                //int total = 0;
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        arr[i, j] = new Random().Next(1, 51);
                //        Console.Write(arr[i, j] + "\t");
                //    }
                //    Console.WriteLine();
                //}
                //for (int i = 0; i < size; i++)
                //{
                //    for (int j = 0; j < size; j++)
                //    {
                //        if (num < arr[i, j])
                //        {
                //            total += arr[i, j];
                //        }
                //    }
                //}
                //if (total == 0)
                //{
                //    Console.WriteLine("Чисел меньше того что вы задали нет");
                //}
                //else
                //{
                //    Console.WriteLine(total);
                //}
            }
            #endregion
        }
    }
}

