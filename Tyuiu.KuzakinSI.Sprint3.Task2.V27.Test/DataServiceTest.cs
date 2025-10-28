using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint3.Task2.V27.Lib;

namespace Tyuiu.KuzakinSI.Sprint3.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            
            int value = 5;
            int startValue = 1;
            int stopValue = 14;
            
            double result = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.8;
            
            Assert.AreEqual(wait, result);
        }
    }
}