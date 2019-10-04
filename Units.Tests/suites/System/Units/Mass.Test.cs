using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Units;
using System.Units.Mass;

namespace TestSuites.System.Units {
    [TestClass]
    public class MassTest {
        [TestMethod]
        public void GramConversions() {
            var m = 1.g();

            Assert.AreEqual(1e-24,     m.ToYottagram().Value);
            Assert.AreEqual(1e-21,     m.ToZettagram().Value);
            Assert.AreEqual(1e-18,     m.ToExagram().Value);
            Assert.AreEqual(1e-15,     m.ToPetagram().Value);
            Assert.AreEqual(1e-12,     m.ToTeragram().Value);
            Assert.AreEqual(1e-9,      m.ToGigagram().Value);
            Assert.AreEqual(1e-6,      m.ToMegagram().Value);
            Assert.AreEqual(1e-3,      m.ToKilogram().Value);
            Assert.AreEqual(1e-2,      m.ToHectogram().Value);
            Assert.AreEqual(1e-1,      m.ToDekagram().Value);

            Assert.AreEqual(1e1,       m.ToDecigram().Value);
            Assert.AreEqual(1e2,       m.ToCentigram().Value);
            Assert.AreEqual(1e3,       m.ToMilligram().Value);
            Assert.AreEqual(1e6,       m.ToMicrogram().Value);
            Assert.AreEqual(1e9,       m.ToNanogram().Value);
            Assert.AreEqual(1e12,      m.ToPicogram().Value);
            Assert.AreEqual(1e15,      m.ToFemtogram().Value);
            Assert.AreEqual(1e18,      m.ToAttogram().Value);
            Assert.AreEqual(1e21,      m.ToZeptogram().Value);
            Assert.AreEqual(1e24,      m.ToYoctogram().Value);
        }
    }
}
