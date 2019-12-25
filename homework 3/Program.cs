using System;

namespace homework_3
{
    class Program
    {
        //1.
        static double Dollar(double a)
        {
            double b = a * 0.041;
            return (b);
        }
        static double Euro(double a)
        {
            double b = a * 0.91;
            return (b);
        }
        static double Rub(double a)
        {
            double b = a * 71.34;
            b=Math.Round(b,2);
            return (b);
        }

        //2.
        static double Day(double a)
        {
            double b = a / 86400;
            return (b);
        }
        static double Hou(double a)
        {
            double b = a * 24;
            return (b);
        }
        static double Min(double a)
        {
            double b = a * 60;
            b = Math.Round(b, 2);
            return (b);
        }

        //3.
        static double Per(double a)
        {
            double b = a * 4;
            return (b);
        }
        
        //4.
        static double Diam(double a)
        {
            double b = a * 2;
            return (b);
        }

        //5.
        static double Cost(double a,double b)
        {
            double c = a / 100 * b;
            c = a-c;
            return (c);
        }
        static void Return(double a)
        {
            Console.WriteLine($"Total prise is {a}$");
        }

        static void Main(string[] args)
        {
            //1.
            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    double a = double.Parse(Console.ReadLine());
            //    Console.WriteLine(Rub(Euro(Dollar(a))));
            //}
            //catch
            //{
            //    Console.WriteLine("А вот текст тут не надо было писать");
            //}


            //2.
            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    double a = double.Parse(Console.ReadLine());
            //    Console.WriteLine(Day(Hou(Min(a))));
            //}
            //catch
            //{
            //    Console.WriteLine("А вот текст тут не надо было писать");
            //}


            //3.
            //try
            //{
            //    Console.WriteLine("Укажите сторону квадрата");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(Per(a));
            //}
            //catch
            //{
            //    Console.WriteLine("Укажите целочисленное число");
            //}


            //4.
            //try
            //{
            //    Console.WriteLine("Укажите радиус окружности");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(Diam(a));
            //}
            //catch
            //{
            //    Console.WriteLine("Укажите целочисленное число");
            //}


            //5.
            //try
            //{
            //    Console.WriteLine("What is youre total cost");
            //    double a = double.Parse(Console.ReadLine());
            //    Console.WriteLine("What is youre discount");
            //    double b = double.Parse(Console.ReadLine());
            //    Return(Cost(a,b));
            //}
            //catch
            //{
            //    Console.WriteLine("Write a number(NOT TEXT)");
            //}

        }
    }
}
