using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KuzakinSI.Sprint3.Task4.V8.Lib
{
    public class DataService : ISprint3Task4V8
    {
        public double Calculate(int startValue, int stopValue)
        {
            double product = 1;
            
            for (int x = startValue; x <= stopValue; x++)
            {
                // При x = 0 прерываем цикл
                if (x == 0)
                {
                    break;
                }
                
                // Вычисляем значение функции y = (x/sin(x)) + 0.5
                double y = (x / Math.Sin(x)) + 0.5;
                product *= y;
            }
            
            return Math.Round(product, 3);
        }
    }
}