using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Qkmaxware.Units;
using Qkmaxware.Units.Conductance;

namespace TestSuites.Qkmaxware.Units {
    [TestClass]
    public class ConductanceTest {
        [TestMethod]
        public void SiemenConversions() {
            var m = 1.As<Siemen, int>();

            Assert.AreEqual(1e-24,     m.ToYottaSiemen().Value);
            Assert.AreEqual(1e-21,     m.ToZettaSiemen().Value);
            Assert.AreEqual(1e-18,     m.ToExaSiemen().Value);
            Assert.AreEqual(1e-15,     m.ToPetaSiemen().Value);
            Assert.AreEqual(1e-12,     m.ToTeraSiemen().Value);
            Assert.AreEqual(1e-9,      m.ToGigaSiemen().Value);
            Assert.AreEqual(1e-6,      m.ToMegaSiemen().Value);
            Assert.AreEqual(1e-3,      m.ToKiloSiemen().Value);
            Assert.AreEqual(1e-2,      m.ToHectoSiemen().Value);
            Assert.AreEqual(1e-1,      m.ToDekaSiemen().Value);

            Assert.AreEqual(1e1,       m.ToDeciSiemen().Value);
            Assert.AreEqual(1e2,       m.ToCentiSiemen().Value);
            Assert.AreEqual(1e3,       m.ToMilliSiemen().Value);
            Assert.AreEqual(1e6,       m.ToMicroSiemen().Value);
            Assert.AreEqual(1e9,       m.ToNanoSiemen().Value);
            Assert.AreEqual(1e12,      m.ToPicoSiemen().Value);
            Assert.AreEqual(1e15,      m.ToFemtoSiemen().Value);
            Assert.AreEqual(1e18,      m.ToAttoSiemen().Value);
            Assert.AreEqual(1e21,      m.ToZeptoSiemen().Value);
            Assert.AreEqual(1e24,      m.ToYoctoSiemen().Value);
        }
    }
}
