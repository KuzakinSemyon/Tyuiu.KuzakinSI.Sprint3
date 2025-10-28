using System;
using Tyuiu.KuzakinSI.Sprint3.Task7.V10.Lib;

namespace Tyuiu.KuzakinSI.Sprint3.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Табулирование функции                                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:          *");
            Console.WriteLine("* F(x) = (5x + 2.5)/(sin(x) + 3) + 2x + cos(x)                           *");
            Console.WriteLine("* на диапазоне [-5; 5] с шагом 1. Проверить деление на ноль.             *");
            Console.WriteLine("* При делении на ноль вернуть 0. Значения занести в массив и округлить   *");
            Console.WriteLine("* до двух знаков после запятой.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int startValue = -5;
            int stopValue = 5;
            
            Console.WriteLine($"Старт диапазона = {startValue}");
            Console.WriteLine($"Конец диапазона = {stopValue}");
            Console.WriteLine($"Шаг = 1");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            double[] resultArray = ds.GetMassFunction(startValue, stopValue);
            
            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    F(x)   |");
            Console.WriteLine("+----------+-----------+");
            
            for (int i = 0, x = startValue; x <= stopValue; i++, x++)
            {
                Console.WriteLine("|{0,5}     | {1,8}  |", x, resultArray[i]);
            }
            
            Console.WriteLine("+----------+-----------+");
            
            Console.WriteLine();
            Console.WriteLine("Значения функции, занесенные в массив:");
            Console.WriteLine($"{{ {string.Join("; ", resultArray)} }}");
            
            Console.ReadLine();
        }
    }
}