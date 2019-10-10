using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Units;
using System.Units.Resistance;

namespace TestSuites.System.Units {
    [TestClass]
    public class ResistanceTest {
        [TestMethod]
        public void OhmConversions() {
            var m = 1.As<Ohm, int>();

            Assert.AreEqual(1e-24,     m.ToYottaOhm().Value);
            Assert.AreEqual(1e-21,     m.ToZettaOhm().Value);
            Assert.AreEqual(1e-18,     m.ToExaOhm().Value);
            Assert.AreEqual(1e-15,     m.ToPetaOhm().Value);
            Assert.AreEqual(1e-12,     m.ToTeraOhm().Value);
            Assert.AreEqual(1e-9,      m.ToGigaOhm().Value);
            Assert.AreEqual(1e-6,      m.ToMegaOhm().Value);
            Assert.AreEqual(1e-3,      m.ToKiloOhm().Value);
            Assert.AreEqual(1e-2,      m.ToHectoOhm().Value);
            Assert.AreEqual(1e-1,      m.ToDekaOhm().Value);

            Assert.AreEqual(1e1,       m.ToDeciOhm().Value);
            Assert.AreEqual(1e2,       m.ToCentiOhm().Value);
            Assert.AreEqual(1e3,       m.ToMilliOhm().Value);
            Assert.AreEqual(1e6,       m.ToMicroOhm().Value);
            Assert.AreEqual(1e9,       m.ToNanoOhm().Value);
            Assert.AreEqual(1e12,      m.ToPicoOhm().Value);
            Assert.AreEqual(1e15,      m.ToFemtoOhm().Value);
            Assert.AreEqual(1e18,      m.ToAttoOhm().Value);
            Assert.AreEqual(1e21,      m.ToZeptoOhm().Value);
            Assert.AreEqual(1e24,      m.ToYoctoOhm().Value);
        }
    }
}
