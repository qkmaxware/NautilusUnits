using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Qkmaxware.Units;
using Qkmaxware.Units.Mass;

namespace TestSuites.Qkmaxware.Units {
    [TestClass]
    public class MassTest {
        [TestMethod]
        public void GramConversions() {
            var m = 1.g();

            Assert.AreEqual(1e-24,     m.ToYottaGram().Value);
            Assert.AreEqual(1e-21,     m.ToZettaGram().Value);
            Assert.AreEqual(1e-18,     m.ToExaGram().Value);
            Assert.AreEqual(1e-15,     m.ToPetaGram().Value);
            Assert.AreEqual(1e-12,     m.ToTeraGram().Value);
            Assert.AreEqual(1e-9,      m.ToGigaGram().Value);
            Assert.AreEqual(1e-6,      m.ToMegaGram().Value);
            Assert.AreEqual(1e-3,      m.ToKiloGram().Value);
            Assert.AreEqual(1e-2,      m.ToHectoGram().Value);
            Assert.AreEqual(1e-1,      m.ToDekaGram().Value);

            Assert.AreEqual(1e1,       m.ToDeciGram().Value);
            Assert.AreEqual(1e2,       m.ToCentiGram().Value);
            Assert.AreEqual(1e3,       m.ToMilliGram().Value);
            Assert.AreEqual(1e6,       m.ToMicroGram().Value);
            Assert.AreEqual(1e9,       m.ToNanoGram().Value);
            Assert.AreEqual(1e12,      m.ToPicoGram().Value);
            Assert.AreEqual(1e15,      m.ToFemtoGram().Value);
            Assert.AreEqual(1e18,      m.ToAttoGram().Value);
            Assert.AreEqual(1e21,      m.ToZeptoGram().Value);
            Assert.AreEqual(1e24,      m.ToYoctoGram().Value);
        }
    }
}
