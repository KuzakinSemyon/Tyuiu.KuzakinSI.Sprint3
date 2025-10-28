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
            bool inSequence = false;

            foreach (char c in value)
            {
                if (c == item)
                {
                    currentCount++;
                    inSequence = true;
                }
                else
                {
                    if (inSequence && currentCount > 1 && currentCount < minCount)
                    {
                        minCount = currentCount;
                    }
                    currentCount = 0;
                    inSequence = false;
                }
            }

            // Проверяем последовательность в конце строки
            if (inSequence && currentCount > 1 && currentCount < minCount)
            {
                minCount = currentCount;
            }

            return minCount == int.MaxValue ? 0 : minCount;
        }
    }
}