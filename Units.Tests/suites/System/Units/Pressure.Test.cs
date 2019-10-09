using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Units;
using System.Units.Pressure;

namespace TestSuites.System.Units {
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
    }
}
