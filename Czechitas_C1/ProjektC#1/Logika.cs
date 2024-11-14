using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjektC_1
{
    //    Zadání je tedy následující:
    //1. Vytvoř si nový konzolový projekt - budeme začínat na zelené louce
    //2. Zadefinuj třídu Kalkulacka
    //3. Třída Kalkulacka si musí umět pamatovat aktuální výsledek(vlastnost třídy Kalkulacka) - aktuální výsledek by měl být po vytvoření kalkulačky nulový a měl by být desetinného typu.
    //4.  Zadefinuj a naimplementuj metodu JePlatnyOperator, která nám bude vracet True právě tehdy, když vstupní parametr této metody bude jeden z námi podporovaných operací(‘+’,’-’,’*’,’/’,’^’).
    //5. Zadefinuj a naimplementuj metody třídy(Pricti, Odecti, …) pro všechny podporované operace.
    //    Metody budou pracovat s jedním vstupním parametrem a upravovat aktuální výsledek kalkulačky.
    //6. Zadefinuj a naimplementuj metodu VratAktualniVysledek, která nám bude vracet aktuální výsledek kalkulačky.7. Zkontroluj si, že Kalkulacka nevolá Console (ani ReadLine, ani WriteLine).
    //8. Ověř si, že logika tvé kalkulačky funguje správně pomocí jejího provolávání v Main (první číslo nastavíme kalkulačce pomocí metody Pricti) Viz níže v příkladu,
    //   který můžeš doplnit svým kódem.

    //Ukázka ověření logiky kalkulačky provoláváním třídy v Main:
    //public static void Main()
    //    {
    //        // 1. Vytvoř si instanci třídy Kalkulacka
    //        Kalkulacka kalkulacka = new… (doplň)
    //    // 2. Nechej si vrátit aktuální výsledek kalkulačky provoláním správné metody a vypiš jej do konzole (měl by být nulový).
    //    “tvůj kód”
    //    // 3. Načti si první číslo z konzole (stačí Console.ReadLine() bez ověřování vstupu) a nastav jej kalkulačce.
    //    kalkulacka.Pricti(prvniCislo);
    //        // 4. Načti operátor z konzole (stačí Console.ReadLine() bez ověřování vstupu) a do konzole vypiš, jestli jej tvá kalkulačka podporuje.
    //        if (kalkulacka.JePlatnyOperator(operace))
    //        {
    //        “tvůj kód výpisu do konzole”
    //    }
    //        // 5. Načti si druhé číslo z konzole (stačí Console.ReadLine() bez ověřování vstupu) a vykonej správnou operaci na kalkulačce pomocí switche.
    //        switch (operace)
    //        {
    //            case ‘+’:
    //              “zavolej zde správnou metodu kalkulačky”
    //        //… dodej všechny možnosti
    //        //…
    //        //…
    //    }
    //    // 6. Nechej si vrátit aktuální výsledek kalkulačky provoláním správné metody a vypiš jej do konzole.
    //    // Výsledek by měl odpovídat očekávanému výstupu na základě použité operace.
    //    “tvůj kód zde”
    //    }
    public class Logika
    {
        public double umocni(double mocnenec, int mocnitel)
        {
            if (mocnitel == 0)
                return 1;
            return 
        }
    }
    //{
    //    static double Umocni(double mocnenec, int mocnitel)
    //    {
    //        if (mocnitel == 0)
    //        {
    //            return 1;
    //        }
    //        double vysledekUmocni = 1;
    //        int absMocnitel = Math.Abs(mocnitel);
    //        for (int i = 1; i <= absMocnitel; i++)
    //        {
    //            vysledekUmocni = vysledekUmocni * mocnenec;
    //        }
    //        if (mocnitel < 0)
    //        {
    //            return 1 / vysledekUmocni;
    //        }
    //        return vysledekUmocni;
    //    }
    //    // metoda pro zadání prvního čísla
    //    static double zadejPrvniCislo()
    //    {
    //        double firstNumber;
    //        string inputOne = Console.ReadLine();
    //        while (!double.TryParse(inputOne, out firstNumber))
    //        {
    //            Console.WriteLine("Nezadal jsi číslo, prosím zadej první číslo (a).");
    //            inputOne = Console.ReadLine();
    //        }
    //        return firstNumber;
    //    }
    //    //metoda pro opakující se operátor s možností výstupu přes x
    //    static string zadejDalsiOperator()
    //    {
    //        Console.WriteLine("Zadej další operátor (+) (-) (*) (/) (^) nebo pro ukončení (x) ");

    //        string firstOperator = Console.ReadLine();
    //        while (!(firstOperator == "+" || firstOperator == "-" || firstOperator == "*" || firstOperator == "/" || firstOperator == "^" || firstOperator.ToLower() == "x"))
    //        {
    //            Console.WriteLine($"Nezadal jsi správný operátor, zadej operátor (+) (-) (*) (/) (x) ");
    //            firstOperator = Console.ReadLine();
    //        }
    //        return firstOperator;
    //    }
    //    // mtoda pro opakující se číslo s možností výstupu
    //    static string zadejDalsiCislo(string dalsiOperator)
    //    {
    //        Console.WriteLine("Zadej další číslo (b), pro ukončení zadej (x).");

    //        string inputTwo = Console.ReadLine();
    //        double secondNumber = 0;
    //        while ((inputTwo.ToLower() != "x" && !double.TryParse(inputTwo, out secondNumber)) || (secondNumber == 0 && dalsiOperator == "/") || (dalsiOperator == "^" && secondNumber % 1 != 0))
    //        {
    //            if (secondNumber == 0 && dalsiOperator == "/")
    //            {
    //                Console.WriteLine("Nulou nelze dělit, zadej prosím druhé číslo (b), nebo (x)");
    //            }
    //            else if (dalsiOperator == "^" && secondNumber % 1 != 0)
    //            {
    //                Console.WriteLine("Nezadal jsi celé číslo, zadej prosím druhé číslo (b), nebo (x)");
    //            }
    //            else
    //            {
    //                Console.WriteLine("Nezadal jsi číslo, zadej prosím druhé číslo (b), nebo (x)");
    //            }
    //            inputTwo = Console.ReadLine();
    //        }
    //        return inputTwo;

    //    }
    //    // metoda pro výpočet prvního výpočtu
    //    static double Vypocti(string firstOperator, double firstNumber, double secondNumber)
    //    {
    //        double vysledek = 0;

    //        switch (firstOperator)
    //        {
    //            case "+":
    //                vysledek = firstNumber + secondNumber;
    //                Console.WriteLine($"{firstNumber} {firstOperator} {secondNumber} = {vysledek}");
    //                Console.WriteLine($"Výsledek: {vysledek}");
    //                break;
    //            case "-":
    //                vysledek = firstNumber - secondNumber;
    //                Console.WriteLine($"{firstNumber} {firstOperator} {secondNumber} = {vysledek}");
    //                Console.WriteLine($"Výsledek: {vysledek}");
    //                break;
    //            case "*":
    //                vysledek = firstNumber * secondNumber;
    //                Console.WriteLine($"{firstNumber} {firstOperator} {secondNumber} = {vysledek}");
    //                Console.WriteLine($"Výsledek: {vysledek}");
    //                break;
    //            case "/":
    //                vysledek = firstNumber / secondNumber;
    //                Console.WriteLine($"{firstNumber} {firstOperator} {secondNumber} = {vysledek}");
    //                Console.WriteLine($"Výsledek: {vysledek}");
    //                break;
    //            case "^":
    //                vysledek = Umocni(firstNumber, (int)secondNumber);
    //                Console.WriteLine($"{firstNumber} {firstOperator} {(int)secondNumber} = {vysledek}");
    //                Console.WriteLine($"Výsledek: {vysledek}");
    //                break;
    //        }

    //        return vysledek;
    //    }
    //}
}
