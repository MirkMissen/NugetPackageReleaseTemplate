using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests {
    [TestClass]
    public class CaclculatorTests {

        [TestMethod]
        public void TestMethod1() {
            var calculator = new Calculator.Calculator();
            Assert.IsTrue(calculator.Add(2, 2) == 4);
        }

    }
}
