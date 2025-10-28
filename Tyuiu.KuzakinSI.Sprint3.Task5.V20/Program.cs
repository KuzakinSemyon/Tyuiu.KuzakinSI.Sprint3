using System;
using Tyuiu.KuzakinSI.Sprint3.Task5.V20.Lib;

namespace Tyuiu.KuzakinSI.Sprint3.Task5.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму двойного ряда:             *");
            Console.WriteLine("* y = Σ(i=1 to 3) Σ(k=1 to 6) (x/sin(x))^k при x = 5                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 6;
            
            Console.WriteLine($"Значение x = {x}");
            Console.WriteLine($"Старт внешнего цикла (i) = {startValue1}");
            Console.WriteLine($"Конец внешнего цикла (i) = {stopValue1}");
            Console.WriteLine($"Старт внутреннего цикла (k) = {startValue2}");
            Console.WriteLine($"Конец внутреннего цикла (k) = {stopValue2}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            
            Console.WriteLine($"Сумма двойного ряда y = {result}");
            
            Console.WriteLine();
            Console.WriteLine("Формула: y = Σ(i=1 to 3) Σ(k=1 to 6) (x/sin(x))^k");
            Console.WriteLine($"При x = {x}: x/sin(x) = {x}/sin({x}) = {x / Math.Sin(x):F3}");
            
            Console.ReadLine();
        }
    }
}