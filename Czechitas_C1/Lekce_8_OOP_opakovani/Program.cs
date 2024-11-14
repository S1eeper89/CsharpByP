namespace Lekce_8_OOP_opakovani
{
    public class Rytir
    {
        public string Jmeno;
        private int PocetZivotu;
        public int Sila;
        public static int PocetRytiru;
        public int PoradiRytire;

        public Rytir(string jmeno = "Franta", int pocetZivotu = 1, int sila = 2)
        {
            Jmeno = jmeno;
            PocetZivotu = pocetZivotu;
            Sila = sila;
            PocetRytiru++;

            if (pocetZivotu <= 0)
            {
                pocetZivotu = 1;
            }
            else
            {
                PocetZivotu = pocetZivotu;
            }
            PoradiRytire = PocetRytiru;

        }
        public Rytir(string jmenoVstup)
        {
            Jmeno = jmenoVstup;
            PocetZivotu = 1;
            Sila = 1;
        }



        public void UtocNaDraka()
        {
            Console.WriteLine("Utoc na draka");
        }

        public void PredstavSe()
        {
            Console.WriteLine($"Mé jméno je: {Jmeno}, mám {PocetZivotu} zivotu, silu {Sila} a jsem {PoradiRytire}. rytir");
        }

    }
    public class MatematickaFunkce
    {
        public static double Soucet(double a, double b)
        {
            return a + b;
        }
    }
    public class Drak
    {
        public string Jmeno;
        public int PocetHlav;
        public int Sila;

        public void UtocNaDraka()
        {
            Console.WriteLine("Utoc na draka");
        }

        public void PredstavSe()
        {
            Console.WriteLine($"Jsem drak {Jmeno}, mám {PocetHlav} zivotu a silu {Sila}");
        }

        public void ZasazenyRytirem()
        {
            PocetHlav--;
            if (PocetHlav == 0)
            {
                Console.WriteLine("Jsem Porazen");
            }
            else
            {
                Console.WriteLine("Kde mam hlavu");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Rytir sasa = new Rytir("Sasa", 5, 3);
            Rytir filip = new Rytir("Filip", 3, 5);
            Rytir franta = new Rytir();

            Drak jeronym = new Drak
            {
                Jmeno = "Jeronym",
                PocetHlav = 3,
                Sila = 5
            };
            sasa.PredstavSe();
            filip.PredstavSe();
            jeronym.PredstavSe();

            while (jeronym.PocetHlav > 0)
            {
                filip.UtocNaDraka();
                jeronym.ZasazenyRytirem();
            }

            double vysledek = MatematickaFunkce.Soucet(7.8, 3.4);
            Console.WriteLine(vysledek);
        }
    }
}
