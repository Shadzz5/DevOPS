using NUnit.Framework;
using DevOPS;
namespace DevOPS.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            int a = 2;
            int b = 4;
            Calculatrice calc = new Calculatrice();
            int result = calc.add(a, b);

            Assert.AreEqual(6, result);
        }
        [Test]
        public void TestSu()
        {
            int a = 8;
            int b = 2;
            Calculatrice calc = new Calculatrice();
            int result = calc.sub(a, b);

            Assert.AreEqual(6, result);

        }
        [Test]
        public void TestMul()
        {
            int a = 2;
            int b = 7;
            Calculatrice calc = new Calculatrice();
            int result = calc.mul(a, b);

            Assert.AreEqual(14, result);

        }
        [Test]
        public void TestDiv()
        {
            int a = 8;
            int b = 4;
            Calculatrice calc = new Calculatrice();
            int result = calc.div(a, b);

            Assert.AreEqual(2, result);

        }
        [Test]
        public void TestMod()
        {
            int a = 8;
            int b = 2;
            Calculatrice calc = new Calculatrice();
            int result = calc.mod(a, b);

            Assert.AreEqual(0, result);

        }
    }
}