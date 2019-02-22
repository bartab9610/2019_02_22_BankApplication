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

        [Test]
        public void Sikertelen_utalas()
        {
            Bank OTP = new Bank();
            OTP.Ujszamla("Tesztnév", "01234");
            OTP.Ujszamla("Tesztnév2", "98765");
            var sikeres = OTP.Utal("01234", "98765", 10000);

            Assert.AreEqual(0, OTP.Egyenleg("01234"));
            Assert.AreEqual(0, OTP.Egyenleg("98765"));
            Assert.IsFalse(sikeres);
        }

        [Test]
        public void Utalas_nem_letezo_szamlara()
        {
            Bank OTP = new Bank();
            OTP.Ujszamla("Tesztnév", "01234");
            OTP.EgyenlegFeltolt("01234", 15000);
            OTP.Ujszamla("Tesztnév2", "98765");
            Assert.Throws<Hibas_szamlaszam_Exception>(() =>
                {
                    OTP.Utal("01234", "00000", 10000);
                }
            );

            Assert.AreEqual(15000, OTP.Egyenleg("01234"));
            Assert.AreEqual(0, OTP.Egyenleg("98765"));
        }

        [Test]
        public void Nemletezo_szamla_egyenleg()
        {
            Bank OTP = new Bank();
            Assert.Throws<Hibas_szamlaszam_Exception>(() =>
                {
                    var egyenleg = OTP.Egyenleg("01234");
                }
            );
        }
    }
}