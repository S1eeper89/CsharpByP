namespace Lekce_9_pole2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Clovek[] lide = new Clovek[3];
            for (int i = 0; i < lide.Length; i++)
            {
                Console.WriteLine($"Vyplnte udaje pro cloveka cislo {i + 1}");
                Console.WriteLine("Zadejte jmeno:");
                string jmeno = Console.ReadLine();
                Console.WriteLine("Zadej prijmeni:");
                string prijmeni = Console.ReadLine();
                Console.WriteLine("Zadejte rok narozeni:");
                int rokNarozeni = int.Parse(Console.ReadLine());

                Clovek osoba = new Clovek(jmeno, prijmeni, rokNarozeni);
                lide[i] = osoba;

                Console.WriteLine("Vypis pole lidi:");
                for (int i2 = 0; i2 < lide.Length; i2++)
                {
                    if (lide[i2] != null)
                    {
                        lide[i2].PredstavSe();
                    }
                    else
                    {
                        Console.WriteLine("Prazdny prvek.");
                    }
                }

            }




        }
        public class Clovek
        {
            public string Jmeno;
            public string Prijmeni;
            public int RokNarozeni;

            public Clovek(string jmeno, string prijmeni, int rokNarozeni)
            {
                Jmeno = jmeno;
                Prijmeni = prijmeni;
                RokNarozeni = rokNarozeni;
            }

            public void PredstavSe()
            {
                Console.WriteLine($"{Jmeno} {Prijmeni}, narozen/a {RokNarozeni}");
            }

        }

        public class TelefonniKontakt
        {
            public Clovek Clovek;
            public string Cislo;
            public TelefonniKontakt (Clovek clovek, string cislo)
            {
                Cislo = cislo;
                Clovek Clovek = clovek;

            }
            public void Vypiskontakt()
            {
                Console.WriteLine($"Kontakt: {Clovek.Jmeno} {Clovek.Prijmeni}, Telefon {Cislo}");
            }
        }
    }
}
