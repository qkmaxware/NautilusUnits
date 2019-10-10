using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Units;
using System.Units.ElectricPotential;

namespace TestSuites.System.Units {
    [TestClass]
    public class ElectricPotentialTest {
        [TestMethod]
        public void VoltConversions() {
            var m = 1.V();

            Assert.AreEqual(1e-24,     m.ToYottaVolt().Value);
            Assert.AreEqual(1e-21,     m.ToZettaVolt().Value);
            Assert.AreEqual(1e-18,     m.ToExaVolt().Value);
            Assert.AreEqual(1e-15,     m.ToPetaVolt().Value);
            Assert.AreEqual(1e-12,     m.ToTeraVolt().Value);
            Assert.AreEqual(1e-9,      m.ToGigaVolt().Value);
            Assert.AreEqual(1e-6,      m.ToMegaVolt().Value);
            Assert.AreEqual(1e-3,      m.ToKiloVolt().Value);
            Assert.AreEqual(1e-2,      m.ToHectoVolt().Value);
            Assert.AreEqual(1e-1,      m.ToDekaVolt().Value);

            Assert.AreEqual(1e1,       m.ToDeciVolt().Value);
            Assert.AreEqual(1e2,       m.ToCentiVolt().Value);
            Assert.AreEqual(1e3,       m.ToMilliVolt().Value);
            Assert.AreEqual(1e6,       m.ToMicroVolt().Value);
            Assert.AreEqual(1e9,       m.ToNanoVolt().Value);
            Assert.AreEqual(1e12,      m.ToPicoVolt().Value);
            Assert.AreEqual(1e15,      m.ToFemtoVolt().Value);
            Assert.AreEqual(1e18,      m.ToAttoVolt().Value);
            Assert.AreEqual(1e21,      m.ToZeptoVolt().Value);
            Assert.AreEqual(1e24,      m.ToYoctoVolt().Value);
        }
    }
}
