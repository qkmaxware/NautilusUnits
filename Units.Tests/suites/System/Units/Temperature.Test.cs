using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Units;
using System.Units.Temperature;

namespace TestSuites.System.Units {
    [TestClass]
    public class TemperatureTest {
        [TestMethod]
        public void CelciusConversions() {
            var c = 0.degC();

            Assert.AreEqual(32,         c.ToFahrenheit().Value, 0.01);
            Assert.AreEqual(273.15,     c.ToKelvins().Value, 0.01);
            Assert.AreEqual(491.67,     c.ToRankine().Value, 0.01);
        }

        [TestMethod]
        public void FahrenheitConversions() {
            var c = 32.degF();

            Assert.AreEqual(0,          c.ToCelsius().Value, 0.01);
            Assert.AreEqual(273.15,     c.ToKelvins().Value, 0.01);
            Assert.AreEqual(491.67,     c.ToRankine().Value, 0.01);
        }

        [TestMethod]
        public void KelvinConversions() {
            var c = 273.15.K();

            Assert.AreEqual(32,         c.ToFahrenheit().Value, 0.01);
            Assert.AreEqual(0,          c.ToCelsius().Value, 0.01);
            Assert.AreEqual(491.67,     c.ToRankine().Value, 0.01);
        }

        [TestMethod]
        public void RankineConversions() {
            var c = 491.67.degR();

            Assert.AreEqual(32,         c.ToFahrenheit().Value, 0.01);
            Assert.AreEqual(273.15,     c.ToKelvins().Value, 0.01);
            Assert.AreEqual(0,          c.ToCelsius().Value, 0.01);
        }

    }
}
