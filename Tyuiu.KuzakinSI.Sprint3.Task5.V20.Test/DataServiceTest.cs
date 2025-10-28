using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint3.Task5.V20.Lib;

namespace Tyuiu.KuzakinSI.Sprint3.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 6;
            
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = -132767.261;
            
            Assert.AreEqual(wait, result);
        }
    }
}