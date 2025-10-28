using System;
using Tyuiu.KuzakinSI.Sprint3.Task1.V18.Lib;

namespace Tyuiu.KuzakinSI.Sprint3.Task1.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда   *");
            Console.WriteLine("* по формуле S = Σ(sin(i) * (1/4)²) при i от 1 до 15                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int startValue = 1;
            int stopValue = 15;
            
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            double result = ds.GetSumSeries(startValue, stopValue);
            
            Console.WriteLine($"Сумма ряда S = {result}");
            
            Console.WriteLine("Формула: S = Σ(sin(i) * (1/4)²) для i от 1 до 15");
            
            Console.ReadLine();
        }
    }
}