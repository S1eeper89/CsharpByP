namespace Lekce_6_uvod
{
    public class Auto
    {
        public string Vyrobce;
        public int PocetSedadel;
        public int RokVyroby;
        public string Barva;
        public int VratStariAuta()
        {
            int stariAuta = 2024 - RokVyroby;
            return stariAuta;
        }


        public void VypisVlastnosti()
        {
            Console.WriteLine($"Na skalde mam {Vyrobce}, pocet sedadel je {PocetSedadel}, rok vyroby je {RokVyroby}, barva je {Barva} a {VratStariAuta()}");
        }

    }
    internal class Program
    {

        // Zatrub jednou
        public static void Zatrub()
        {
            Console.WriteLine("Tut tut");
        }
        // Zatrub Nkrat
        public static void ZatrubNkrat(int kolikrat)
        {
            for (int i = 0; i <= kolikrat; i++)
            {
                Zatrub();
            }
        }

        // vzpocita muj vek, vstupem je rok narozeni a vystupem (vraci int) je vek

        public static int SpocitejVek(int rokNarozeni)
        {
            int aktualniRok = 2024;
            int mujVek = aktualniRok - rokNarozeni;
            return mujVek;
        }



        static void Main(string[] args)
        {
            Auto ferrari = new Auto
            {
                Barva = "Cervena",
                Vyrobce = "Ferrari",
                RokVyroby = 4,
                PocetSedadel = 4
            };

            Auto buggati = new Auto
            {
                Barva = "Bobulova",
                Vyrobce = "Bugati",
                RokVyroby = 1989,
                PocetSedadel = 94
            };
            



            // ferrari, vyrobce, pocetSedadel, barva, rokVyroby
            string vyrobce = "Ferrari";
            int pocetSedadel = 4;
            int rokVyroby = 2020;
            string barva = "Bila";


            Console.WriteLine($"{SpocitejVek(1989)}");

            Console.WriteLine("Napis svuj rok narozeni.");
            string vstup = Console.ReadLine();
            int vstupRokNarozeni = int.Parse(vstup);

            //Console.WriteLine($"Muj vek je {SpocitejVek(vstupRokNarozeni)}");

            int vyslednyVek = SpocitejVek(vstupRokNarozeni);

            Console.WriteLine($"Muj vek je {vyslednyVek}");                                                                                                                                                      




        }
    }
}
