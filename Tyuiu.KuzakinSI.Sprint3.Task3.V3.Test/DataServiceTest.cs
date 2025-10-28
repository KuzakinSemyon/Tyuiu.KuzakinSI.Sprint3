using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint3.Task4.V8.Lib;

namespace Tyuiu.KuzakinSI.Sprint3.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            
            int startValue = -5;
            int stopValue = 5;
            
            double result = ds.Calculate(startValue, stopValue);
            double wait = 526767.341; // Ожидаемое значение
            
            Assert.AreEqual(wait, result);
        }
    }
}