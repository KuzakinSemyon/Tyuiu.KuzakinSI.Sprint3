using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint3.Task7.V10.Lib;

namespace Tyuiu.KuzakinSI.Sprint3.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            
            int startValue = -5;
            int stopValue = 5;
            
            double[] result = ds.GetMassFunction(startValue, stopValue);
            double[] wait = {
                -12.76, -10.47, -7.74, -6.79, -3.98, -2, 0.79, 3.36, 5.97, 8.43, 10.63
            };
            
            CollectionAssert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetMassFunctionSingleValue()
        {
            DataService ds = new DataService();
            
            int startValue = 0;
            int stopValue = 0;
            
            double[] result = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { -2 };
            
            CollectionAssert.AreEqual(wait, result);
        }
    }
}