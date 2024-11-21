namespace Lekce_9_pole_Jirka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prvniCislo = 1;
            int druheCislo = 2;

            int[] poleSInicializatorem = [1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6]; // nova syntaxe NET 7 (2022+)

            int[] druhePoleSInicializatorem = new int[] { prvniCislo, druheCislo }; // klasicky zapis

            int[] poleObycejne = new int[5];
            poleObycejne[0] = 1;
            poleObycejne[1] = 4;
            poleObycejne[2] = 9;
            poleObycejne[3] = 16;

            Console.WriteLine("Vypis obycejne pole:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Prvek s indexem {i} ma hodnotu {poleObycejne[i]}");
            }

            Console.WriteLine("Vypis pole s inicializatorem:");
            for (int i = 0; i < poleSInicializatorem.Length; i++)
            {
                Console.WriteLine($"Prvek s indexem {i} ma hodnotu {poleSInicializatorem[i]}");
            }

            Clovek pepa = new Clovek("Josef", "Dvorak", 1975);
            Clovek martin = new Clovek("Martin", "Novak", 1984);
            Clovek jirka = new Clovek("Jirka", "Hudec", 1991);

            Clovek[] lide = new Clovek[4];
            lide[0] = pepa;
            lide[1] = martin;
            lide[2] = jirka;

            Console.WriteLine("Vypis pole lidi:");
            for (int i = 0; i < lide.Length; i++)
            {
                if (lide[i] != null)
                {
                    lide[i].PredstavSe();
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
}
