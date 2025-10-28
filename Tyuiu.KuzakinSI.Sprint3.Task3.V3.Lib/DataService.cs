using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KuzakinSI.Sprint3.Task3.V3.Lib
{
    public class DataService : ISprint3Task3V3
    {
        public int GetMinCharCount(string value, char item)
        {
            int minCount = int.MaxValue;
            int currentCount = 0;

            foreach (char c in value)
            {
                if (c == item)
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > 0 && currentCount < minCount)
                    {
                        minCount = currentCount;
                    }
                    currentCount = 0;
                }
            }

            // Проверяем последовательность в конце строки
            if (currentCount > 0 && currentCount < minCount)
            {
                minCount = currentCount;
            }

            return minCount == int.MaxValue ? 0 : minCount;
        }
    }
}