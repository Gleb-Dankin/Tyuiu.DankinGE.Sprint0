using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DankinGE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DankinGE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            string name = "Глеб";
            string res = DataService.GetMessage(name);
            Assert.AreEqual($"Привет, {name}...", res);
        }
    }
}
