using System;
using System.Threading.Channels;

namespace Lekce07.BreakoutRoom1
{
    internal class Program
    {
        public class Bod
        {
            public int X;
            public int Y;

            //konstruktor
            public Bod(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void ZobrazInformace()
            {
                Console.WriteLine($"[X: {X}, Y: {Y}]");
            }
        }

        public class Usecka
        {
            private Bod BodA;
            private Bod BodB;

            public Usecka(Bod prvniBod, Bod druhyBod)
            {
                BodA = prvniBod;
                BodB = druhyBod;
            }

            public void vypisUsecku ()
            {
                Console.WriteLine($"První bod úsečky je {BodA.X} a {BodA.Y}, druhý bod úsečky je {BodB.X} a {BodB.Y}");
            }


             
        }

        static void Main(string[] args)
        {
            //Bod mujBod = new Bod { X = 8, Y = 1 };
            Bod mujBod2 = new Bod(10, 15);
            mujBod2.ZobrazInformace();

            Usecka mojeUsecka1 = new Usecka(new Bod(1, 9), new Bod(11, 88));

            mojeUsecka1.vypisUsecku();


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


        }
    }
}