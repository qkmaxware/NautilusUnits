using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Qkmaxware.Units;
using Qkmaxware.Units.Length;

namespace TestSuites.Qkmaxware.Units {
    [TestClass]
    public class LengthTest {
        [TestMethod]
        public void MetreConversions() {
            var m = 1.m();
            var km = 1.km();

            Assert.AreEqual(1000,     km.ToMetre().Value);

            Assert.AreEqual(1e-24,     m.ToYottaMetre().Value);
            Assert.AreEqual(1e-21,     m.ToZettaMetre().Value);
            Assert.AreEqual(1e-18,     m.ToExaMetre().Value);
            Assert.AreEqual(1e-15,     m.ToPetaMetre().Value);
            Assert.AreEqual(1e-12,     m.ToTeraMetre().Value);
            Assert.AreEqual(1e-9,      m.ToGigaMetre().Value);
            Assert.AreEqual(1e-6,      m.ToMegaMetre().Value);
            Assert.AreEqual(1e-3,      m.ToKiloMetre().Value);
            Assert.AreEqual(1e-2,      m.ToHectoMetre().Value);
            Assert.AreEqual(1e-1,      m.ToDekaMetre().Value);

            Assert.AreEqual(1e1,       m.ToDeciMetre().Value);
            Assert.AreEqual(1e2,       m.ToCentiMetre().Value);
            Assert.AreEqual(1e3,       m.ToMilliMetre().Value);
            Assert.AreEqual(1e6,       m.ToMicroMetre().Value);
            Assert.AreEqual(1e9,       m.ToNanoMetre().Value);
            Assert.AreEqual(1e12,      m.ToPicoMetre().Value);
            Assert.AreEqual(1e15,      m.ToFemtoMetre().Value);
            Assert.AreEqual(1e18,      m.ToAttoMetre().Value);
            Assert.AreEqual(1e21,      m.ToZeptoMetre().Value);
            Assert.AreEqual(1e24,      m.ToYoctoMetre().Value);
        }

        [TestMethod]
        public void MileConversions() {
            var x = 1.mi();

            Assert.AreEqual(63360, x.ToInch().Value);
            Assert.AreEqual(5280, x.ToFoot().Value);
            Assert.AreEqual(1760, x.ToYard().Value);
            Assert.AreEqual(0.289659, x.ToLeague().Value);

            Assert.AreEqual(1, 36.As<Inch, int>().ToYard().Value);
        }
    }
}
