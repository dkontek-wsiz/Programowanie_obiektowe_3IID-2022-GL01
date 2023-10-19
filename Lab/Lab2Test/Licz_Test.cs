using Lab2.Models;

namespace NUnitTestProject1
{
    public class LiczTest
    {
        private Licz licz;

        [SetUp]
        public void Setup()
        {
            licz = new Licz();
        }

        [Test]
        public void ShouldCreateObject()
        {
            Assert.NotNull(licz);
        }


        [Test]
        [TestCase(2, 5, 7)]
        [TestCase(5, 6, 11)]
        public void Dodaj_Test(int i, int x, int expect)
        {
            licz.Dodaj(i);
            licz.Dodaj(x);
            Assert.AreEqual(expect, licz.Value);
        }
    }
}