namespace Lekce_7_BR2
{
    //1. Vytvořte třídu Bod, která bude obsahovat souřadnici X a Y.
    //    Vytvořte instanci této třídy, naplňte X a Y hodnotami a potom je vytiskněte na konzoli
    //2. Ve třídě Bod vytvořte metodu ZobrazInformace,
    //    která zobrazí hodnoty např. pro X=1 a Y=2 ve formátu "[X: 1, Y: 2]"
    //3. Vytvořte třídu Usecka, ve které budou dva body A a B.
    //4. V programu si vytvořte instanci Usecka, nastavte jí body A a B
    //   s libovolnými souřadnicemi (každý bod jiné).
    //5. Vytvořte konstruktory pro Bod i Usecku

    // Bod osamelyBod = new Bod(4,3)
    // Usecka usecka = new Usecka(new Bod(1,2), new Bod(5,3));

    //6. Bonus: Ve třídě Usecka vytvořte metodu ZobrazInformace,
    //	  která zobrazí informace o bodech zavoláním jejich metod ZobrazInformace
    //    např: "Usecka z bodu [X: 1, Y: 2] do bodu [X: 5, Y: -2]"
 
        internal class Program
        {
            class Bod
            {
                private int X;
                private int Y;

                // Konstruktor pro třídu Bod s parametry X a Y
                public Bod(int x, int y)
                {
                    X = x;
                    Y = y;
                }

                // Metoda ZobrazInformace, která vypíše informace o souřadnicích bodu
                public void ZobrazInformace()
                {
                    Console.Write($"[X: {X}, Y: {Y}]");
                }
            }

            class Usecka
            {
                private Bod PrvniBod;
                private Bod DruhyBod;

                // Konstruktor pro třídu Usecka s dvěma body
                public Usecka(Bod prvniBod, Bod druhyBod)
                {
                    PrvniBod = prvniBod;
                    DruhyBod = druhyBod;
                }

                // Metoda ZobrazInformace pro úsečku
                public void ZobrazInformace()
                {
                    Console.Write("Usecka z bodu ");
                    PrvniBod.ZobrazInformace();
                    Console.Write(" do bodu ");
                    DruhyBod.ZobrazInformace();
                }
            }

            static void Main(string[] args)
            {
                // Vytvoření instance třídy Bod a nastavení souřadnic
                Bod osamelyBod = new Bod(4, 3);
                osamelyBod.ZobrazInformace();
                Console.WriteLine();

                // Vytvoření instance třídy Usecka s body A a B s libovolnými souřadnicemi
                Bod zacatekUsecky = new Bod(1, 2);
                Bod konecUsecky = new Bod(5, -2);
                Usecka usecka = new Usecka(zacatekUsecky, konecUsecky);
                usecka.ZobrazInformace();
                Console.WriteLine();

                // Bonus: Naucte tridy pocitat pocet instanci jako jsme si ukazovali na lekci.
            }
        }
    }

