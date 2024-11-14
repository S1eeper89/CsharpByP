namespace Lekce_8_breakout
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Obdelnik karel = new Obdelnik(3.3, 5.7);
            Obdelnik Lucinka = new Obdelnik(9.9, 2.5);
            Obdelnik Ctverecinka = new Obdelnik(5);

            Console.WriteLine(Obdelnik.PocetObdelniku);
            int vysledekPocet = Obdelnik.PocetObdelniku;
            double vysledek = karel.vypocitejObsah();
            Console.WriteLine(vysledek);
            Console.WriteLine(vysledekPocet);
        }
    }
}
