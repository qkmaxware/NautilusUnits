using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Qkmaxware.Units;
using Qkmaxware.Units.Pressure;

namespace TestSuites.Qkmaxware.Units {
    [TestClass]
    public class PressureTest {
        [TestMethod]
        public void PascalConversions() {
            var m = 1.Pa();

            Assert.AreEqual(1e-24,     m.ToYottaPascal().Value);
            Assert.AreEqual(1e-21,     m.ToZettaPascal().Value);
            Assert.AreEqual(1e-18,     m.ToExaPascal().Value);
            Assert.AreEqual(1e-15,     m.ToPetaPascal().Value);
            Assert.AreEqual(1e-12,     m.ToTeraPascal().Value);
            Assert.AreEqual(1e-9,      m.ToGigaPascal().Value);
            Assert.AreEqual(1e-6,      m.ToMegaPascal().Value);
            Assert.AreEqual(1e-3,      m.ToKiloPascal().Value);
            Assert.AreEqual(1e-2,      m.ToHectoPascal().Value);
            Assert.AreEqual(1e-1,      m.ToDekaPascal().Value);

            Assert.AreEqual(1e1,       m.ToDeciPascal().Value);
            Assert.AreEqual(1e2,       m.ToCentiPascal().Value);
            Assert.AreEqual(1e3,       m.ToMilliPascal().Value);
            Assert.AreEqual(1e6,       m.ToMicroPascal().Value);
            Assert.AreEqual(1e9,       m.ToNanoPascal().Value);
            Assert.AreEqual(1e12,      m.ToPicoPascal().Value);
            Assert.AreEqual(1e15,      m.ToFemtoPascal().Value);
            Assert.AreEqual(1e18,      m.ToAttoPascal().Value);
            Assert.AreEqual(1e21,      m.ToZeptoPascal().Value);
            Assert.AreEqual(1e24,      m.ToYoctoPascal().Value);
        }

        [TestMethod]
        public void BarConversions() {
            var m = 1.bar();

            Assert.AreEqual(1e-24,     m.ToYottaBar().Value);
            Assert.AreEqual(1e-21,     m.ToZettaBar().Value);
            Assert.AreEqual(1e-18,     m.ToExaBar().Value);
            Assert.AreEqual(1e-15,     m.ToPetaBar().Value);
            Assert.AreEqual(1e-12,     m.ToTeraBar().Value);
            Assert.AreEqual(1e-9,      m.ToGigaBar().Value);
            Assert.AreEqual(1e-6,      m.ToMegaBar().Value);
            Assert.AreEqual(1e-3,      m.ToKiloBar().Value);
            Assert.AreEqual(1e-2,      m.ToHectoBar().Value);
            Assert.AreEqual(1e-1,      m.ToDekaBar().Value);

            Assert.AreEqual(1e1,       m.ToDeciBar().Value);
            Assert.AreEqual(1e2,       m.ToCentiBar().Value);
            Assert.AreEqual(1e3,       m.ToMilliBar().Value);
            Assert.AreEqual(1e6,       m.ToMicroBar().Value);
            Assert.AreEqual(1e9,       m.ToNanoBar().Value);
            Assert.AreEqual(1e12,      m.ToPicoBar().Value);
            Assert.AreEqual(1e15,      m.ToFemtoBar().Value);
            Assert.AreEqual(1e18,      m.ToAttoBar().Value);
            Assert.AreEqual(1e21,      m.ToZeptoBar().Value);
            Assert.AreEqual(1e24,      m.ToYoctoBar().Value);
        }

        [TestMethod]
        public void PascalBarConversions() {
            var pa = 1.Pa();
            var br = 1.bar();

            // Base conversions
            Assert.AreEqual(100000, br.ToPascal().Value, 0.01);
            Assert.AreEqual(1e-5, pa.ToBar().Value, 0.01);

            // Up/down conversions
            Assert.AreEqual(1e+7, br.ToCentiPascal().Value, 0.01);
            Assert.AreEqual(100, br.ToKiloPascal().Value, 0.01);

            Assert.AreEqual(0.001, pa.ToCentiBar().Value, 0.01);
            Assert.AreEqual(1e-8, pa.ToKiloBar().Value, 0.01);
        }
    }
}
