namespace Lekce_10_breakoutroom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Hello, World!");

            Statistika dalsiStatistika = new Statistika(pole);

            Console.WriteLine($"soucet:{dalsiStatistika.VratSoucet()}, pocet:{dalsiStatistika.VratPocetCisel()}, prumer: {dalsiStatistika.VratPrumer()}");


        }
    }
    public class Statistika
    {
        public int[] Cisla;
        public Statistika(int[] vstupniPoleCisel)
        {
            Cisla = vstupniPoleCisel;
        }

        public int VratSoucet()
        {
            int soucet = 0;
            for (int i = 0; i < Cisla.Length; i++)
            {
                soucet += Cisla[i];
            }
            return soucet;
        }
        public double VratPrumer()
        {

            return VratSoucet() / Cisla.Length;
        }

        public int VratPocetCisel()
        {
            return Cisla.Length;
        }
    }
}
