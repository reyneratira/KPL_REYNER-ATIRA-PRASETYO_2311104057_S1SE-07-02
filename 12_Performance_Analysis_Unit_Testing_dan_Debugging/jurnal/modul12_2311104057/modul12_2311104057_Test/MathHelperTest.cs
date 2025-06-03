using Microsoft.VisualStudio.TestTools.UnitTesting;
using modul12_2311104057;

namespace modul12_2311104057_Test
{
    [TestClass]
    public class UtilitiesTest
    {
        [TestMethod]
        public void Test_B_Pangkat0_Return1()
        {
            Assert.AreEqual(1, Utilities.CariNilaiPangkat(0, 0));
            Assert.AreEqual(1, Utilities.CariNilaiPangkat(5, 0));
        }

        [TestMethod]
        public void Test_B_Negatif_ReturnMinus1()
        {
            Assert.AreEqual(-1, Utilities.CariNilaiPangkat(2, -3));
        }

        [TestMethod]
        public void Test_B_LebihDari10_Atau_A_LebihDari100_ReturnMinus2()
        {
            Assert.AreEqual(-2, Utilities.CariNilaiPangkat(2, 11));
            Assert.AreEqual(-2, Utilities.CariNilaiPangkat(101, 2));
        }

        [TestMethod]
        public void Test_Overflow_ReturnMinus3()
        {
            Assert.AreEqual(-3, Utilities.CariNilaiPangkat(46341, 5));
        }

        [TestMethod]
        public void Test_NormalCase_ReturnPangkat()
        {
            Assert.AreEqual(8, Utilities.CariNilaiPangkat(2, 3));
            Assert.AreEqual(81, Utilities.CariNilaiPangkat(3, 4));
        }
    }
}