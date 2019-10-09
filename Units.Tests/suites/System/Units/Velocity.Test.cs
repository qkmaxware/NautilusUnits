using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Units;
using System.Units.Velocity;

namespace TestSuites.System.Units {
    [TestClass]
    public class VelocityTest {
        [TestMethod]
        public void MetrePerSecondConversions() {
            var m = 1.m_s();

            Assert.AreEqual(1e-24,     m.ToYottaMetrePerSecond().Value);
            Assert.AreEqual(1e-21,     m.ToZettaMetrePerSecond().Value);
            Assert.AreEqual(1e-18,     m.ToExaMetrePerSecond().Value);
            Assert.AreEqual(1e-15,     m.ToPetaMetrePerSecond().Value);
            Assert.AreEqual(1e-12,     m.ToTeraMetrePerSecond().Value);
            Assert.AreEqual(1e-9,      m.ToGigaMetrePerSecond().Value);
            Assert.AreEqual(1e-6,      m.ToMegaMetrePerSecond().Value);
            Assert.AreEqual(1e-3,      m.ToKiloMetrePerSecond().Value);
            Assert.AreEqual(1e-2,      m.ToHectoMetrePerSecond().Value);
            Assert.AreEqual(1e-1,      m.ToDekaMetrePerSecond().Value);

            Assert.AreEqual(1e1,       m.ToDeciMetrePerSecond().Value);
            Assert.AreEqual(1e2,       m.ToCentiMetrePerSecond().Value);
            Assert.AreEqual(1e3,       m.ToMilliMetrePerSecond().Value);
            Assert.AreEqual(1e6,       m.ToMicroMetrePerSecond().Value);
            Assert.AreEqual(1e9,       m.ToNanoMetrePerSecond().Value);
            Assert.AreEqual(1e12,      m.ToPicoMetrePerSecond().Value);
            Assert.AreEqual(1e15,      m.ToFemtoMetrePerSecond().Value);
            Assert.AreEqual(1e18,      m.ToAttoMetrePerSecond().Value);
            Assert.AreEqual(1e21,      m.ToZeptoMetrePerSecond().Value);
            Assert.AreEqual(1e24,      m.ToYoctoMetrePerSecond().Value);
        }
    }
}
