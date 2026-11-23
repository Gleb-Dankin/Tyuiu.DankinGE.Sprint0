using Tyuiu.DankinGE.Sprint0.Task4.V0.Lib;

namespace Tyuiu.DankinGE.Sprint0.Task4.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionValid() // Тест на сложение
        {
            // Assert.AreEqual(ожидаемое, фактическое)
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckSubtractionValid() // Тест на вычитание
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void CheckMultiplicationValid() // Тест на умножение
        {
            Assert.AreEqual(25, DataService.Multiplication(5, 5));
        }

        [TestMethod]
        public void CheckDivisionValid() // Тест на деление
        {
            Assert.AreEqual(2, DataService.Division(10, 5));
        }
    }
}
