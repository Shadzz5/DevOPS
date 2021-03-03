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

        public void TestSu()
        {
            int a = 2;
            int b = 8;
            Calculatrice calc = new Calculatrice();
            int result = calc.sub(a, b);

            Assert.AreEqual(6, result);

        }
        public void TestMul()
        {
            int a = 2;
            int b = 7;
            Calculatrice calc = new Calculatrice();
            int result = calc.mul(a, b);

            Assert.AreEqual(6, result);

        }
        public void TestDiv()
        {
            int a = 7;
            int b = 4;
            Calculatrice calc = new Calculatrice();
            int result = calc.div(a, b);

            Assert.AreEqual(6, result);

        }
    }
}