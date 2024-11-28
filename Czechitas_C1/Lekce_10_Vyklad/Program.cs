namespace Lekce_10_Vyklad
{
    public class Statistika
    {
        // trida, ktera predam pole cisel a vypocita mi soucet vsech prvku

        public int[] Cisla;

        public Statistika(int[]poleCisel)
        {
            Cisla = poleCisel;
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

    }
    internal class Program
    {
        //
        static void Main(string[] args)
        {
            // opakovani, lole (lekce)
            //kolekce -> datova struktura, ktera uchovava vice hodnot

            // pole integru, celych cisel, kde budou prvku 1 az 5

            int[] pole = new int[5] { 1, 2, 3, 4, 5 };
            /*
             * pole[0] = 1;
             * pole[1] = 2;
             * pole[2] = 3;
             * pole[3] = 4;
             * pole[4] = 5;
            */
            // chci n na konyoli vypsat soucet pole
            Statistika novaStatistika = new Statistika(pole);
            Console.WriteLine($"{novaStatistika.VratSoucet()}");
        }
    }
}
