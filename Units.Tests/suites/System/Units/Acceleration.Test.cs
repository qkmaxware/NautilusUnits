using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Units;
using System.Units.Acceleration;

namespace TestSuites.System.Units {
    [TestClass]
    public class AccelerationTest {
        [TestMethod]
        public void MetrePerSecondSqConversions() {
            var m = 1.m_s2();

            Assert.AreEqual(1e-24,     m.ToYottaMetrePerSecondSq().Value);
            Assert.AreEqual(1e-21,     m.ToZettaMetrePerSecondSq().Value);
            Assert.AreEqual(1e-18,     m.ToExaMetrePerSecondSq().Value);
            Assert.AreEqual(1e-15,     m.ToPetaMetrePerSecondSq().Value);
            Assert.AreEqual(1e-12,     m.ToTeraMetrePerSecondSq().Value);
            Assert.AreEqual(1e-9,      m.ToGigaMetrePerSecondSq().Value);
            Assert.AreEqual(1e-6,      m.ToMegaMetrePerSecondSq().Value);
            Assert.AreEqual(1e-3,      m.ToKiloMetrePerSecondSq().Value);
            Assert.AreEqual(1e-2,      m.ToHectoMetrePerSecondSq().Value);
            Assert.AreEqual(1e-1,      m.ToDekaMetrePerSecondSq().Value);

            Assert.AreEqual(1e1,       m.ToDeciMetrePerSecondSq().Value);
            Assert.AreEqual(1e2,       m.ToCentiMetrePerSecondSq().Value);
            Assert.AreEqual(1e3,       m.ToMilliMetrePerSecondSq().Value);
            Assert.AreEqual(1e6,       m.ToMicroMetrePerSecondSq().Value);
            Assert.AreEqual(1e9,       m.ToNanoMetrePerSecondSq().Value);
            Assert.AreEqual(1e12,      m.ToPicoMetrePerSecondSq().Value);
            Assert.AreEqual(1e15,      m.ToFemtoMetrePerSecondSq().Value);
            Assert.AreEqual(1e18,      m.ToAttoMetrePerSecondSq().Value);
            Assert.AreEqual(1e21,      m.ToZeptoMetrePerSecondSq().Value);
            Assert.AreEqual(1e24,      m.ToYoctoMetrePerSecondSq().Value);
        }

        [TestMethod]
        public void GConversions() {
            var x = 1.g();
            var y = 9.8.m_s2();

            Assert.AreEqual(9.8, x.ToMetrePerSecondSq().Value, 0.1);
            Assert.AreEqual(1, y.ToG().Value, 0.1);
        }
    }
}
