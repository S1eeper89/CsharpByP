namespace test_2
{
    internal class Program
    {
        static void PredstavSe()
        {
            Console.WriteLine("Zuzanka");
            Console.WriteLine("Hubata");
        }
        static void PredstavSe(int vek)
        {
            Console.WriteLine("Zuzanka");
            Console.WriteLine("Hubata");
            Console.WriteLine($"A je ti {vek} let");
        }
        static void Main(string[] args)
        {
            PredstavSe();
            PredstavSe(8);


            {
                /// TIP: Všechny metody musíme psát mimo metodu Main, všechny metody budou v následujícím tvaru:
                ///     public static [NavratovyTyp] [JmenoMetody]([TypParametru1] [JmenoParametru1], [TypParametru2] [JmenoParametru2], ...)
                ///     {
                ///         ///Tělo metody
                ///     }

                /// V následující ukázce metody:
                /// NavratovyTyp = void (metoda nic nevrací)
                /// JmenoMetody = UkazkaMetody (metody nazýváme libovolným textem s velkým počátečním písmenem)
                /// TypParametru1 = string (libovolný datový typ, zde string)
                /// JmenoParametru1 = text (pod tímto názvem "text" je dodaný parametr dostupný v metodě)
                /// TypParametru2 = double (libovolný datový typ, zde double)
                /// JmenoParametru2 = desetinneCislo (pod tímto názvem "desetinneCislo" je dodaný parametr dostupný v metodě)
                //              public static void UkazkaMetody(string text, double desetinneCislo)
                {

                    /// Zde (tělo metody), můžeme pracovat s dodanými parametry (zde text a desetinneCislo)
                }

                //              public static void Main(string[] args)
                {
                    /// 1) Vytvořte metodu PredstavSe(), která vypíše do konzole jméno a příjmení. Jméno a příjmení si libovolně zvol a zadefinuj je přímo v tělu metody. 
                    /// 2) Zavolej tuto metodu v Main. Zkontroluj, že v konzoli je očekávaný výstup.
                    /// 3) Vytvořte metodu PredstavSe(int vek), která vypíše do konzole jméno, příjmení a věk (jeho hodnotu získáš v metodě pomocí parametru "vek"). 
                    ///	   Jméno a příjmení si libovolně zvol a zadefinuj je přímo v tělu metody. 
                    /// 4) Zavolej tuto metodu v Main. Vyzkoušej si, že v konzoli se vypisuje věk, který metodě předáš pomocí parametru "vek".
                    ///		
                    /// Bonus: 5) Vytvoř metodu PredstavSe, která bude příjímat parametry: jmeno, prijmeni, vek
                    ///         Tato metoda pak vypíše do konzole text ve formátu:
                    ///         Jmenuji se Pavel Novák, je mi 36 let. (Výpis do konzole v tomto případě odpovídá zavolání metody PredstavSe s hodnotami parametrů: "Pavel", "Novák", 36)
                    /// 		Zavolej tuto metodu v Main, vyzkoušej si měnit parametry, ověř že výstup do koznole odpovídá parametrům.
                }
            }
        }
    }
}
