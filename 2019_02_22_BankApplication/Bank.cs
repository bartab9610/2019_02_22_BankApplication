using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_02_22_BankApplication
{
    class Bank
    {
        class Szamla
        {
            public string Nev { get; set; }
            public string Szamlaszam { get; set; }
            public ulong Osszeg { get; set; }

            public Szamla(string nev, string szamlaszam)
            {
                this.Nev = nev;
                this.Szamlaszam = szamlaszam;
                this.Osszeg = 0;
            }
        }

        List<Szamla> szamlak = new List<Szamla>();
        public void Ujszamla(string nev, string szamlaszam)
        {
            var sz = new Szamla(nev, szamlaszam); // Szamla sz = new Szamla(nev, szamlaszam);
            szamlak.Add(sz);
        }

        Szamla Keres(string szamlaszam)
        {
            foreach (var sz  in szamlak)
            {
                if (sz.Szamlaszam.Equals(szamlaszam))
                {
                    return sz;
                }
            }
            return null;
        }
        public void Utal(string honnan, string hova, ulong osszeg) // ulong -> előjel nélküli
        {
            var Forras_szamla = Keres(honnan);
            var Cel_szamla = Keres(hova);
            Forras_szamla.Osszeg -= osszeg;
            Cel_szamla.Osszeg += osszeg;
        }
        public ulong Egyenleg(string szamlaszam)
        {
            return Keres(szamlaszam).Osszeg;
        }
    }
}