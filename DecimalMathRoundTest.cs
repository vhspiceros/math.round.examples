using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace math.round.examples {

    [TestClass]
    public class DoubleMathRoundTest {
        /// <summary>
        /// Por defecto cuando es un .5 no redonde hacia arriba.
        /// </summary>
        [TestMethod]

        public void DefaultMathRoundTest1() {
            decimal number = 123.12345M;
            Assert.AreEqual(123.1234M, Math.Round(number, 4));
        }

        /// <summary>
        /// Por defecto cuando es un .6 o mayor redonde hacia arriba.
        /// </summary>
        [TestMethod]
        public void DefaultMathRoundTest2() {
            decimal number = 123.12346m;
            Assert.AreEqual(123.1235M, Math.Round(number, 4));
        }

        /// <summary>
        /// Por defecto cuando es un .4 o mayor redonde hacia arriba.
        /// </summary>
        [TestMethod]
        public void DefaultMathRoundTest3() {
            decimal number = 123.12344m;
            Assert.AreEqual(123.1234M, Math.Round(number, 4));
        }

        [TestMethod]
        public void AwayFromZeroMathRountTest1() {
            decimal number;
            number = 123.12346M;
            Assert.AreEqual(123.1235M, Math.Round(number, 4, MidpointRounding.AwayFromZero));
        }

        [TestMethod]
        public void AwayFromZeroMathRountTest2() {
            decimal number;
            number = 123.12345M;
            Assert.AreEqual(123.1235M, Math.Round(number, 4, MidpointRounding.AwayFromZero));
        }
        [TestMethod]
        public void AwayFromZeroMathRountTest3() {
            decimal number;
            number = 123.12344M;
            Assert.AreEqual(123.1234M, Math.Round(number, 4, MidpointRounding.AwayFromZero));
        }
    }
}
