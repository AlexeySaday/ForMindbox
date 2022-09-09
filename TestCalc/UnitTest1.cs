using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;

namespace TestCalc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double sideA = 12;
            double sideB = 11;
            double sideC = 10;

            double expected = 2654.44;

            double actuale = Fabrica.AddingFigure("Triangle", sideA, sideB, sideC);

            Assert.AreEqual(expected, actuale, 0.01);
        }
    }
}
