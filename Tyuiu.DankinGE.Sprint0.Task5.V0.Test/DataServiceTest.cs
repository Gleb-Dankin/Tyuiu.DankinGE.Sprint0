using Tyuiu.DankinGE.Sprint0.Task5.V0.Lib;

namespace Tyuiu.DankinGE.Sprint0.Task5.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod] public void CheckAdditionValid() { Assert.AreEqual(10, DataService.Addition(5, 5)); }
        [TestMethod] public void CheckSubtractionValid() { Assert.AreEqual(5, DataService.Subtraction(10, 5)); }
        [TestMethod] public void CheckMultiplicationValid() { Assert.AreEqual(25, DataService.Multiplication(5, 5)); }
        
        [TestMethod]
        public void CheckDivisionValid()
        {
            Assert.AreEqual(2, DataService.Division(10, 5));
        }
        // деление на ноль
        [TestMethod]
        public void CheckDivisionByZeroValid()
        {
            Assert.AreEqual(-1, DataService.Division(10, 0));
        }
    }
}