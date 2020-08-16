using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests {
    [TestClass]
    public class CaclculatorTests {

        [TestMethod]
        public void SuccessTest() {
            var calculator = new Calculator.Calculator();
            Assert.IsTrue(calculator.Add(2, 2) == 4);
        }

        [TestMethod]
        public void FailingTest() {
            var calculator = new Calculator.Calculator();
            Assert.IsTrue(calculator.Add(2, 2) == 5);
        }

    }
}
