using System;

namespace homework30
{
    class ATM : IWork
    {

        public ATM(int money)
        {
            GetCard();
            GetPin();
            ReturnMoney(money);
        }



        public void GetCard()
        {
            Console.WriteLine("1-засунуть карту;\n2-ввести реквизиты");
            int answer = Int32.Parse(Console.ReadLine());
            if (answer == 2)
            {
                for(int i = 0; i == 0;)
                {
                    i = 1;
                    Console.WriteLine("\nВведите номер карты");
                    string cardNumber = Console.ReadLine();
                    Console.WriteLine("Введите ФИО владельца");
                    Console.ReadLine();
                    Console.WriteLine("Введите срок карты");
                    string cardDate = Console.ReadLine();
                    Console.WriteLine("Введите CVV код карты");
                    string cardCode = Console.ReadLine();
                    if(cardNumber.Length != 16 || cardDate.Length != 5 || cardCode.Length != 3 || cardDate[2] != '/')
                    {
                        Console.WriteLine("\nВы ввели реквизиты не верно!!!\n");
                        i = 0;
                    }
                }
            }
        }

        public void GetPin()
        {
            for (int i = 0; i == 0;)
            {
                i = 1;
                Console.WriteLine("Введите пин карты");
                string pin = Console.ReadLine();
                if(pin.Length != 4)
                {
                    Console.WriteLine("Вы ввели пин не верно!!!");
                    i = 0;
                }
            }
        }

        public void ReturnMoney(int money)
        {
            Console.WriteLine("Какую сумму вы хотите снять с карты");
            int sum = int.Parse(Console.ReadLine());
            if(sum > money)
            {
                Console.WriteLine("На вашей карте не достаточно средств");
            }
            else
            {
                Console.WriteLine($"На вашей карте осталось {money - sum}");
            }
        }
    }
}
