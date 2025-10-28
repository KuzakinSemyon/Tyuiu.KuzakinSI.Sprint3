using System;
using Tyuiu.KuzakinSI.Sprint3.Task4.V8.Lib;

namespace Tyuiu.KuzakinSI.Sprint3.Task4.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=(x/sin(x))+0.5. При х = 0 прервать цикл.                      *");
            Console.WriteLine("* Полученные значения перемножать.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int startValue = -5;
            int stopValue = 5;
            
            Console.WriteLine($"Стартовое значение x = {startValue}");
            Console.WriteLine($"Конечное значение x = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            double result = ds.Calculate(startValue, stopValue);
            
            Console.WriteLine($"Произведение значений функции = {result}");
            
            Console.ReadLine();
        }
    }
}