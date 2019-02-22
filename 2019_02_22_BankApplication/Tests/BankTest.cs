using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_02_22_BankApplication.Tests
{
    [TestFixture]
    class BankTest
    {
        [Test]
        public void UjSzamla_egyenleg_nulla()
        {
            Bank OTP = new Bank();
            OTP.Ujszamla("Tesztnév", "01234");
            Assert.AreEqual(0, OTP.Egyenleg("01234"));
        }

        [Test]
        public void PenzBetesz()
        {
            Bank OTP = new Bank();
            OTP.Ujszamla("Tesztnév", "01234");
            OTP.EgyenlegFeltolt("01234", 5000);
            Assert.AreEqual(5000, OTP.Egyenleg("01234"));
        }
    }
}