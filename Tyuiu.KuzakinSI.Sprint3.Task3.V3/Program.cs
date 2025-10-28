using System;
using Tyuiu.KuzakinSI.Sprint3.Task3.V3.Lib;

namespace Tyuiu.KuzakinSI.Sprint3.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв f,        *");
            Console.WriteLine("* находящихся на соседних позициях в строке: cvbmzff orffgtrr dkfvfffdr   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            string value = "cvbmzff orffgtrr dkfvfffdr";
            char item = 'f';
            
            Console.WriteLine($"Исходная строка: {value}");
            Console.WriteLine($"Искомый символ: {item}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            int result = ds.GetMinCharCount(value, item);
            
            Console.WriteLine($"Минимальное количество букв '{item}' на соседних позициях: {result}");
            
            Console.WriteLine();
            Console.WriteLine("Анализ строки:");
            Console.WriteLine("cvbmzff - 2 буквы 'f' подряд");
            Console.WriteLine("orffgtrr - 2 буквы 'f' подряд"); 
            Console.WriteLine("dkfvfffdr - есть одиночная 'f' после 'k' и 3 буквы 'f' подряд");
            Console.WriteLine("Минимальная последовательность: 1 (одиночная 'f')");
            
            Console.ReadLine();
        }
    }
}