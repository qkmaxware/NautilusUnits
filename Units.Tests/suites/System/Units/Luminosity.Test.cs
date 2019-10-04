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

            Assert.AreEqual(1e-24,     m.ToYottacandela().Value);
            Assert.AreEqual(1e-21,     m.ToZettacandela().Value);
            Assert.AreEqual(1e-18,     m.ToExacandela().Value);
            Assert.AreEqual(1e-15,     m.ToPetacandela().Value);
            Assert.AreEqual(1e-12,     m.ToTeracandela().Value);
            Assert.AreEqual(1e-9,      m.ToGigacandela().Value);
            Assert.AreEqual(1e-6,      m.ToMegacandela().Value);
            Assert.AreEqual(1e-3,      m.ToKilocandela().Value);
            Assert.AreEqual(1e-2,      m.ToHectocandela().Value);
            Assert.AreEqual(1e-1,      m.ToDekacandela().Value);

            Assert.AreEqual(1e1,       m.ToDecicandela().Value);
            Assert.AreEqual(1e2,       m.ToCenticandela().Value);
            Assert.AreEqual(1e3,       m.ToMillicandela().Value);
            Assert.AreEqual(1e6,       m.ToMicrocandela().Value);
            Assert.AreEqual(1e9,       m.ToNanocandela().Value);
            Assert.AreEqual(1e12,      m.ToPicocandela().Value);
            Assert.AreEqual(1e15,      m.ToFemtocandela().Value);
            Assert.AreEqual(1e18,      m.ToAttocandela().Value);
            Assert.AreEqual(1e21,      m.ToZeptocandela().Value);
            Assert.AreEqual(1e24,      m.ToYoctocandela().Value);
        }
    }
}
