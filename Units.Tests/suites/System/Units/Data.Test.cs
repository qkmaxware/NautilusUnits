using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Units;
using System.Units.Data;

namespace TestSuites.System.Units {
    [TestClass]
    public class DataTest {

        [TestMethod]
        public void BitConversions() {
            var m = 1.bit();

            Assert.AreEqual(1e-24,     m.ToYottaBit().Value);
            Assert.AreEqual(1e-21,     m.ToZettaBit().Value);
            Assert.AreEqual(1e-18,     m.ToExaBit().Value);
            Assert.AreEqual(1e-15,     m.ToPetaBit().Value);
            Assert.AreEqual(1e-12,     m.ToTeraBit().Value);
            Assert.AreEqual(1e-9,      m.ToGigaBit().Value);
            Assert.AreEqual(1e-6,      m.ToMegaBit().Value);
            Assert.AreEqual(1e-3,      m.ToKiloBit().Value);
            Assert.AreEqual(1e-2,      m.ToHectoBit().Value);
            Assert.AreEqual(1e-1,      m.ToDekaBit().Value);

            Assert.AreEqual(1e1,       m.ToDeciBit().Value);
            Assert.AreEqual(1e2,       m.ToCentiBit().Value);
            Assert.AreEqual(1e3,       m.ToMilliBit().Value);
            Assert.AreEqual(1e6,       m.ToMicroBit().Value);
            Assert.AreEqual(1e9,       m.ToNanoBit().Value);
            Assert.AreEqual(1e12,      m.ToPicoBit().Value);
            Assert.AreEqual(1e15,      m.ToFemtoBit().Value);
            Assert.AreEqual(1e18,      m.ToAttoBit().Value);
            Assert.AreEqual(1e21,      m.ToZeptoBit().Value);
            Assert.AreEqual(1e24,      m.ToYoctoBit().Value);
        }

        [TestMethod]
        public void ByteConversions() {
            var m = 1.B();

            Assert.AreEqual(1e-24,     m.ToYottaByte().Value);
            Assert.AreEqual(1e-21,     m.ToZettaByte().Value);
            Assert.AreEqual(1e-18,     m.ToExaByte().Value);
            Assert.AreEqual(1e-15,     m.ToPetaByte().Value);
            Assert.AreEqual(1e-12,     m.ToTeraByte().Value);
            Assert.AreEqual(1e-9,      m.ToGigaByte().Value);
            Assert.AreEqual(1e-6,      m.ToMegaByte().Value);
            Assert.AreEqual(1e-3,      m.ToKiloByte().Value);
            Assert.AreEqual(1e-2,      m.ToHectoByte().Value);
            Assert.AreEqual(1e-1,      m.ToDekaByte().Value);

            Assert.AreEqual(1e1,       m.ToDeciByte().Value);
            Assert.AreEqual(1e2,       m.ToCentiByte().Value);
            Assert.AreEqual(1e3,       m.ToMilliByte().Value);
            Assert.AreEqual(1e6,       m.ToMicroByte().Value);
            Assert.AreEqual(1e9,       m.ToNanoByte().Value);
            Assert.AreEqual(1e12,      m.ToPicoByte().Value);
            Assert.AreEqual(1e15,      m.ToFemtoByte().Value);
            Assert.AreEqual(1e18,      m.ToAttoByte().Value);
            Assert.AreEqual(1e21,      m.ToZeptoByte().Value);
            Assert.AreEqual(1e24,      m.ToYoctoByte().Value);
        }

        [TestMethod]
        public void BitByteConversions() {
            var m = 1.B();
            var m2 = 8.bit();

            Assert.AreEqual(8,     m.ToBit().Value);
            Assert.AreEqual(1,     m2.ToByte().Value);
        }

        [TestMethod]
        public void ByteRealSizeConversions() {
            var m = 1.B();

            Assert.AreEqual(8.27181e-25,     m.ToYobiByte().Value, 0.001f);
            Assert.AreEqual(8.47033e-22,     m.ToZebiByte().Value, 0.001f);
            Assert.AreEqual(8.67362e-19,     m.ToExbiByte().Value, 0.001f);
            Assert.AreEqual(8.88178e-16,     m.ToPebiByte().Value, 0.001f);
            Assert.AreEqual(9.09495e-13,     m.ToTebiByte().Value, 0.001f);
            Assert.AreEqual(9.31323e-10,     m.ToGibiByte().Value, 0.001f);
            Assert.AreEqual(9.5367e-7,       m.ToMebiByte().Value, 0.001f);
            Assert.AreEqual(0.0009765625,    m.ToKibiByte().Value, 0.001f);
        }
    }
}
