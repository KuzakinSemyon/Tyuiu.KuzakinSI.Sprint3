using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint3.Task3.V3.Lib;

namespace Tyuiu.KuzakinSI.Sprint3.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();
            
            string value = "cvbmzff orffgtrr dkfvfffdr";
            char item = 'f';
            
            int result = ds.GetMinCharCount(value, item);
            int wait = 2;
            
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetMinCharCountEmpty()
        {
            DataService ds = new DataService();
            
            string value = "abcde";
            char item = 'f';
            
            int result = ds.GetMinCharCount(value, item);
            int wait = 0;
            
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetMinCharCountSingle()
        {
            DataService ds = new DataService();
            
            string value = "f f f";
            char item = 'f';
            
            int result = ds.GetMinCharCount(value, item);
            int wait = 1;
            
            Assert.AreEqual(wait, result);
        }
    }
}