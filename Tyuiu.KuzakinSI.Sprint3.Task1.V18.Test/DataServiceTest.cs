using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint3.Task1.V18.Lib;

namespace Tyuiu.KuzakinSI.Sprint3.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            
            int startValue = 1;
            int stopValue = 15;
            
            double result = ds.GetSumSeries(startValue, stopValue);
            double wait = 0.385;
            
            Assert.AreEqual(wait, result);
        }
    }
}