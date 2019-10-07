using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Units;
using System.Units.Luminosity;

namespace TestSuites.System.Units {
    [TestClass]
    public class LuminosityTest {
        [TestMethod]
        public void CandelaConversions() {
            var m = 1.cd();

            Assert.AreEqual(1e-24,     m.ToYottaCandela().Value);
            Assert.AreEqual(1e-21,     m.ToZettaCandela().Value);
            Assert.AreEqual(1e-18,     m.ToExaCandela().Value);
            Assert.AreEqual(1e-15,     m.ToPetaCandela().Value);
            Assert.AreEqual(1e-12,     m.ToTeraCandela().Value);
            Assert.AreEqual(1e-9,      m.ToGigaCandela().Value);
            Assert.AreEqual(1e-6,      m.ToMegaCandela().Value);
            Assert.AreEqual(1e-3,      m.ToKiloCandela().Value);
            Assert.AreEqual(1e-2,      m.ToHectoCandela().Value);
            Assert.AreEqual(1e-1,      m.ToDekaCandela().Value);

            Assert.AreEqual(1e1,       m.ToDeciCandela().Value);
            Assert.AreEqual(1e2,       m.ToCentiCandela().Value);
            Assert.AreEqual(1e3,       m.ToMilliCandela().Value);
            Assert.AreEqual(1e6,       m.ToMicroCandela().Value);
            Assert.AreEqual(1e9,       m.ToNanoCandela().Value);
            Assert.AreEqual(1e12,      m.ToPicoCandela().Value);
            Assert.AreEqual(1e15,      m.ToFemtoCandela().Value);
            Assert.AreEqual(1e18,      m.ToAttoCandela().Value);
            Assert.AreEqual(1e21,      m.ToZeptoCandela().Value);
            Assert.AreEqual(1e24,      m.ToYoctoCandela().Value);
        }
    }
}
