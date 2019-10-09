using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Units;
using System.Units.Power;

namespace TestSuites.System.Units {
    [TestClass]
    public class PowerTest {
        [TestMethod]
        public void WattConversions() {
            var m = 1.W();

            Assert.AreEqual(1e-24,     m.ToYottaWatt().Value);
            Assert.AreEqual(1e-21,     m.ToZettaWatt().Value);
            Assert.AreEqual(1e-18,     m.ToExaWatt().Value);
            Assert.AreEqual(1e-15,     m.ToPetaWatt().Value);
            Assert.AreEqual(1e-12,     m.ToTeraWatt().Value);
            Assert.AreEqual(1e-9,      m.ToGigaWatt().Value);
            Assert.AreEqual(1e-6,      m.ToMegaWatt().Value);
            Assert.AreEqual(1e-3,      m.ToKiloWatt().Value);
            Assert.AreEqual(1e-2,      m.ToHectoWatt().Value);
            Assert.AreEqual(1e-1,      m.ToDekaWatt().Value);

            Assert.AreEqual(1e1,       m.ToDeciWatt().Value);
            Assert.AreEqual(1e2,       m.ToCentiWatt().Value);
            Assert.AreEqual(1e3,       m.ToMilliWatt().Value);
            Assert.AreEqual(1e6,       m.ToMicroWatt().Value);
            Assert.AreEqual(1e9,       m.ToNanoWatt().Value);
            Assert.AreEqual(1e12,      m.ToPicoWatt().Value);
            Assert.AreEqual(1e15,      m.ToFemtoWatt().Value);
            Assert.AreEqual(1e18,      m.ToAttoWatt().Value);
            Assert.AreEqual(1e21,      m.ToZeptoWatt().Value);
            Assert.AreEqual(1e24,      m.ToYoctoWatt().Value);
        }
    }
}
