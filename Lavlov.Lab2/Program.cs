﻿using System;

namespace Lavlov.Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
        private static void Menu()
        {
            while (true)
            {
                Console.WriteLine("1-Отгадай ответ\n2-Об авторе\n3-Выход");
                int menu;
                while (!int.TryParse(Console.ReadLine(), out menu))
                {
                    Console.WriteLine("1-Отгадай ответ\n2-Об авторе\n3-Выход");
                }
                switch (menu)
                {
                    case 1:
                        {
                            Console.Write("Введите значение a:");
                            double a = double.Parse(Console.ReadLine());
                            double cos = (Math.Round(Math.Cos(Math.PI * (a * 2) / 180), 2));
                            double sqrt = Math.Sqrt(cos);
                            while (cos <= 0 && sqrt != Math.Pow(cos, 0.5))
                            {
                                Console.Write("Ошибка!\nВведите угол принадлежащий I и IV четвертям триганометра а:");
                                a = double.Parse(Console.ReadLine());
                                cos = (Math.Round(Math.Cos(Math.PI * a / 180 * 2), 2));
                                sqrt = Math.Sqrt(cos);
                            }
                            Console.Write("Введите значение b:");
                            double b = double.Parse(Console.ReadLine());
                            while (b <= 0)
                            {
                                Console.WriteLine("Значение b не межет быть отрицательным\nВведите значение b:");
                                b = double.Parse(Console.ReadLine());
                            }
                            double result = Math.Round(Math.Pow(Math.Sin(Math.Log(b, 5) / Math.Sqrt(Math.Cos(Math.PI * a / 180 * 2))), 2), 2);
                            Console.WriteLine("Чему равно значение функции:F=Sin^2(Log(" + b + ",5)/Sqrt(Cos(2*" + a + ")))?");
                            double info;
                            while (!double.TryParse(Console.ReadLine(), out info))
                            {
                                Console.WriteLine("Введите число");
                            }
                            if (info == result)
                            {
                                Console.WriteLine("Вы выйграли!");
                            }
                            else
                            {
                                Console.WriteLine("Ответ не верный.Правильный ответ:" + result);
                            }

                        }
                        break;
                    case 2:
                        Console.WriteLine("Лавлов А.Ю., группа:6102");
                        break;
                    case 3:
                        Console.WriteLine("Вы точно хотите выйти?\n д/н");
                        char decision = char.Parse(Console.ReadLine());
                        while (decision != 'д' && decision != 'н')
                        {
                            Console.WriteLine("Вы точно хотите выйти?\n д/н");
                        }
                        if (decision == 'д')
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }
        }
    }
}
