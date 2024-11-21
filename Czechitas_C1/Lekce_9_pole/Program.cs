namespace Lekce_9_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prvniCislo = 1;
            int druheCislo = 2;

            int[] polesInicialiyatoremStarym = new int[] { 1, 2, 3 }; // stary zpusob

            int[] polesInicialiyatorem = { 1, 2, 3 };

            int[] druhePolesInicialiyatorem = { prvniCislo, druheCislo };

            int[] poleObycejne = new int[9];
            poleObycejne[0] = 1;
            poleObycejne[1] = 2;
            poleObycejne[2] = 3;

            int[] novasyntaxe = [1, 2, 3]; //nova syntaxe od 2022+

            for (int i = 0; i < poleObycejne.Length; i++)
            {
                Console.WriteLine($"poleObycejne, prvek {i} ma hodnotu {poleObycejne[i]}");

            }
        }
    }
}
