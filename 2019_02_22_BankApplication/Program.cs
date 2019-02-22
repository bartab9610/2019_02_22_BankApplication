using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_02_22_BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank OTP = new Bank();
            OTP.Ujszamla("Debreczeni.L", "1122334455");
            OTP.Ujszamla("D.László", "9988776655");
            OTP.Utal("1122334455", "9988776655", 10000);
            Console.WriteLine(OTP.Egyenleg("1122334455"));
            Console.WriteLine(OTP.Egyenleg("9988776655"));

            Console.ReadLine();
        }
    }
}
