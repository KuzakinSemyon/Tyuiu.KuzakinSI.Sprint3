using System;
using Tyuiu.KuzakinSI.Sprint3.Task2.V27.Lib;

namespace Tyuiu.KuzakinSI.Sprint3.Task2.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do...while                                         *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму   *");
            Console.WriteLine("* ряда по формуле S = Σ(4/(1 + x^i)) при x=5, где i от 1 до 14           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int value = 5;
            int startValue = 1;
            int stopValue = 14;
            
            Console.WriteLine($"Значение x = {value}");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            double result = ds.GetSumSeries(value, startValue, stopValue);
            
            Console.WriteLine($"Сумма ряда S = {result}");
            
            Console.ReadLine();
        }
    }
}