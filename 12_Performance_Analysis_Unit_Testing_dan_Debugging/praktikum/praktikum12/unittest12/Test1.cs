using System.Security.Cryptography.X509Certificates;

namespace unittest12
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            String? result = praktikum12.Program.DeternmineGrade(90);
            Assert.AreEqual("A", result);
            String? result2 = praktikum12.Program.DeternmineGrade(80);
            Assert.AreEqual("B", result2);
            String? result3 = praktikum12.Program.DeternmineGrade(70);
            Assert.AreEqual("C", result3);
            String? result4 = praktikum12.Program.DeternmineGrade(60);
            Assert.AreEqual("D", result4);
            String? result5 = praktikum12.Program.DeternmineGrade(0);
            Assert.AreEqual("F", result5);

        }
    }
}
