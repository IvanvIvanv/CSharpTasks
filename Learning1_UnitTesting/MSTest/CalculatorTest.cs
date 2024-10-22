using CalculatorTask;

namespace MSTestTask
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestSum()
        {
            Assert.AreEqual(3, Calculator.Add(1, 2));
        }
        
        [TestMethod]
        public void TestSub()
        {
            Assert.AreEqual(3, Calculator.Sub(1, 2), "1 - 2 = 3?");
        }
    }
}