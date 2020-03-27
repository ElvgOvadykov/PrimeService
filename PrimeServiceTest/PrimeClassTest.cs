using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeService;

namespace PrimeServiceTest
{
    [TestClass]
    public class PrimeClassTest
    {

        [TestMethod]
        public void PrimeService()
        {
            Assert.IsFalse(PrimeClass.isPrime(10), "10 should not be prime");
        }

        [DataTestMethod]
        [DataRow(2, true)]
        [DataRow(3, true)]
        [DataRow(100, false)]
        [DataRow(21478314, false)]
        [DataRow(1942979, true)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value, bool result)
        {

            Assert.AreEqual(PrimeClass.isPrime(value), result);
        }
    }
}
