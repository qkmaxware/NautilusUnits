
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Units;
using System.Units.Energy;

namespace TestSuites.System.Units {
    [TestClass]
    public class EnergyTest {
        [TestMethod]
        public void MetreConversions() {
            var m = 1.J();

            Assert.AreEqual(1e-24,     m.ToYottaJoule().Value);
            Assert.AreEqual(1e-21,     m.ToZettaJoule().Value);
            Assert.AreEqual(1e-18,     m.ToExaJoule().Value);
            Assert.AreEqual(1e-15,     m.ToPetaJoule().Value);
            Assert.AreEqual(1e-12,     m.ToTeraJoule().Value);
            Assert.AreEqual(1e-9,      m.ToGigaJoule().Value);
            Assert.AreEqual(1e-6,      m.ToMegaJoule().Value);
            Assert.AreEqual(1e-3,      m.ToKiloJoule().Value);
            Assert.AreEqual(1e-2,      m.ToHectoJoule().Value);
            Assert.AreEqual(1e-1,      m.ToDekaJoule().Value);

            Assert.AreEqual(1e1,       m.ToDeciJoule().Value);
            Assert.AreEqual(1e2,       m.ToCentiJoule().Value);
            Assert.AreEqual(1e3,       m.ToMilliJoule().Value);
            Assert.AreEqual(1e6,       m.ToMicroJoule().Value);
            Assert.AreEqual(1e9,       m.ToNanoJoule().Value);
            Assert.AreEqual(1e12,      m.ToPicoJoule().Value);
            Assert.AreEqual(1e15,      m.ToFemtoJoule().Value);
            Assert.AreEqual(1e18,      m.ToAttoJoule().Value);
            Assert.AreEqual(1e21,      m.ToZeptoJoule().Value);
            Assert.AreEqual(1e24,      m.ToYoctoJoule().Value);
        }
    }
}
