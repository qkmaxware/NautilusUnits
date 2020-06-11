using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Qkmaxware.Units;
using Qkmaxware.Units.MagneticFlux;

namespace TestSuites.Qkmaxware.Units {
    [TestClass]
    public class MagneticFluxTest {
            [TestMethod]
        public void TeslaConversions() {
            var m = 1.T();

            Assert.AreEqual(1e-24,     m.ToYottaTesla().Value);
            Assert.AreEqual(1e-21,     m.ToZettaTesla().Value);
            Assert.AreEqual(1e-18,     m.ToExaTesla().Value);
            Assert.AreEqual(1e-15,     m.ToPetaTesla().Value);
            Assert.AreEqual(1e-12,     m.ToTeraTesla().Value);
            Assert.AreEqual(1e-9,      m.ToGigaTesla().Value);
            Assert.AreEqual(1e-6,      m.ToMegaTesla().Value);
            Assert.AreEqual(1e-3,      m.ToKiloTesla().Value);
            Assert.AreEqual(1e-2,      m.ToHectoTesla().Value);
            Assert.AreEqual(1e-1,      m.ToDekaTesla().Value);

            Assert.AreEqual(1e1,       m.ToDeciTesla().Value);
            Assert.AreEqual(1e2,       m.ToCentiTesla().Value);
            Assert.AreEqual(1e3,       m.ToMilliTesla().Value);
            Assert.AreEqual(1e6,       m.ToMicroTesla().Value);
            Assert.AreEqual(1e9,       m.ToNanoTesla().Value);
            Assert.AreEqual(1e12,      m.ToPicoTesla().Value);
            Assert.AreEqual(1e15,      m.ToFemtoTesla().Value);
            Assert.AreEqual(1e18,      m.ToAttoTesla().Value);
            Assert.AreEqual(1e21,      m.ToZeptoTesla().Value);
            Assert.AreEqual(1e24,      m.ToYoctoTesla().Value);
        }
    }
}
