namespace lekce_asi_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            //int odpracovaneHodiny = 0;
            //int pozadovanychOdpracovanychHodin = 8;
            //while (odpracovaneHodiny < pozadovanychOdpracovanychHodin)
            //{
            //    odpracovaneHodiny++;
            //    Console.WriteLine($"Odpracoval jsem" + odpracovaneHodiny + "hodin");
            //}

            static void Zastekej()
            {
                Console.WriteLine("Haf!");
                Console.WriteLine("Haf!");
                Console.WriteLine("Haf!");

            }

            Zastekej();

            static void Zastekej(int kolikrat)
            {
                for (int i = 0; i < kolikrat; i++)
                {
                    Console.WriteLine("Haf!");
                    Console.WriteLine("Haf!");
                    Console.WriteLine("Haf!");
                }
            }
            Zastekej(3);
        }
    }
}
