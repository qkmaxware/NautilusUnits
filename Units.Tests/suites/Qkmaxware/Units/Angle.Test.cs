using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Qkmaxware.Units;
using Qkmaxware.Units.Angle;

namespace TestSuites.Qkmaxware.Units {
    [TestClass]
    public class AngleTest {
        [TestMethod]
        public void Degrees2Radians() {
            var d1 = 0.0.deg();
            var d2 = 90.deg();
            var d3 = 180.deg();
            var d4 = 270.deg();

            Assert.AreEqual(0,              d1.ToRadians().Value);
            Assert.AreEqual(Math.PI / 2,    d2.ToRadians().Value);
            Assert.AreEqual(Math.PI,        d3.ToRadians().Value);
            Assert.AreEqual(Math.PI * 1.5,  d4.ToRadians().Value);
        }

        [TestMethod]
        public void Radians2Degrees() {
            var r1 = (0).rad();
            var r2 = (Math.PI * 0.5).rad();
            var r3 = (Math.PI).rad();
            var r4 = (Math.PI * 1.5).rad();

            Assert.AreEqual(0,              r1.ToDegrees().Value);
            Assert.AreEqual(90,             r2.ToDegrees().Value);
            Assert.AreEqual(180,            r3.ToDegrees().Value);
            Assert.AreEqual(270,            r4.ToDegrees().Value);
        }
    }
}
