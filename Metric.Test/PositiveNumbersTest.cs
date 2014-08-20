using Metric;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class PositiveNumbersTest
    {
        private const int ONE = 1;
        private const int THOUSAND = 1000;
        private const int ONE_KILO = 1000;
        private const int ONE_MEGA = 1000000;
        private const int ONE_GIGA = 1000000000;
        private const long ONE_TERA = 1000000000000;
        private const long ONE_PETA = 1000000000000000;
        private const long ONE_EXA = 1000000000000000000;

        [Test]
        public void Zero_Kilo_Test()
        {
            const int arrange = 0;
            Assert.AreEqual(arrange, 0.Kilo());
        }

        [Test]
        public void Zero_Exa_Test()
        {
            const int arrange = 0;
            Assert.AreEqual(arrange, 0.Exa());
        }

        [Test]
        public void One_Kilo_Test()
        {
            var arrange = ONE_KILO;
            Assert.AreEqual(arrange, ONE.Kilo());
        }

        [Test]
        public void Thousand_Kilo_Is_Equal_One_Mega_Test()
        {
            var arrange = ONE_MEGA;
            Assert.AreEqual(arrange, THOUSAND.Kilo());
        }

        [Test]
        public void One_Mega_Test()
        {
            var arrange = ONE_MEGA;
            Assert.AreEqual(arrange, ONE.Mega());
        }

        [Test]
        public void Thousand_Mega_Is_Equal_One_Giga_Test()
        {
            var arrange = ONE_GIGA;
            Assert.AreEqual(arrange, THOUSAND.Mega());
        }

        [Test]
        public void One_Giga_Test()
        {
            var arrange = ONE_GIGA;
            Assert.AreEqual(arrange, ONE.Giga());
        }

        [Test]
        public void Thousand_Giga_Is_Equal_One_Tera_Test()
        {
            var arrange = ONE_TERA;
            Assert.AreEqual(arrange, THOUSAND.Giga());
        }

        [Test]
        public void One_Tera_Test()
        {
            const long arrange = ONE_TERA;
            Assert.AreEqual(arrange, ONE.Tera());
        }

        [Test]
        public void Thousand_Tera_Is_Equal_One_Peta_Test()
        {
            var arrange = ONE_PETA;
            Assert.AreEqual(arrange, THOUSAND.Tera());
        }


        [Test]
        public void One_Peta_Test()
        {
            const long arrange = 1000000000000000;
            Assert.AreEqual(arrange, ONE.Peta());
        }

        public void Thousand_Peta_Is_Equal_One_Exa_Test()
        {
            var arrange = ONE_EXA;
            Assert.AreEqual(arrange, THOUSAND.Peta());
        }

        [Test]
        public void One_Exa_Test()
        {
            var arrange = ONE_EXA;
            Assert.AreEqual(arrange, ONE.Exa());
        }

        [Test]
        public void Thousand_Exa_Is_Overflow_Test()
        {
            var zetta = 1000000000000000000000M;
            Assert.AreNotEqual(zetta, 1000.Exa());
        }
    }
}