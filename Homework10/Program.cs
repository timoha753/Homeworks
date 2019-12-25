using System;

namespace Homework10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            {
                string a = "hi";
                string b = "hello";
                string c = "hello world";
                string temp1 = a;
                string temp2 = b;
                string temp3 = c;
                //a
                {
                    c = string.Empty;
                    a = string.Empty;
                    b = string.Empty;
                    b = temp3;
                    a = temp2;
                    c = temp1;
                    Console.WriteLine($"{a}  {b}  {c}");
                }
                //b
                {
                    c = string.Empty;
                    a = string.Empty;
                    b = string.Empty;
                    b = temp1;
                    a = temp3;
                    c = temp2;
                    Console.WriteLine($"{a}  {b}  {c}");
                }
            }
            #endregion
            #region 2
            {
                string str = "hello";
                if (str[0] == str[str.Length - 1])
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            #endregion
            #region 3
            {
                string str1 = "hello";
                string str2 = "amazing";
                if (str1[0] == str2[str2.Length - 1]) Console.WriteLine("yes");
                else Console.WriteLine("no");
            }
            #endregion
            #region 4
            {
                string str = "piping ipng";
                int count = 0;
                for (int i = 0; i < str.Length-1; i++)
                {
                    string repeat1 = str[i] + str[i + 1].ToString();
                    for (int j = 0; j < str.Length-1; j++)
                    {
                        string repeat2 = str[j] + str[j + 1].ToString();
                        if (i != j)
                        {
                            if (repeat1 == repeat2) count++;
                        }
                    }
                }
                Console.WriteLine(count);
            }
            #endregion
            #region 5
            {
                int count = 0;
                string str = "We live on the earth. It is very, very big. There is a lot of water on the earth. It is in rivers, lakes, seas and oceans. There are a lot of forests and fields, hills and mountains on it. The earth is full of wonders. Different animals live on the earth. Different plants grow on it. The earth is beautiful. There are large countries and small countries. There are warm countries and cold countries. There are some countries where there are four seasons in a year and some countries where there are only two. When the sun shines it is day. When the sun does not shine it is night. When it is day in one country it is night in another. You can see the moon and the stars in the sky at night. People live in different countries. They speak different languages.People have lived on our planet for many years. They lived and live on different continents, in different countries.People depend on their planet, on the sun, on animals and plants around them.People must take care of Earth.Our ecology becomes worse and worse with every new day.Many species of animals and birds are disappearing nowadays.People destruct wildlife, cut down trees to make furniture.They forget that people can't live without trees and plants, because they fill air with oxygen. And, of course, great problems are population and animals destruction. The main reason of pollution is rubbish. Most of our rubbish goes to big holes in the ground, called 'dumps'.";
                for (int i = 0; i < str.Length-1; i++)
                {
                    if (str[i] == '.') count++;
                }
                Console.WriteLine("Тут "+count+" предложений");
            }
            #endregion
            #region 6
            {
                string str = "уBысЕфТ";
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i] == 'с') { Console.WriteLine("с встречается первой"); i = str.Length - 1; }
                    if (str[i] == 'Т') {Console.WriteLine("T встречается первой"); i = str.Length - 1; }
                }
            }
            #endregion
            #region 7
            {
                string str = "Oh my god";
                string temp = str;
                for (int i = 2; i <= str.Length-1;)
                {
                    str = str.Replace(str[i],'a');
                    i += 3;
                }
                Console.WriteLine(str);
            }
            #endregion
            #region 8
            {
                string str = "dragme";
                char ch = str[1];
                string temp = string.Empty;
                for (int i = 0; i <= str.Length-1; i++)
                {
                    if (i == 1)
                    {
                        temp += str[4];
                    }
                    if (i == 4)
                    {
                        temp += ch;
                    }
                    if (i != 1 & i!= 4)
                    {
                        temp += str[i];
                    }
                }
                str = string.Empty;
                str = temp;
                Console.WriteLine(str);
            }
            #endregion
            #region 9
            {
                string str = "1 sdf 23 jses4 5bh6o78j9";
                int count = 0;
                for (int i = 0; i <= str.Length-1; i++)
                {
                    if (str[i] == '1') count++;
                    if (str[i] == '2') count = count+2;
                    if (str[i] == '3') count = count+3;
                    if (str[i] == '4') count = count+4;
                    if (str[i] == '5') count = count+5;
                    if (str[i] == '6') count = count+6;
                    if (str[i] == '7') count = count+7;
                    if (str[i] == '8') count = count+8;
                    if (str[i] == '9') count = count+9;
                }
                Console.WriteLine(count);
            }
            #endregion
            #region 10
            {
                int num = new Random().Next(0, 1001);
                string str = string.Empty;
                string str1 = "один";
                string str2 = "два";
                string str3 = "три";
                string str4 = "четыри";
                string str5 = "пять";
                string str6 = "шесть";
                string str7 = "семь";
                string str8 = "восемь";
                string str9 = "девять";
                string str10 = "десять ";
                string str11 = "одинадцать";
                string str12 = "двенадцать";
                string str13 = "тринадцать";
                string str14 = "четырнадцать";
                string str15 = "пятнадцать";
                string str16 = "шестнадцать";
                string str17 = "семнадцать";
                string str18 = "восемнадцать";
                string str19 = "девятнадцать";
                string str20 = "двадцать ";
                string str30 = "тридцать ";
                string str40 = "сорок ";
                string str50 = "пятьдесят ";
                string str60 = "шестьдесят ";
                string str70 = "семьдесят ";
                string str80 = "восемьдесят ";
                string str90 = "девяносто ";
                string str100 = "сто ";
                string str200 = "двести ";
                string str300 = "триста ";
                string str400 = "четыреста ";
                string str500 = "пятьсот ";
                string str600 = "шестьсот ";
                string str700 = "семьсот ";
                string str800 = "восемьсот ";
                string str900 = "девятьсот ";
                if (num == 0)
                {
                    str = "ноль";
                }
                if (num == 1000)
                {
                    str = "тысяча";
                }


                if ((num / 100) == 1)
                {
                    str += str100;
                }
                if ((num / 100) == 2)
                {
                    str += str200;
                }
                if ((num / 100) == 3)
                {
                    str += str300;
                }
                if ((num / 100) == 4)
                {
                    str += str400;
                }
                if ((num / 100) == 5)
                {
                    str += str500;
                }
                if ((num / 100) == 6)
                {
                    str += str600;
                }
                if ((num / 100) == 7)
                {
                    str += str700;
                }
                if ((num / 100) == 8)
                {
                    str += str800;
                }
                if ((num / 100) == 9)
                {
                    str += str900;
                }


                if ((num / 10 % 10) == 1)
                {
                    if ((num % 10) == 0)
                    {
                        str += str10;
                    }
                    if ((num % 10)==1)
                    {
                        str += str11;
                    }
                    if ((num % 10)==2)
                    {
                        str += str12;
                    }
                    if ((num % 10)==3)
                    {
                        str += str13;
                    }
                    if ((num % 10)==4)
                    {
                        str += str14;
                    }
                    if ((num % 10)==5)
                    {
                        str += str15;
                    }
                    if ((num % 10)==6)
                    {
                        str += str16;
                    }
                    if ((num % 10)==7)
                    {
                        str += str17;
                    }
                    if ((num % 10)==8)
                    {
                        str += str18;
                    }
                    if ((num % 10)==9)
                    {
                        str += str19;
                    }
                }
                if ((num % 100 / 10) == 2)
                {
                    str += str20;
                }
                if ((num % 100 / 10) == 3)
                {
                    str += str30;
                }
                if ((num % 100 / 10) == 4)
                {
                    str += str40;
                }
                if ((num % 100 / 10) == 5)
                {
                    str += str50;
                }
                if ((num % 100 / 10) == 6)
                {
                    str += str60;
                }
                if ((num % 100 / 10) == 7)
                {
                    str += str70;
                }
                if ((num % 100 / 10) == 8)
                {
                    str += str80;
                }
                if ((num % 100 / 10) == 9)
                {
                    str += str90;
                }


                if ((num % 10) == 1)
                {
                    str += str1;
                }
                if ((num % 10) == 2)
                {
                    str += str2;
                }
                if ((num % 10) == 3)
                {
                    str += str3;
                }
                if ((num % 10) == 4)
                {
                    str += str4;
                }
                if ((num % 10) == 5)
                {
                    str += str5;
                }
                if ((num % 10) == 6)
                {
                    str += str6;
                }
                if ((num % 10) == 7)
                {
                    str += str7;
                }
                if ((num % 10) == 8)
                {
                    str += str8;
                }
                if ((num % 10) == 9)
                {
                    str += str9;
                }
                Console.WriteLine(num+"\n"+str);
            }
            #endregion
        }
    }
}
