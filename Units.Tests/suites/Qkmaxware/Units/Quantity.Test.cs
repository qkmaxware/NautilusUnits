using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Qkmaxware.Units;
using Qkmaxware.Units.Length;

namespace TestSuites.Qkmaxware.Units {
    [TestClass]
    public class QuantityTest {
        [TestMethod]
        public void TestSimpleToGenericConversion() {
            Quantity<double, Metre> orig = 12.4.m();
            Quantity<Metre> converted = orig;
            Quantity<double, Metre> back = converted;
            
            Assert.AreEqual(orig.Value, converted.Value);
            Assert.AreEqual(converted.Value, back.Value);
            Assert.AreEqual(orig.Value, back.Value);
        }
        
        public void TestSimpleUnitConversion() {
            Quantity<Metre> simple = 12.m();
            Quantity<KiloMetre> simpleKM = simple.ToKiloMetre();
        }
    }
}
