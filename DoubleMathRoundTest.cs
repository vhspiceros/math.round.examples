using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace math.round.examples.Double {

    [TestClass]
    public class DoubleMathRoundTest {
        /// <summary>
        /// Por defecto cuando es un .5 no redonde hacia arriba.
        /// </summary>
        [TestMethod]

        public void DefaultMathRoundTest1() {
            double number = 123.12345;
            Assert.AreEqual(123.1234, Math.Round(number, 4));
        }

        /// <summary>
        /// Por defecto cuando es un .6 o mayor redonde hacia arriba.
        /// </summary>
        [TestMethod]
        public void DefaultMathRoundTest2() {
            double number = 123.12346;
            Assert.AreEqual(123.1235, Math.Round(number, 4));
        }

        /// <summary>
        /// Por defecto cuando es un .4 o mayor redonde hacia arriba.
        /// </summary>
        [TestMethod]
        public void DefaultMathRoundTest3() {
            double number = 123.12344;
            Assert.AreEqual(123.1234, Math.Round(number, 4));
        }

        [TestMethod]
        public void AwayFromZeroMathRountTest1() {
            double number = 123.12346;
            Assert.AreEqual(123.1235, Math.Round(number, 4, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void AwayFromZeroMathRountTest2() {
            double number = 123.12345;
            Assert.AreEqual(123.1235, Math.Round(number, 4, MidpointRounding.AwayFromZero));
        }
        [TestMethod]
        public void AwayFromZeroMathRountTest3() {
            double number = 123.12344;
            Assert.AreEqual(123.1234, Math.Round(number, 4, MidpointRounding.AwayFromZero));
        }
    }
}
