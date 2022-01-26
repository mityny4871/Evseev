using System;
using System.Linq;

namespace Evseev
{
    class Program
    {
        const string text = "Задание №1:(если введенное число больше 7, то вывести “Привет”)\n" +
                  "Задание №2 (если введенное имя совпадает с Вячеслав, то вывести “Привет, Вячеслав”, если нет, то вывести \"Нет такого имени\")\n" +
                  "Задание №3 (на входе есть числовой массив, необходимо вывести элементы массива кратные 3)\n" +
                  "Цифра 0 Завершит приложение \n Введите номер задачи!";
        static void Main()
        {
            /* 
         [((())()(())]]
         Заменить предпоследнюю квадратную скобку на закруглкенную
         ((())()(()))  
       */


            Console.WriteLine(text);

            string str;
            bool isNum;
            do
            {

                str = Console.ReadLine();


                int num;
                isNum = int.TryParse(str, out num);
                if (!isNum)
                    Console.WriteLine("Это не число. Повторите");
                else
                {
                    string[] array = { "0", "1", "2", "3" };
                    if (!array.Contains(str))
                    {
                        isNum = false;
                        Console.WriteLine("Такой задачи не существует. Повторите\n");
                    }
                }


                if (isNum == true)
                {
                    int value = Convert.ToInt32(str);
                    Console.WriteLine("Вы выбрали задание " + value + '\n');


                    if (value == 0)
                        Environment.Exit(0);
                    if (value == 1)
                    {
                        Console.WriteLine("Введите число, если больше 7, то выйдет “Привет”\n");
                        isNum = print_hello(Convert.ToInt32(Console.ReadLine()));
                    }
                    if (value == 2)
                    {
                        Console.WriteLine("Введите имя\n");
                        isNum = whatYourName(Console.ReadLine());
                    }

                    if (value == 3)
                    {
                        Console.WriteLine("Введите числа через пробел\n");
                        isNum = arrayCheck(Console.ReadLine());
                    }

                    Console.WriteLine(text);
                }

            }
            while (!isNum);

            Console.ReadKey();
        }



        static Boolean print_hello(int num)
        {
            if (num > 7)
                Console.WriteLine("Привет!\n");
            else
                Console.WriteLine("Это не так!" + num);
            return false;
        }


        static Boolean whatYourName(String checkName)
        {
            object comparingName = "Вячеслав";
            bool result = comparingName.Equals(checkName);

            if (!result)
                Console.WriteLine("Нет такого имени!\n");
            else
                Console.WriteLine("Привет, Вячеслав\n");

            return false;
        }

        static Boolean arrayCheck(String line_num)
        {
            bool isNum;
            int num;
            string[] strArr = line_num.Split(" ").Select(str => str.Trim()).ToArray();


            for (int i = 0; i < strArr.Length; i++)
            {
                isNum = int.TryParse(strArr[i], out num);
                if (isNum == true)
                {
                    int value = Convert.ToInt32(strArr[i]);
                    if (value % 3 == 0)
                    {
                        Console.WriteLine(value + "- это совпадение\n");
                    }
                }
            }

            return false;
        }

    }
}
