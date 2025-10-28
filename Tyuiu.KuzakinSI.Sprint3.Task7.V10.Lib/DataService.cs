using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KuzakinSI.Sprint3.Task7.V10.Lib
{
    public class DataService : ISprint3Task7V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] resultArray = new double[length];

            for (int x = startValue, index = 0; x <= stopValue; x++, index++)
            {
                double denominator = Math.Sin(x) + 3;

                // Проверка деления на ноль
                if (Math.Abs(denominator) < 0.0001) // Учитываем погрешность вычислений
                {
                    resultArray[index] = 0;
                }
                else
                {
                    double numerator = 5 * x + 2.5;
                    double value = numerator / denominator + 2 * x + Math.Cos(x);
                    resultArray[index] = Math.Round(value, 2);
                }
            }

            return resultArray;
        }
    }
}