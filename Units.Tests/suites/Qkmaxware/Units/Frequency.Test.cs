using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Qkmaxware.Units;
using Qkmaxware.Units.Frequency;

namespace TestSuites.Qkmaxware.Units {
    [TestClass]
    public class FrequencyTest {
        [TestMethod]
        public void HertzConversions() {
            var m = 1.Hz();

            Assert.AreEqual(1e-24,     m.ToYottaHertz().Value);
            Assert.AreEqual(1e-21,     m.ToZettaHertz().Value);
            Assert.AreEqual(1e-18,     m.ToExaHertz().Value);
            Assert.AreEqual(1e-15,     m.ToPetaHertz().Value);
            Assert.AreEqual(1e-12,     m.ToTeraHertz().Value);
            Assert.AreEqual(1e-9,      m.ToGigaHertz().Value);
            Assert.AreEqual(1e-6,      m.ToMegaHertz().Value);
            Assert.AreEqual(1e-3,      m.ToKiloHertz().Value);
            Assert.AreEqual(1e-2,      m.ToHectoHertz().Value);
            Assert.AreEqual(1e-1,      m.ToDekaHertz().Value);

            Assert.AreEqual(1e1,       m.ToDeciHertz().Value);
            Assert.AreEqual(1e2,       m.ToCentiHertz().Value);
            Assert.AreEqual(1e3,       m.ToMilliHertz().Value);
            Assert.AreEqual(1e6,       m.ToMicroHertz().Value);
            Assert.AreEqual(1e9,       m.ToNanoHertz().Value);
            Assert.AreEqual(1e12,      m.ToPicoHertz().Value);
            Assert.AreEqual(1e15,      m.ToFemtoHertz().Value);
            Assert.AreEqual(1e18,      m.ToAttoHertz().Value);
            Assert.AreEqual(1e21,      m.ToZeptoHertz().Value);
            Assert.AreEqual(1e24,      m.ToYoctoHertz().Value);
        }
    }
}
