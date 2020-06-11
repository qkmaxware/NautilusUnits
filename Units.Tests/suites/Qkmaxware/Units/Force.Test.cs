using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Qkmaxware.Units;
using Qkmaxware.Units.Force;

namespace TestSuites.Qkmaxware.Units {
    [TestClass]
    public class ForceTest {
        [TestMethod]
        public void NewtonConversions() {
            var m = 1.N();

            Assert.AreEqual(1e-24,     m.ToYottaNewton().Value);
            Assert.AreEqual(1e-21,     m.ToZettaNewton().Value);
            Assert.AreEqual(1e-18,     m.ToExaNewton().Value);
            Assert.AreEqual(1e-15,     m.ToPetaNewton().Value);
            Assert.AreEqual(1e-12,     m.ToTeraNewton().Value);
            Assert.AreEqual(1e-9,      m.ToGigaNewton().Value);
            Assert.AreEqual(1e-6,      m.ToMegaNewton().Value);
            Assert.AreEqual(1e-3,      m.ToKiloNewton().Value);
            Assert.AreEqual(1e-2,      m.ToHectoNewton().Value);
            Assert.AreEqual(1e-1,      m.ToDekaNewton().Value);

            Assert.AreEqual(1e1,       m.ToDeciNewton().Value);
            Assert.AreEqual(1e2,       m.ToCentiNewton().Value);
            Assert.AreEqual(1e3,       m.ToMilliNewton().Value);
            Assert.AreEqual(1e6,       m.ToMicroNewton().Value);
            Assert.AreEqual(1e9,       m.ToNanoNewton().Value);
            Assert.AreEqual(1e12,      m.ToPicoNewton().Value);
            Assert.AreEqual(1e15,      m.ToFemtoNewton().Value);
            Assert.AreEqual(1e18,      m.ToAttoNewton().Value);
            Assert.AreEqual(1e21,      m.ToZeptoNewton().Value);
            Assert.AreEqual(1e24,      m.ToYoctoNewton().Value);
        }
    }
}
