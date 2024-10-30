//while (!JeHladovy())
//{
//    Console.WriteLine("Hafik jeste nema hlad.");
//}

//Console.WriteLine("Hafik ma hlad. Musim ho nakrmit.");
//int kolikratMamSteknout = ZiskejPocetSteku();
//Zastekej(kolikratMamSteknout);
//	}

//	static void Zastekej()
//{
//    Console.WriteLine("Haf haf!");
//}

//static void Zastekej(int kolikrat)
//{
//    for (int i = 0; i < kolikrat; i++)
//    {
//        //Console.WriteLine("Haf haf!");
//        Zastekej();
//    }
//}

//static bool JeHladovy()
//{
//    Random generatorCisel = new Random();
//    int nahodneCislo = generatorCisel.Next(10);
//    if (nahodneCislo % 3 == 0)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

//static int ZiskejPocetSteku()
//{
//    Console.WriteLine("Zadej pocet steknuti:");
//    string vstup = Console.ReadLine();
//    bool jeCislo = int.TryParse(vstup, out int pocetSteku);
//    if (jeCislo && pocetSteku > 0)
//    {
//        return pocetSteku;
//    }
//    else
//    {
//        Console.WriteLine("Nezadal jsi platny pocet steku, stekneme jen jednou.");
//        return 1;
//    }
//}
//}
namespace Lekce_5_metody;

internal class Program
{
    static void Main(string[] args)
    {
        while (!JeHladovy())
        {
            Console.WriteLine("Hafik is not hungry");
        }
        Console.WriteLine("Hafik is hungry, we got to feed him");

        ZiskejPocetSteku();
    }

    static bool JeHladovy()
    {
        Random generatorCisel = new Random();
        int nahodneCislo = generatorCisel.Next(10);
        if (nahodneCislo % 3 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    static int ZiskejPocetSteku()
    {
        string vstup = Console.ReadLine();
        bool jeCislo = int.TryParse(vstup, out int pocetSteku);
        if (jeCislo && pocetSteku > 0)
        {
            return pocetSteku;
        }
        else
        {
            Console.WriteLine("Nezadal jsi pocet steku, stekne jenom jednou.");
            return 1;
        }
    }

}
