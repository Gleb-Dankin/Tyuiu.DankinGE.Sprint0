using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DankinGE.Sprint0.Task3.V0.Lib;

namespace Tyuiu.DankinGE.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSumValid()
        {
            int a = 5;
            int b = 5;
            int expected = 10;
            int actual = DataService.Sum(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}