using System.Globalization;
using System.Threading.Channels;

namespace Lekce_6_breakoutroom_1
{
    public class Clovek
    {
        public string Jmeno;
        public string Pohlavi;
        public int RokNarozeni;
        public double Hmotnost;
        public bool Manzelstvi;
        public void VypisInformaci()
        {
            DateTime dnesniDatum = DateTime.Now;
            int rok = dnesniDatum.Year;

            int stari = rok - RokNarozeni;

            string stavManzelstvi = "neznámý";
            if (Manzelstvi = true && Pohlavi.ToLower() == "zena")
            {
                stavManzelstvi = "vdana";
            }
            else if (Manzelstvi = true && Pohlavi.ToLower() == "muz")
            {
                stavManzelstvi = "zenaty";
            }
            else if (Manzelstvi = false && Pohlavi.ToLower() == "zena")
            {
                stavManzelstvi = "svobodná";
            }
            else if (Manzelstvi = false && Pohlavi.ToLower() == "muz")
            {
                stavManzelstvi = "svobodný";
            }
            else
                




            Console.WriteLine($"Subjelkt Clovek se jmenuje {Jmeno}, je to {Pohlavi}, váží {Hmotnost} a je {stavManzelstvi} a je mu {stari} let.");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Clovek pepa = new Clovek
            {
                Jmeno = "Pepa",
                Pohlavi = "Má",
                RokNarozeni = 1989,
                Hmotnost = 99.9,
                Manzelstvi = false
            };

            Clovek karel = new Clovek
            {
                Jmeno = "Karel",
                Pohlavi = "Žena",
                RokNarozeni = 666,
                Hmotnost = 55.55,
                Manzelstvi = true
            };

            karel.VypisInformaci();

            DateTime dnesniDatum = DateTime.Now;
            int rok = dnesniDatum.Year;

            Console.WriteLine("Hello, World!");
        }
    }
}
