using System;

namespace homework22
{

    //1
    static class Calculator
    {
        public static void Plus(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Mines(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Devide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
    //2
    static class FindAndReplaceManager
    {
        public static string Str { get; set; }
        public static void FindNext(char ch)
        {
            if(Str == null)
            {
                Console.WriteLine("Please complete the String");
            }
            int count = 0;
            for (int i = 0; i < Str.Length; i++)
            {
                if (Str[i] == ch)
                {
                    count++;
                }
            }
            if (count != 0)
            {
                Console.WriteLine($"Element \'{ch}\' was found in string \"{Str}\"");
            }
            else
            {
                Console.WriteLine($"Element \'{ch}\' is not in string \"{Str}\"");
            }
        }
    }

    //3
    static class ArraySort
    {
        public static int[] Arr { get; set; }
        public static void BubbleSort()
        {
            if (Arr == null)
            {
                Console.WriteLine("Please complete the Array");
            }
            else
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    Console.Write(Arr[i] + "  ");
                }
                int temp;
                for (int i = 0; i < Arr.Length - 1; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (Arr[j + 1] > Arr[j])
                        {
                            temp = Arr[j + 1];
                            Arr[j + 1] = Arr[j];
                            Arr[j] = temp;
                        }
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < Arr.Length; i++)
                {
                    Console.Write(Arr[i] + "  ");
                }
            }
        }
    }

    //4
    class DataBaseConnection
    {
        private static DataBaseConnection instance;
        protected DataBaseConnection() { }
        public static DataBaseConnection BaseConnect()
        {
            if (instance == null)
            {
                Console.WriteLine("Base is connected");
                instance = new DataBaseConnection();
            }
            else
            {
                Console.WriteLine("Base is already connected");
            }
            return instance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //1
            Calculator.Plus(7, 5);
            Calculator.Mines(8, 3);
            Calculator.Multiply(3, 7);
            Calculator.Devide(14, 7);

            //2
            FindAndReplaceManager.Str = "hello world";
            FindAndReplaceManager.FindNext('a');

            //3
            ArraySort.Arr = new int[7]{9, 3, 6, 1, 5, 0, 8};
            ArraySort.BubbleSort();

            //4
            DataBaseConnection lay = DataBaseConnection.BaseConnect();
            DataBaseConnection lay1 = DataBaseConnection.BaseConnect();
        }
    }
}