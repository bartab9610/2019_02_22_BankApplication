using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_02_22_BankApplication
{
    class Hibas_szamlaszam_Exception : Exception
    {
        public Hibas_szamlaszam_Exception(string szamlaszam)
            : base("Hibás számlaszám: " + szamlaszam)
        // JAVA ---> super("Hibás számlaszám: " + szamlaszam)
        {
        }
    }
}
