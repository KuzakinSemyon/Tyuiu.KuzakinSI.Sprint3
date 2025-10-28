using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KuzakinSI.Sprint3.Task0.V0.Lib
{
    public class DataService : ISprint3Task0V0
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                double term = (Math.Pow(value, k) + 0.25) * Math.Sin(k);
                sum += term;
            }
            return Math.Round(sum, 3);
        }
    }
}