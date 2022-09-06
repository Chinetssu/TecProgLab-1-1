using System;

namespace Lab1_1
{
    public class Logic
    {
        public static string Converter(int valueRub, int valueKop){
            string result = "Стоимость = " + valueRub;
            if (!(valueRub == 0))
            {
                if ((valueRub > 10 && valueRub < 20) || (valueRub % 10 > 4) || (valueRub % 10 == 0))
                {
                    result +=" рублей ";
                }
                else
                {
                    if (valueRub % 10 == 1)
                    {
                        result += " рубль ";
                    }
                    if (valueRub % 10 > 1 && valueRub % 10 < 5)
                    {
                        result += " рубля ";
                    }
                }
            }
            //-------------------Копейки--------------------
            if (valueKop == 0)
            {
                result += " ровно";
            }
            else
            {
                result += valueKop;
                if ((valueKop > 10 && valueKop < 20) || (valueKop % 10 > 4) || (valueKop % 10 == 0))
                {
                    result += " копеек";
                }
                else
                {
                    if (valueKop % 10 == 1)
                    {
                        result += " копейка";
                    }
                    if (valueKop % 10 > 1 && valueKop % 10 < 5)
                    {
                        result += " копейки";
                    }
                }
            }
            return result;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Дано натуральное число 1<=n<=9999, определяющее стоимость товара в копейках.
            //Выразить стоимость в рублях и копейках, например, 3 рубля 21 копейка, 15 рублей 5 копеек, 1 рубль ровно и т. п.
            Console.WriteLine("Введите стоимость в копейках");
            int n = int.Parse(Console.ReadLine());
            int valueRub;
            int valueKop;
            valueRub = n / 100;
            valueKop = n - valueRub * 100;
            Console.Write(Logic.Converter(valueRub,valueKop));
            return;
        }
    }
}

