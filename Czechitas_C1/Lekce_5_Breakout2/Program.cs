namespace Lekce_5_breakoutroom2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// 1) Vytvořte metodu s nazvem ZiskejTextovyVstupZKonzole(), která se bude uživatele ptát na zadání libovolného textu (string).
            /// Dokud uživatel nezadá text správně, nechávejte uživatele pokusit se text zadat znovu.
            /// Jakmile zadá uživatel text správně, metoda navrátí tento text jako návratovou hodnotu.
            /// Zavolejte tuto metodu v Main, uložte si výstup funkce a vypiště zadaný text zpátky do konzole (napr se zeptej na jmeno a prijmeni).		
            ///
            /// 2) Udělejte to samé pro zadání libovolného desetinného čísla (double).
            /// Dokud uživatel nezadá správně desetinné číslo, nechávejte uživatele pokusit se číslo zadat znovu.
            /// Jakmile zadá uživatel desetinné číslo správně, metoda jej navrátí toto desetinné číslo jako návratovou hodnotu.
            /// TIP: Budete určitě potřebovat while cyklus, TryParse, return
            /// Zavolejte tuto metodu v Main, uložte si výstup funkce a vypiště zadané desetinné číslo zpátky do konzole (napr se zeptej na vek).		
            ///
            /// Bonus: 3) Přidejte metodám parametr typu string, ve kterém metodě předáte text,
            /// který se zobrazí v konzoli předtím, než se uživatel pokusí zadat svůj vstup.
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"Tvuj vysledek je {ZiskejTextovyVstupZKonzole()}");
            Console.WriteLine(ZiskejCiselnyVstupZKonzole());

        }
        static string ZiskejTextovyVstupZKonzole()
        {

            Console.WriteLine("Zadej textovy vstup do konzole.");
            string vstup = Console.ReadLine();
            String.IsNullOrEmpty(vstup);

            while (String.IsNullOrEmpty(vstup))
            {
                Console.WriteLine("Zadej textovy vstup do konzole.");
                vstup = Console.ReadLine();
                String.IsNullOrEmpty(vstup);
            }
            return vstup;
        }
        static double ZiskejCiselnyVstupZKonzole()
        {

            Console.WriteLine("Zadej ciselny vstup do konzole.");
            string vstup2 = Console.ReadLine();
            String.IsNullOrEmpty(vstup2);
            bool isNumberOne = double.TryParse(vstup2, out double cislo1);
            bool notEmpty = String.IsNullOrEmpty(vstup2);
            while (notEmpty || !isNumberOne)
            {
                Console.WriteLine("Zadej ciselny vstup do konzole.");
                vstup2 = Console.ReadLine();
                isNumberOne = double.TryParse(vstup2, out cislo1);
                notEmpty = String.IsNullOrEmpty(vstup2);
            }
            return cislo1;
        }
    }
}
