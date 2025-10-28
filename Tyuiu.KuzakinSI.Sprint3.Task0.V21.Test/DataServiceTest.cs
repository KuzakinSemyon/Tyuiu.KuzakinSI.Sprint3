using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint3.Task0.V0.Lib;

namespace Tyuiu.KuzakinSI.Sprint3.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            
            double value = 1.5;
            int startValue = 1;
            int stopValue = 13;
            
            double result = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 8735.283;
            
            Assert.AreEqual(wait, result);
        }
    }
}