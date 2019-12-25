using System;

namespace Homeork_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.
            //int a = new Random().Next(-10,11);
            //Console.WriteLine(a);
            //if (a>0)
            //{
            //    a++;
            //}
            //else if (a<0)
            //{
            //    a -= 2;
            //}
            //else
            //{
            //    a = 10;
            //}
            //Console.WriteLine(a);
            //Console.WriteLine();


            //2.
            //int a = new Random().Next(-10, 11);
            //int b = new Random().Next(-10, 11);
            //int c = new Random().Next(-10, 11);
            //int d = 0;
            //if (a>0)
            //{
            //    d++;
            //}
            //else{}
            //if (b>0)
            //{
            //    d++;
            //}
            //else{}
            //if (c>0)
            //{
            //    d++;
            //}
            //else{}
            //Console.WriteLine($"Three numbers {a}, {b}, {c}");
            //Console.WriteLine(d);


            //3.
            //int a = new Random().Next(-10, 11);
            //int b = new Random().Next(-10, 11);
            //int c = new Random().Next(-10, 11);
            //int d = 0;
            //int t = 0;
            //switch (a>0)
            //{
            //    case true:
            //        d++;
            //        break;
            //    case false:
            //        t++;
            //        break;
            //}
            //switch (b>0)
            //{
            //    case true:
            //        d++;
            //        break;
            //    case false:
            //        t++;
            //        break;
            //    default:
            //        break;
            //}
            //switch (c>0)
            //{
            //    case true:
            //        d++;
            //        break;
            //    case false:
            //        t++;
            //        break;
            //    default:
            //        break;
            //}
            //Console.WriteLine($"Three numbers {a}, {b}, {c}");
            //Console.WriteLine($"Amount of even {d}, odd {t} numbers");


            //4.
            //int a = new Random().Next(-10,11);
            //int b = new Random().Next(-10,11);
            //Console.WriteLine(a+" number, "+b+" number");
            //if (a!=b)
            //{
            //    a = a + b;
            //    b = a;
            //}
            //else
            //{
            //    a = 0;
            //    b = 0;
            //}
            //Console.WriteLine(a + " number, " + b + " number");


            //5.
            //int a = new Random().Next(-10,11);
            //Console.WriteLine(a);
            //if ((a%2)==0)
            //{
            //    Console.WriteLine("This number is even");
            //}
            //else
            //{
            //    Console.WriteLine("This number is odd");
            //}


            //6.
            //int a = new Random().Next(1, 6);
            //double b = new Random().Next(-100, 101);
            //Console.WriteLine($"Variant {a}, number {b}");
            //switch (a)
            //{
            //    case 1:
            //        b = b / 10;
            //        Console.WriteLine(b + " meters");
            //        break;
            //    case 2:
            //        b = b * 1000;
            //        Console.WriteLine(b + " meters");
            //        break;
            //    case 3:
            //        Console.WriteLine(b + " meters");
            //        break;
            //    case 4:
            //        b = b / 1000;
            //        Console.WriteLine(b + " meters");
            //        break;
            //    case 5:
            //        b = b / 100;
            //        Console.WriteLine(b + " meters");
            //        break;
            //}


            //7.
            //int C = new Random().Next(1, 5);
            //LALALA(C);
            //Console.WriteLine("Действие 0-продолжать движение; 1-поворот налево; -1-поворот направо");
            //int N = int.Parse(Console.ReadLine());
            //switch (N)
            //{
            //    case 1:
            //        switch (C)
            //        {
            //            case 1:
            //                C = 4;
            //                LALALA(C);
            //                break;
            //            default:
            //                C--;
            //                LALALA(C);
            //                break;
            //        }
            //        break;

            //    case -1:
            //        switch (C)
            //        {
            //            case 4:
            //                C = 1;
            //                LALALA(C);
            //                break;
            //            default:
            //                C++;
            //                LALALA(C);
            //                break;
            //        }
            //        break;
            //    case 0:
            //        LALALA(C);
            //        break;
            //}


            //8.
            //int alt = new Random().Next(20,70);
            //if (alt % 10)
            //{
            //    Console.WriteLine(alt + "год");
            //}
            //else if (alt % 10 > 1 & alt % 10 < 5)
            //{
            //    Console.WriteLine(alt + "года");
            //}
            //else
            //{
            //    Console.WriteLine(alt + "лет");
            //}
        }
        static void LALALA(int a)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("Направление Север");
                    break;
                case 2:
                    Console.WriteLine("Направление Восток");
                    break;
                case 3:
                    Console.WriteLine("Направление Юг");
                    break;
                case 4:
                    Console.WriteLine("Направление Запад");
                    break;
            }
        }
    }
}