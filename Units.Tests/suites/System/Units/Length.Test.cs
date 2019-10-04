using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Units;
using System.Units.Length;

namespace TestSuites.System.Units {
    [TestClass]
    public class LengthTest {
        [TestMethod]
        public void MetreConversions() {
            var m = 1.m();

            Assert.AreEqual(1e-24,     m.ToYottametre().Value);
            Assert.AreEqual(1e-21,     m.ToZettametre().Value);
            Assert.AreEqual(1e-18,     m.ToExametre().Value);
            Assert.AreEqual(1e-15,     m.ToPetametre().Value);
            Assert.AreEqual(1e-12,     m.ToTerametre().Value);
            Assert.AreEqual(1e-9,      m.ToGigametre().Value);
            Assert.AreEqual(1e-6,      m.ToMegametre().Value);
            Assert.AreEqual(1e-3,      m.ToKilometre().Value);
            Assert.AreEqual(1e-2,      m.ToHectometre().Value);
            Assert.AreEqual(1e-1,      m.ToDekametre().Value);

            Assert.AreEqual(1e1,       m.ToDecimetre().Value);
            Assert.AreEqual(1e2,       m.ToCentimetre().Value);
            Assert.AreEqual(1e3,       m.ToMillimetre().Value);
            Assert.AreEqual(1e6,       m.ToMicrometre().Value);
            Assert.AreEqual(1e9,       m.ToNanometre().Value);
            Assert.AreEqual(1e12,      m.ToPicometre().Value);
            Assert.AreEqual(1e15,      m.ToFemtometre().Value);
            Assert.AreEqual(1e18,      m.ToAttometre().Value);
            Assert.AreEqual(1e21,      m.ToZeptometre().Value);
            Assert.AreEqual(1e24,      m.ToYoctometre().Value);
        }
    }
}
