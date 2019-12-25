using System;

namespace homework13
{
    enum TypeOfCoffee
    {
        Latte,
        Americano,
        Capuchino,
        Expresso
    }

    class CoffeeMaker
    {
        private int totalValueOfWater;
        private int totalCountOfSeed;
        private int totalValueOfMilk;
        private int totalValueOfSugar;
        private bool totalIsOn;

        private int valueOfWater;
        private int countOfSeed;
        private int valueOfMilk;
        private int valueOfSugar;
        private bool isOn = true;

        public CoffeeMaker(int totalValueOfWater, int totalVountOfSeed, int totalValueOfMilk, int totalValueOfSugar, bool totalIsOn)
        {
            this.totalValueOfWater = totalValueOfWater;
            this.totalCountOfSeed = totalVountOfSeed;
            this.totalValueOfMilk = totalValueOfMilk;
            this.totalValueOfSugar = totalValueOfSugar;
            this.totalIsOn = totalIsOn;
        }

        public int ValueOfWater { get => valueOfWater; }
        public int CountOfSeed { get => countOfSeed; }
        public int ValueOfMilk { get => valueOfMilk; }
        public int ValueOfSugar { get => valueOfSugar; }
        public bool IsOn { get => isOn;}

        public void MakeCoffee(TypeOfCoffee typeOfCoffee)
        {
            if (IsOn==totalIsOn)
            {
                Console.WriteLine("Do you want double sugar (yes, on)");
                string str1 = Console.ReadLine();
                Console.WriteLine("Do you want double milk (yes, on)");
                string str2 = Console.ReadLine();
                if (str1 == "yes")
                {
                    switch (typeOfCoffee)
                    {
                        case TypeOfCoffee.Americano:
                            valueOfWater = 100;
                            countOfSeed = 10;
                            valueOfSugar = 20;

                            if (totalValueOfWater > ValueOfWater)
                            {
                                totalValueOfWater -= ValueOfWater;
                                if (totalCountOfSeed > countOfSeed)
                                {
                                    totalCountOfSeed -= countOfSeed;
                                    if (totalValueOfSugar > valueOfSugar)
                                    {
                                        totalValueOfSugar -= valueOfSugar;
                                        Console.WriteLine("Here is youre coffee");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Put some more sugar int the coffee maker");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Put some seeds in the coffee maker");
                                }
                            }
                            else
                                Console.WriteLine("Watertank is empty. Please full tank");
                            break;
                        case TypeOfCoffee.Capuchino:
                            valueOfWater = 80;
                            countOfSeed = 25;
                            valueOfSugar = 30;
                            valueOfMilk = 20;

                            if (totalValueOfWater > ValueOfWater)
                            {
                                totalValueOfWater -= ValueOfWater;
                                if (totalCountOfSeed > countOfSeed)
                                {
                                    totalCountOfSeed -= countOfSeed;
                                    if (totalValueOfSugar > valueOfSugar)
                                    {
                                        totalValueOfSugar -= valueOfSugar;
                                        Console.WriteLine("Here is youre coffee");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Put some more sugar int the coffee maker");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Put some seeds in the coffee maker");
                                }
                            }
                            else
                                Console.WriteLine("Watertank is empty. Please full tank");
                            break;
                        case TypeOfCoffee.Expresso:
                            valueOfWater = 250;
                            countOfSeed = 15;
                            valueOfSugar = 10;
                            valueOfMilk = 30;

                            if (totalValueOfWater > ValueOfWater)
                            {
                                totalValueOfWater -= ValueOfWater;
                                if (totalCountOfSeed > countOfSeed)
                                {
                                    totalCountOfSeed -= countOfSeed;
                                    if (totalValueOfSugar > valueOfSugar)
                                    {
                                        totalValueOfSugar -= valueOfSugar;
                                        Console.WriteLine("Here is youre coffee");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Put some more sugar int the coffee maker");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Put some seeds in the coffee maker");
                                }
                            }
                            else
                                Console.WriteLine("Watertank is empty. Please full tank");
                            break;
                        case TypeOfCoffee.Latte:
                            valueOfWater = 300;
                            countOfSeed = 5;
                            valueOfSugar = 50;
                            valueOfMilk = 70;

                            if (totalValueOfWater > ValueOfWater)
                            {
                                totalValueOfWater -= ValueOfWater;
                                if (totalCountOfSeed > countOfSeed)
                                {
                                    totalCountOfSeed -= countOfSeed;
                                    if (totalValueOfSugar > valueOfSugar)
                                    {
                                        totalValueOfSugar -= valueOfSugar;
                                        Console.WriteLine("Here is youre coffee");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Put some more sugar int the coffee maker");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Put some seeds in the coffee maker");
                                }
                            }
                            else
                                Console.WriteLine("Watertank is empty. Please full tank");
                            break;
                    }
                }
                if(str2 == "yes")
                {
                    switch (typeOfCoffee)
                    {
                        case TypeOfCoffee.Americano:
                            valueOfWater = 100;
                            countOfSeed = 5;
                            valueOfSugar = 10;

                            if (totalValueOfWater > ValueOfWater)
                            {
                                totalValueOfWater -= ValueOfWater;
                                if (totalCountOfSeed > countOfSeed)
                                {
                                    totalCountOfSeed -= countOfSeed;
                                    if (totalValueOfSugar > valueOfSugar)
                                    {
                                        totalValueOfSugar -= valueOfSugar;
                                        Console.WriteLine("Here is youre coffee");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Put some more sugar int the coffee maker");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Put some seeds in the coffee maker");
                                }
                            }
                            else
                                Console.WriteLine("Watertank is empty. Please full tank");
                            break;
                        case TypeOfCoffee.Capuchino:
                            valueOfWater = 80;
                            countOfSeed = 25;
                            valueOfSugar = 15;
                            valueOfMilk = 40;

                            if (totalValueOfWater > ValueOfWater)
                            {
                                totalValueOfWater -= ValueOfWater;
                                if (totalCountOfSeed > countOfSeed)
                                {
                                    totalCountOfSeed -= countOfSeed;
                                    if (totalValueOfSugar > valueOfSugar)
                                    {
                                        totalValueOfSugar -= valueOfSugar;
                                        Console.WriteLine("Here is youre coffee");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Put some more sugar int the coffee maker");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Put some seeds in the coffee maker");
                                }
                            }
                            else
                                Console.WriteLine("Watertank is empty. Please full tank");
                            break;
                        case TypeOfCoffee.Expresso:
                            valueOfWater = 250;
                            countOfSeed = 15;
                            valueOfSugar = 5;
                            valueOfMilk = 60;

                            if (totalValueOfWater > ValueOfWater)
                            {
                                totalValueOfWater -= ValueOfWater;
                                if (totalCountOfSeed > countOfSeed)
                                {
                                    totalCountOfSeed -= countOfSeed;
                                    if (totalValueOfSugar > valueOfSugar)
                                    {
                                        totalValueOfSugar -= valueOfSugar;
                                        Console.WriteLine("Here is youre coffee");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Put some more sugar int the coffee maker");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Put some seeds in the coffee maker");
                                }
                            }
                            else
                                Console.WriteLine("Watertank is empty. Please full tank");
                            break;
                        case TypeOfCoffee.Latte:
                            valueOfWater = 300;
                            countOfSeed = 5;
                            valueOfSugar = 25;
                            valueOfMilk = 140;

                            if (totalValueOfWater > ValueOfWater)
                            {
                                totalValueOfWater -= ValueOfWater;
                                if (totalCountOfSeed > countOfSeed)
                                {
                                    totalCountOfSeed -= countOfSeed;
                                    if (totalValueOfSugar > valueOfSugar)
                                    {
                                        totalValueOfSugar -= valueOfSugar;
                                        Console.WriteLine("Here is youre coffee");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Put some more sugar int the coffee maker");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Put some seeds in the coffee maker");
                                }
                            }
                            else
                                Console.WriteLine("Watertank is empty. Please full tank");
                            break;
                    }
                }
                if (str2 == "yes" & str1 == "yes")
                {
                    switch (typeOfCoffee)
                    {
                        case TypeOfCoffee.Americano:
                            valueOfWater = 100;
                            countOfSeed = 5;
                            valueOfSugar = 20;

                            if (totalValueOfWater > ValueOfWater)
                            {
                                totalValueOfWater -= ValueOfWater;
                                if (totalCountOfSeed > countOfSeed)
                                {
                                    totalCountOfSeed -= countOfSeed;
                                    if (totalValueOfSugar > valueOfSugar)
                                    {
                                        totalValueOfSugar -= valueOfSugar;
                                        Console.WriteLine("Here is youre coffee");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Put some more sugar int the coffee maker");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Put some seeds in the coffee maker");
                                }
                            }
                            else
                                Console.WriteLine("Watertank is empty. Please full tank");
                            break;
                        case TypeOfCoffee.Capuchino:
                            valueOfWater = 80;
                            countOfSeed = 25;
                            valueOfSugar = 30;
                            valueOfMilk = 40;

                            if (totalValueOfWater > ValueOfWater)
                            {
                                totalValueOfWater -= ValueOfWater;
                                if (totalCountOfSeed > countOfSeed)
                                {
                                    totalCountOfSeed -= countOfSeed;
                                    if (totalValueOfSugar > valueOfSugar)
                                    {
                                        totalValueOfSugar -= valueOfSugar;
                                        Console.WriteLine("Here is youre coffee");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Put some more sugar int the coffee maker");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Put some seeds in the coffee maker");
                                }
                            }
                            else
                                Console.WriteLine("Watertank is empty. Please full tank");
                            break;
                        case TypeOfCoffee.Expresso:
                            valueOfWater = 250;
                            countOfSeed = 15;
                            valueOfSugar = 10;
                            valueOfMilk = 60;

                            if (totalValueOfWater > ValueOfWater)
                            {
                                totalValueOfWater -= ValueOfWater;
                                if (totalCountOfSeed > countOfSeed)
                                {
                                    totalCountOfSeed -= countOfSeed;
                                    if (totalValueOfSugar > valueOfSugar)
                                    {
                                        totalValueOfSugar -= valueOfSugar;
                                        Console.WriteLine("Here is youre coffee");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Put some more sugar int the coffee maker");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Put some seeds in the coffee maker");
                                }
                            }
                            else
                                Console.WriteLine("Watertank is empty. Please full tank");
                            break;
                        case TypeOfCoffee.Latte:
                            valueOfWater = 300;
                            countOfSeed = 5;
                            valueOfSugar = 50;
                            valueOfMilk = 140;

                            if (totalValueOfWater > ValueOfWater)
                            {
                                totalValueOfWater -= ValueOfWater;
                                if (totalCountOfSeed > countOfSeed)
                                {
                                    totalCountOfSeed -= countOfSeed;
                                    if (totalValueOfSugar > valueOfSugar)
                                    {
                                        totalValueOfSugar -= valueOfSugar;
                                        Console.WriteLine("Here is youre coffee");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Put some more sugar int the coffee maker");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Put some seeds in the coffee maker");
                                }
                            }
                            else
                                Console.WriteLine("Watertank is empty. Please full tank");
                            break;
                    }
                }
                else
                {
                    switch (typeOfCoffee)
                    {
                        case TypeOfCoffee.Americano:
                            valueOfWater = 100;
                            countOfSeed = 5;
                            valueOfSugar = 10;

                            if (totalValueOfWater > ValueOfWater)
                            {
                                totalValueOfWater -= ValueOfWater;
                                if(totalCountOfSeed > countOfSeed)
                                {
                                    totalCountOfSeed -= countOfSeed;
                                    if(totalValueOfSugar > valueOfSugar)
                                    {
                                        totalValueOfSugar -= valueOfSugar;
                                        Console.WriteLine("Here is youre coffee");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Put some more sugar int the coffee maker");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Put some seeds in the coffee maker");
                                }
                            }
                            else
                                Console.WriteLine("Watertank is empty. Please full tank");
                            break;
                        case TypeOfCoffee.Capuchino:
                            valueOfWater = 80;
                            countOfSeed = 25;
                            valueOfSugar = 15;

                            if (totalValueOfWater > ValueOfWater)
                            {
                                totalValueOfWater -= ValueOfWater;
                                if (totalCountOfSeed > countOfSeed)
                                {
                                    totalCountOfSeed -= countOfSeed;
                                    if (totalValueOfSugar > valueOfSugar)
                                    {
                                        totalValueOfSugar -= valueOfSugar;
                                        Console.WriteLine("Here is youre coffee");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Put some more sugar int the coffee maker");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Put some seeds in the coffee maker");
                                }
                            }
                            else
                                Console.WriteLine("Watertank is empty. Please full tank");
                            break;
                        case TypeOfCoffee.Expresso:
                            valueOfWater = 250;
                            countOfSeed = 15;
                            valueOfSugar = 5;

                            if (totalValueOfWater > ValueOfWater)
                            {
                                totalValueOfWater -= ValueOfWater;
                                if (totalCountOfSeed > countOfSeed)
                                {
                                    totalCountOfSeed -= countOfSeed;
                                    if (totalValueOfSugar > valueOfSugar)
                                    {
                                        totalValueOfSugar -= valueOfSugar;
                                        Console.WriteLine("Here is youre coffee");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Put some more sugar int the coffee maker");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Put some seeds in the coffee maker");
                                }
                            }
                            else
                                Console.WriteLine("Watertank is empty. Please full tank");
                            break;
                        case TypeOfCoffee.Latte:
                            valueOfWater = 300;
                            countOfSeed = 5;
                            valueOfSugar = 25;

                            if (totalValueOfWater > ValueOfWater)
                            {
                                totalValueOfWater -= ValueOfWater;
                                if (totalCountOfSeed > countOfSeed)
                                {
                                    totalCountOfSeed -= countOfSeed;
                                    if (totalValueOfSugar > valueOfSugar)
                                    {
                                        totalValueOfSugar -= valueOfSugar;
                                        Console.WriteLine("Here is youre coffee");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Put some more sugar int the coffee maker");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Put some seeds in the coffee maker");
                                }
                            }
                            else
                                Console.WriteLine("Watertank is empty. Please full tank");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Turn the coffee machine on");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region ForCoffeeMaker
            int totalValueOfWater = 540;
            int totalCountOfSeed = 75;
            int totalValueOfMilk = 100;
            int totalValueOfSugar = 25;
            bool totalIsOn = true;
            CoffeeMaker coffeeMaker1 = new CoffeeMaker(totalValueOfWater, totalCountOfSeed, totalValueOfMilk, totalValueOfSugar, totalIsOn);
            coffeeMaker1.MakeCoffee(TypeOfCoffee.Expresso);
            
            #endregion
        }
    }
}
