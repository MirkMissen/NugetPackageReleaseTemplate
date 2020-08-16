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
        //[Ignore("Must fail; testing that CI can catch it...")]
        public void FailingTest() {
            var calculator = new Calculator.Calculator();
            Assert.IsTrue(calculator.Add(2, 2) == 5);
        }

    }
}
