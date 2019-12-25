using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            {
                int a = 0;
                for (int i = 0; i < 50; i++)
                {
                    if (i % 2 != 0)
                    {
                        a += i;
                    }
                }
                Console.WriteLine(a);
            }
            #endregion
            Console.WriteLine();
            #region Task2
            {
                int a = new Random().Next(1, 100);
                int b = new Random().Next(100, 200);
                Console.WriteLine(a + "  " + b);
                int num = 0;
                for (int i = a; i < b; i++)
                {
                    if (i % 4 == 0)
                    {
                        num += i;
                    }
                }
                Console.WriteLine(num);
            }
            #endregion
            Console.WriteLine();
            #region Task3a
            {
                for (int i = 10; i < 100; i++)
                {
                    double a = Math.Pow(i / 10, 2);
                    double b = Math.Pow(i % 10, 2);
                    double c = a + b;
                    if ((a+b)%13==0)
                    {

                        Console.Write(i+"->"+c+"  ");
                    }

                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();
            #region Task3b
            {
                for (int i = 10; i < 100; i++)
                {
                    int a = i / 10;
                    int b = i % 10;
                    double c = Math.Pow((a+b), 2);
                    if ((a + b + c) == i)
                    {
                        Console.Write(i+" ");
                    }
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine();
            #region Task4
            //не понял
            #endregion
            #region Task5
            {
                int a = new Random().Next(1, 5);
                int b = new Random().Next(5, 11);
                int c = 0;
                long d = 1;
                for (int i = a; i <= b; i++)
                {
                    c += i;
                    d *= i;
                }
                Console.WriteLine(a+" "+b);
                Console.WriteLine(c+" "+d);
            }
            #endregion
            Console.WriteLine();
            #region Task6
            {
                int a = new Random().Next(1, 20);
                int b = new Random().Next(20, 40);
                Console.WriteLine(a + " " + b);
                for (int i = a; i <= b; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.WriteLine("N=" + (b-a+1));
            }
            #endregion
            Console.WriteLine();
            #region Task7
            {
                int a = new Random().Next(40,101);
                Console.WriteLine(a+" грн за один кг конфет");
                for (double i = 1; i < 2; i += 0.2)
                {
                    double d = a * i;
                    Console.WriteLine(d+" за "+i+" кг конфет");
                }
            }
            #endregion
            Console.WriteLine();
            #region Task8
            {
                int a = new Random().Next(1, 3);
                int b = new Random().Next(3, 6);
                Console.WriteLine(a+" "+b);
                for (int i = a; i <= b; i++)
                {
                    for (int j = i; j != (2*i); j++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
            }
            #endregion
        }
    }
}
