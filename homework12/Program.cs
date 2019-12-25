using System;

namespace homework12
{
    class Tiles
    {
        public string brand;
        public int size_h;
        public int size_w;
        public int price;
        public void GetData()
        {
            Console.WriteLine($"Description: Brand - {brand}, heigth {size_h}cm, width {size_w}cm, price {price}$");
        }
    }
    class Children
    {
        private string firstName;
        private string lastName;
        private int age;
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public int Age { get { return age; } }
        public Children(string firstName, string lastName, int age)
        {
            this.age = age;
            this.lastName = lastName;
            this.firstName = firstName;
        }
    }
    class Replace
    {
        private int[,] arr1 = new int[5,5];
        private int[,] arr2 = new int[5,5];
        private void Create()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr1[i, j] = new Random().Next(0,21);
                }
            }
        }
        private void Rep()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr2[i, j] = arr1[j, i];
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Tiles tile1 = new Tiles();
            tile1.brand = "Lalka";
            tile1.size_h = 70;
            tile1.size_w = 50;
            tile1.price = 20;
            tile1.GetData();

            Tiles tile2 = new Tiles();
            tile1.brand = "Hotler";
            tile1.size_h = 45;
            tile1.size_w = 120;
            tile1.price = 45;
            tile1.GetData();
            Console.WriteLine();
            #endregion
            #region Task2
            string firstName1 = "Tima";
            string lastName1 = "Shakhvorostov";
            int age1 = 13;
            Children chield1 = new Children(firstName1,lastName1,age1);
            Console.Write($"First name - {chield1.FirstName}, last name - {chield1.LastName}, age - {chield1.Age}");
            Console.WriteLine();

            string firstName2 = "Andriy";
            string lastName2 = "Starostenko";
            int age2 = 14;
            Children chield2 = new Children(firstName2, lastName2, age2);
            Console.Write($"First name - {chield2.FirstName}, last name - {chield2.LastName}, age - {chield2.Age}");
            Console.WriteLine();
            #endregion
        }
    }
}
