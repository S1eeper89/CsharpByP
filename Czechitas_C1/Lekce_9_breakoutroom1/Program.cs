using System.Net.Http.Headers;

namespace Lekce_9_breakoutroom1
{
    public class Clovek
    {
        public string Jmeno;
        public string Prijmeni;

        public Clovek(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }

        public void PredstavSe()
        {
            Console.WriteLine($"Jmeno: {Jmeno} Prijmeni: {Prijmeni}");
        }
    }

    public class TelefonniKontakt
    {
        public Clovek Clovek;
        public string Cislo;
        public TelefonniKontakt(Clovek clovek, string cislo)
        {
            Cislo = cislo;
            Clovek Clovek = clovek;

        }
        public void Vypiskontakt()
        {
            Console.WriteLine($"Kontakt: {Clovek.Jmeno} {Clovek.Prijmeni}, Telefon {Cislo}");
        }
    }

    public class TelefonniSeznam
    {
        public TelefonniKontakt[] PoleTelefonniKontakt;
        public TelefonniSeznam(TelefonniKontakt[] poleTelefonniKontakt)
        {
            PoleTelefonniKontakt = poleTelefonniKontakt;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Clovek karelNetrefil = new Clovek("Karel", "Netrefil");
            Clovek matejNezabil = new Clovek("Matej", "Nezabil");
            Clovek lojzaUvaril = new Clovek("Lojza", "Uvaril");


            Clovek[] lide = new Clovek[3];
            lide[0] = karelNetrefil;
            lide[1] = matejNezabil;
            lide[2] = lojzaUvaril;

            for (int i = 0; i < lide.Length; i++)
            {
                lide[i].PredstavSe();
            }
            TelefonniKontakt telefonniKontakt1 = new TelefonniKontakt(karelNetrefil, "123456789");
            TelefonniKontakt telefonniKontakt2 = new TelefonniKontakt(matejNezabil, "123456889");
            TelefonniKontakt telefonniKontakt3 = new TelefonniKontakt(matejNezabil, "123456989");

            TelefonniKontakt[] telefonniKontakty = [telefonniKontakt1, telefonniKontakt2, telefonniKontakt3];
        }

    }
}
