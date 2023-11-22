using Lab2.Models;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class LiczTest
    {
        private Licz licz;

        [SetUp]
        public void Setup()
        {
            licz = new Licz(5);
        }

        [Test]
        public void ShouldCreateObject()
        {
            Assert.NotNull(licz);
        }

        [Test]
        public void ShouldInitialValue()
        {
            Assert.AreEqual(5, licz.GetValue());
        }


        [Test]
        [TestCase(2, 5, 12)]
        [TestCase(5, 6, 16)]
        public void Dodaj_Test(int i, int x, int expect)
        {
            licz.Dodaj(i);
            licz.Dodaj(x);
            Assert.AreEqual(expect, licz.GetValue());
        }

        [Test]
        [TestCase(2, 5, -2)]
        [TestCase(5, 6, -6)]
        public void Oddejmnij_Test(int i, int x, int expect)
        {
            licz.Oddejmnij(i);
            licz.Oddejmnij(x);
            Assert.AreEqual(expect, licz.GetValue());
        }
    }
}