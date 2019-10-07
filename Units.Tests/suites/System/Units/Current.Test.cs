using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Units;
using System.Units.Current;

namespace TestSuites.System.Units {
    [TestClass]
    public class CurrentTest {
            [TestMethod]
        public void AmpereConversions() {
            var m = 1.A();

            Assert.AreEqual(1e-24,     m.ToYottaAmpere().Value);
            Assert.AreEqual(1e-21,     m.ToZettaAmpere().Value);
            Assert.AreEqual(1e-18,     m.ToExaAmpere().Value);
            Assert.AreEqual(1e-15,     m.ToPetaAmpere().Value);
            Assert.AreEqual(1e-12,     m.ToTeraAmpere().Value);
            Assert.AreEqual(1e-9,      m.ToGigaAmpere().Value);
            Assert.AreEqual(1e-6,      m.ToMegaAmpere().Value);
            Assert.AreEqual(1e-3,      m.ToKiloAmpere().Value);
            Assert.AreEqual(1e-2,      m.ToHectoAmpere().Value);
            Assert.AreEqual(1e-1,      m.ToDekaAmpere().Value);

            Assert.AreEqual(1e1,       m.ToDeciAmpere().Value);
            Assert.AreEqual(1e2,       m.ToCentiAmpere().Value);
            Assert.AreEqual(1e3,       m.ToMilliAmpere().Value);
            Assert.AreEqual(1e6,       m.ToMicroAmpere().Value);
            Assert.AreEqual(1e9,       m.ToNanoAmpere().Value);
            Assert.AreEqual(1e12,      m.ToPicoAmpere().Value);
            Assert.AreEqual(1e15,      m.ToFemtoAmpere().Value);
            Assert.AreEqual(1e18,      m.ToAttoAmpere().Value);
            Assert.AreEqual(1e21,      m.ToZeptoAmpere().Value);
            Assert.AreEqual(1e24,      m.ToYoctoAmpere().Value);
        }
    }
}
