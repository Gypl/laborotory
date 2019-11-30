using System;

namespace Lavlov.Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            while (exit)
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
                            double a;
                            while (!double.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите число");
                            }
                            double cos = (Math.Round(Math.Cos(Math.PI * (a * 2) / 180), 2));
                            double sqrt = Math.Sqrt(cos);
                            if (cos <= 0 && sqrt != Math.Pow(cos, 0.5))
                            {
                                Console.Write("Ошибка!\n");
                            }
                            else
                            {
                                Console.Write("Введите значение b:");
                                double b;
                                while (!double.TryParse(Console.ReadLine(), out b))
                                {
                                    Console.WriteLine("Введите число");
                                }
                                if (b <= 0)
                                {
                                    Console.WriteLine("Ошибка!\n");
                                }
                                else
                                {
                                    double result = Math.Round(Math.Pow(Math.Sin(Math.Log(b, 5) / Math.Sqrt(Math.Cos(Math.PI * a / 180 * 2))), 2), 2);
                                    Console.WriteLine("Чему равно значение функции:F=Sin^2(Log(" + b + ",5)/Sqrt(Cos(2*" + a + ")))?");
                                    double info;
                                    int h = 3;
                                    while (h > 0)
                                    {
                                        while (!double.TryParse(Console.ReadLine(), out info))
                                        {
                                            Console.WriteLine("Введите число");
                                        }
                                        if (info == result)
                                        {
                                            h = 0;
                                            Console.WriteLine("Вы выйграли!");
                                        }
                                        else
                                        {
                                            h--;
                                            Console.WriteLine("Ответ не верный. Попыток:" + h);
                                        }
                                        if (result != info && h == 0)
                                            Console.WriteLine("Вы проиграли!\nПравильный ответ:" + result);
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Лавлов А.Ю., группа:6102\n");
                        break;
                    case 3:
                        Console.WriteLine("Вы точно хотите выйти?\n д/н");
                        switch (Console.ReadLine())
                        {
                            case "д":
                                exit = false;
                                break;
                            case "н":
                                break;
                            default:
                                Console.WriteLine("Ошибка");
                                break;
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