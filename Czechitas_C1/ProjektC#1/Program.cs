namespace ProjektC_1
{
    internal class Program
    {
        // Metoda NactiOperator vypíše volitelné operátory a kontroluje platnost operátoru nebo výstupu, výstupem je string operator
        public static string NactiOperatorKonzole()
        {
            Console.WriteLine("Zadej operátor (+) (-) (*) (/) (^) nebo pro ukončení (x) ");
            string firstOperator = Console.ReadLine();
            while (!(Kalkulacka.JePlatnyOperator(firstOperator) || firstOperator.ToLower() == "x"))
            {
                Console.WriteLine($"Nezadal jsi správný operátor, zadej operátor (+) (-) (*) (/) (x) ");
                firstOperator = Console.ReadLine();
            }
            return firstOperator;
        }
        // Metoda NactiDesetinneCisloZKonzole parsuje vstup uživatele a kontroluje, že číslo je slučitelné se zvoleným operátorem, vstupem je operátor
        public static string NactiDesetinneCisloZKonzole(string firstOperator)
        {
            string inputTwo = Console.ReadLine();
            bool isSecondNumber = double.TryParse(inputTwo, out double secondNumber);

            while ((inputTwo.ToLower() != "x" && !double.TryParse(inputTwo, out secondNumber)) || (secondNumber == 0 && firstOperator == "/") || (firstOperator == "^" && secondNumber % 1 != 0))
            {
                if (inputTwo == "x")
                {
                    break;
                }
                else if (!double.TryParse(inputTwo, out secondNumber))
                {
                    Console.WriteLine("Nezadal jsi číslo zadej číslo, nebo (x) pro ukončení");
                }
                else if (secondNumber == 0 && firstOperator == "/")
                {
                    Console.WriteLine("Nulou nelze dělit, zadej číslo, nebo (x) pro ukončení");
                }
                else if (firstOperator == "^" && secondNumber % 1 != 0)
                {
                    Console.WriteLine("Nezadal jsi celé číslo, zadej celé číslo, nebo (x) pro ukončení");
                }
                inputTwo = Console.ReadLine();
            }
            return inputTwo;
        }

        static void Main(string[] args)
        {
            // hlavní cyklus kalkulačky začínající nulou
            bool ukoncitProgram = false;
            while (!ukoncitProgram)
            {
                // vytvoření první instance kalkulačky
                Kalkulacka kalkulacka = new Kalkulacka();
                Console.WriteLine($"Výsledek: {kalkulacka.VratAktualniVysledek()}");
                // tryparsovaný první vstup, který je následně kontrolovaný ve while cyklu
                Console.WriteLine("Zadej prvni číslo");
                bool isFirstNumber = double.TryParse(Console.ReadLine(), out double firstNumber);
                while (isFirstNumber == false)
                {
                    Console.WriteLine("Nezadal jsi číslo, zadej číslo.");
                    isFirstNumber = double.TryParse(Console.ReadLine(), out firstNumber);
                }
                kalkulacka.Secti(firstNumber);
                // spuštění while cyklu, kde se vykonávají operace mezi posledním výsledkem a novým číslem
                string firstOperator = null;
                while (firstOperator != "x")
                {
                    // zadání prvního operátoru ve vnitřním cyklu
                    firstOperator = NactiOperatorKonzole();
                    if (firstOperator == "x")
                    {
                        Console.WriteLine($"Konečný výsledek = {kalkulacka.VratAktualniVysledek()}");
                        break;
                    }
                    Console.WriteLine("Zadej další číslo, nebo (x) pro ukončení");
                    // zadání druhého čísla, které provádí operace oproti poslednímu výsledku 
                    string inputSecondNumber = NactiDesetinneCisloZKonzole(firstOperator);
                    // bohužel tady už potenciální celočíseln vstup opakovaně parsuji, protože mi prozí výstup přes x, nenapadlo mě elegantnější řešení :(
                    double.TryParse(inputSecondNumber, out double secondNumber);
                    // if podmínka, která mění operátor pro vnitřní while cyklus, aby ho ukončila a započala kalkulačku se zadáním provní hodnoty od nuly
                    if (inputSecondNumber == "x")
                    {
                        firstOperator = "x";
                    }
                    // blížíme se do cíle se switchem, který si na základě zadaného operátoru volá metody definované z logiky uložené v třídě Kalkulacka
                    switch (firstOperator)
                    {
                        case "+":
                            kalkulacka.Secti(secondNumber);
                            break;
                        case "-":
                            kalkulacka.Odecti(secondNumber);
                            break;
                        case "*":
                            kalkulacka.Nasob(secondNumber);
                            break;
                        case "/":
                            kalkulacka.Del(secondNumber);
                            break;
                        case "^":
                            kalkulacka.Umocni(secondNumber);
                            break;
                    }
                    Console.WriteLine($"Vysledek: {kalkulacka.VratAktualniVysledek()}");

                }
                //výstup z hlavního cyklu a ukončení programu
                Console.WriteLine("Chcete ukončit program? ano / ne");
                if (Console.ReadLine()?.ToLower() == "ano")
                {
                    Console.WriteLine("Konec Programu");
                    ukoncitProgram = true;
                }
            }
        }
    }
}
