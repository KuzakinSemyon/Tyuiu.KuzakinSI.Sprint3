using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint3.Task6.V25.Lib;

namespace Tyuiu.KuzakinSI.Sprint3.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            
            int startValue = 16;
            int stopValue = 24;
            
            int result = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 122; // Ожидаемое значение
            
            Assert.AreEqual(wait, result);
        }
    }
}