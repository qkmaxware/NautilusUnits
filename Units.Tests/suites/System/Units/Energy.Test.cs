
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Units;
using System.Units.Energy;

namespace TestSuites.System.Units {
    [TestClass]
    public class EnergyTest {
        [TestMethod]
        public void JouleConversions() {
            var m = 1.J();

            Assert.AreEqual(1e-24,     m.ToYottaJoule().Value);
            Assert.AreEqual(1e-21,     m.ToZettaJoule().Value);
            Assert.AreEqual(1e-18,     m.ToExaJoule().Value);
            Assert.AreEqual(1e-15,     m.ToPetaJoule().Value);
            Assert.AreEqual(1e-12,     m.ToTeraJoule().Value);
            Assert.AreEqual(1e-9,      m.ToGigaJoule().Value);
            Assert.AreEqual(1e-6,      m.ToMegaJoule().Value);
            Assert.AreEqual(1e-3,      m.ToKiloJoule().Value);
            Assert.AreEqual(1e-2,      m.ToHectoJoule().Value);
            Assert.AreEqual(1e-1,      m.ToDekaJoule().Value);

            Assert.AreEqual(1e1,       m.ToDeciJoule().Value);
            Assert.AreEqual(1e2,       m.ToCentiJoule().Value);
            Assert.AreEqual(1e3,       m.ToMilliJoule().Value);
            Assert.AreEqual(1e6,       m.ToMicroJoule().Value);
            Assert.AreEqual(1e9,       m.ToNanoJoule().Value);
            Assert.AreEqual(1e12,      m.ToPicoJoule().Value);
            Assert.AreEqual(1e15,      m.ToFemtoJoule().Value);
            Assert.AreEqual(1e18,      m.ToAttoJoule().Value);
            Assert.AreEqual(1e21,      m.ToZeptoJoule().Value);
            Assert.AreEqual(1e24,      m.ToYoctoJoule().Value);
        }

        [TestMethod]
        public void ElectronvoltConversions() {
            var m = 1.eV();

            Assert.AreEqual(1e-24,     m.ToYottaElectronvolt().Value);
            Assert.AreEqual(1e-21,     m.ToZettaElectronvolt().Value);
            Assert.AreEqual(1e-18,     m.ToExaElectronvolt().Value);
            Assert.AreEqual(1e-15,     m.ToPetaElectronvolt().Value);
            Assert.AreEqual(1e-12,     m.ToTeraElectronvolt().Value);
            Assert.AreEqual(1e-9,      m.ToGigaElectronvolt().Value);
            Assert.AreEqual(1e-6,      m.ToMegaElectronvolt().Value);
            Assert.AreEqual(1e-3,      m.ToKiloElectronvolt().Value);
            Assert.AreEqual(1e-2,      m.ToHectoElectronvolt().Value);
            Assert.AreEqual(1e-1,      m.ToDekaElectronvolt().Value);

            Assert.AreEqual(1e1,       m.ToDeciElectronvolt().Value);
            Assert.AreEqual(1e2,       m.ToCentiElectronvolt().Value);
            Assert.AreEqual(1e3,       m.ToMilliElectronvolt().Value);
            Assert.AreEqual(1e6,       m.ToMicroElectronvolt().Value);
            Assert.AreEqual(1e9,       m.ToNanoElectronvolt().Value);
            Assert.AreEqual(1e12,      m.ToPicoElectronvolt().Value);
            Assert.AreEqual(1e15,      m.ToFemtoElectronvolt().Value);
            Assert.AreEqual(1e18,      m.ToAttoElectronvolt().Value);
            Assert.AreEqual(1e21,      m.ToZeptoElectronvolt().Value);
            Assert.AreEqual(1e24,      m.ToYoctoElectronvolt().Value);
        }

        [TestMethod]
        public void JouleElectronvoltConversions() {
            var j = 1.J();
            var ev = 1.eV();

            Assert.AreEqual(1.60218e-19, ev.ToJoule().Value, 0.01);
            Assert.AreEqual(6.242e+18, j.ToElectronvolt().Value, 0.01);
        }
    }
}
