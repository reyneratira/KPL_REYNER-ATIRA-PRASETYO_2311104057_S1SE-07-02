using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpmodul12_2311104057;
using static tpmodul12_2311104057.Form1;

namespace tpmodul12_2311104057_Test
{
    [TestClass]
    public class TestCariTandaBilangan
    {
        [TestMethod]
        public void TestNegatif()
        {
            Assert.AreEqual("Negatif", Utility.CariTandaBilangan(-10));
        }

        [TestMethod]
        public void TestPositif()
        {
            Assert.AreEqual("Positif", Utility.CariTandaBilangan(5));
        }

        [TestMethod]
        public void TestNol()
        {
            Assert.AreEqual("Nol", Utility.CariTandaBilangan(0));
        }

        [TestMethod]
        public void TestInputBesar()
        {
            // Test untuk input yang terlalu besar
            Assert.ThrowsException<OverflowException>(() => Convert.ToInt32("2147483648"));
        }

        [TestMethod]
        public void TestInputKecil()
        {
            // Test untuk input yang terlalu kecil
            Assert.ThrowsException<OverflowException>(() => Convert.ToInt32("-2147483649"));
        }

        [TestMethod]
        public void TestInputFormatSalah()
        {
            // Test untuk input yang tidak valid
            Assert.ThrowsException<FormatException>(() => Convert.ToInt32("abc"));
        }

        [TestMethod]
        public void TestInputKosong()
        {
            // Test untuk input kosong
            Assert.ThrowsException<FormatException>(() => Convert.ToInt32(""));
        }
    }
}