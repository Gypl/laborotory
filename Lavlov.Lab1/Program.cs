﻿using System;

namespace Lavlov.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Чему равно значение функции:F=Sin^2(Log(b,5)/Sqrt(Cos(2*a)))?");
            double info = double.Parse(Console.ReadLine());
            double result = Math.Pow(Math.Sin(Math.Log(b, 5) / Math.Sqrt(Math.Cos(Math.PI * a / 180 * 2))), 2);
            Console.WriteLine("Правильный ответ:" + result);
            Console.ReadKey();
        }
    }
}