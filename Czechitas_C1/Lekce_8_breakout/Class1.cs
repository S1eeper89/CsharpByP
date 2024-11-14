using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce_8_breakout
{
    public class Obdelnik
    {
        public string PripadObdelniku;
        public double Delka;
        public double Sirka;
        public static int PocetObdelniku;
        public static int PocetCtvercu;

        public Obdelnik(double delka, double sirka)
        {
            PripadObdelniku = "Obdelnik";
            Delka = delka;
            Sirka = sirka;
            PocetObdelniku++;
        }
        public Obdelnik(double delka)
        {
            PripadObdelniku = "Ctverec";
            Delka = delka;
            Sirka = delka;
            PocetObdelniku++;
            PocetCtvercu++;
        }

        public double vypocitejObsah()
        {
            
            return Delka * Sirka;
        }

    }
}
