namespace Lekce_6_DU
{
    internal class Program
    {
//        Další vylepšení vaší kalkulačky! 🤯
//umožněte uživateli střídavě zadávat čísla a operátory, dokud ho to neomrzí(zadá například X, přičemž ho akceptujte jenom při zadávání operátoru).
//BONUS: pokud si troufnete tak i během zadávání čísla
//pokud zjistíte, že uživatel požádal o ukončení programu, bude se vám zde hodit klíčové slůvko return, které stojí na řádku samostatně, následuje pouze středník return;.
//po každé operaci ukažte výsledek
//Takto by to mohlo vypadat v konzoli po dokončení příkladu:
//Zadej číslo:
//10
//Zadej operátor(+, -, *, /, ^):
//+
//Zadej číslo:
//7
//Výsledek: 10 + 7 = 17
//Zadej operátor(+, -, *, /, ^):
//-
//Zadej číslo:
//15
//Výsledek: 17 - 15 = 2
//Zadej operátor(+, -, *, /, ^):
//^
//Zadej číslo:
//5
//Výsledek: 2 ^ 5 = 32
//Zadej operátor(+, -, *, /, ^):
//X
//Kalkulačka končí.
        static double Umocni(double mocnenec, int mocnitel)
        {
            // metoda pro mocnění, řeší mocnění nulou, mocnění celými zápornými číli a mocnění celými kladnými čísli, neřeší neceločíslené mocnitele.
            if (mocnitel == 0)
            {
                return 1;
            }
            double vysledekUmocni = 1;
            int absMocnitel = Math.Abs(mocnitel);
            for (int i = 1; i <= absMocnitel; i++)
            {
                vysledekUmocni = vysledekUmocni * mocnenec;
            }
            if (mocnitel < 0)
            {
                return 1 / vysledekUmocni;
            }
            return vysledekUmocni;
        }
        //static double PokracujVOperaci(double mocnenec, int mocnitel)
        //{
        //    while (!double.TryParse(inputTwo, out secondNumber) || (secondNumber == 0 && firstOperator == "/") || (firstOperator == "^" && secondNumber % 1 != 0))
        //    {
        //        // Kontrola, zda se nejedná o dělení nulou
        //        if ((secondNumber == 0 && firstOperator == "/"))
        //        {
        //            Console.WriteLine("Nulou nelze dělit, zadej prosím druhé číslo (b)");
        //        }
        //        //Kontrola, zda se nejedná o mocnění zlomkem
        //        else if (firstOperator == "^" && secondNumber % 1 != 0)
        //        {
        //            Console.WriteLine("Nezadal jsi celé číslo, zadej prosím druhé číslo (b)");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Nezadal jsi číslo, zadej prosím druhé číslo (b)");
        //        }
        //        inputTwo = Console.ReadLine();
        //    }
        //    Console.WriteLine($"({firstNumber}) ({firstOperator}) ({secondNumber}) = (c) ");
        //    // Výpočet na základě zadaného operátoru pomocí switch s operátory +, -, *, /, ^
        //    double vysledek;
        //    switch (firstOperator)
        //    {
        //        case "+":
        //            vysledek = firstNumber + secondNumber;
        //            Console.WriteLine($"{firstNumber} {firstOperator} {secondNumber} = {vysledek}");
        //            Console.WriteLine($"Výsledek: {vysledek}");
        //            break;
        //        case "-":
        //            vysledek = firstNumber - secondNumber;
        //            Console.WriteLine($"{firstNumber} {firstOperator} {secondNumber} = {vysledek}");
        //            Console.WriteLine($"Výsledek: {vysledek}");
        //            break;
        //        case "*":
        //            vysledek = firstNumber * secondNumber;
        //            Console.WriteLine($"{firstNumber} {firstOperator} {secondNumber} = {vysledek}");
        //            Console.WriteLine($"Výsledek: {vysledek}");
        //            break;
        //        case "/":
        //            vysledek = firstNumber / secondNumber;
        //            Console.WriteLine($"{firstNumber} {firstOperator} {secondNumber} = {vysledek}");
        //            Console.WriteLine($"Výsledek: {vysledek}");
        //            break;
        //        case "^":
        //            vysledek = Umocni(firstNumber, (int)secondNumber);
        //            Console.WriteLine($"{firstNumber} {firstOperator} {(int)secondNumber} = {vysledek}");
        //            Console.WriteLine($"Výsledek: {vysledek}");
        //            break;
        //    }

        //}
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Začátek programu");
                bool ukoncitProgram = false!;
                bool prvniIterace = true;
                // cylus while pro iteraci celého procesu kalkulačky
                while (!ukoncitProgram)
                {
                    {
                        if (prvniIterace = true)
                        {
                        Console.WriteLine($"(a) (operator) (b) = (c) ");
                        Console.WriteLine("Zadej první číslo (a).");
                        double firstNumber;
                        string inputOne = Console.ReadLine();
                            // Cyklus while pro iteraci vstupu prvního čísla, dokud není zadáno platné číslo
                            while (!double.TryParse(inputOne, out firstNumber))
                            {
                                Console.WriteLine("Nezadal jsi číslo, prosím zadej první číslo (a).");
                                inputOne = Console.ReadLine();
                            }
                        }
                        prvniIterace = false;
                        Console.WriteLine($"({firstNumber}) (operator) (b) = (c) ");
                        Console.WriteLine("Zadej operátor (+) (-) (*) (/) (^) ");
                        // Cyklus while pro iteraci vstupu operátoru, dokud není zadán platný operátor 
                        string firstOperator = Console.ReadLine();
                        while (!(firstOperator == "+" || firstOperator == "-" || firstOperator == "*" || firstOperator == "/" || firstOperator == "^"))
                        {
                            Console.WriteLine($"Nezadal jsi správný operátor, zadej operátor (+) (-) (*) (/) ");
                            firstOperator = Console.ReadLine();
                        }
                        Console.WriteLine($"({firstNumber}) ({firstOperator}) (b) = (c) ");
                        Console.WriteLine("Zadej druhé číslo (b).");
                        // Pokud je operátor platný, pokračuje se zadáním druhého čísla
                        string inputTwo = Console.ReadLine();
                        double secondNumber;
                        // Cyklus while pro iteraci vstupu druhého čísla, dokud není zadáno platné číslo, ošetřené dělení nulou a mocnění neceločíselným mocnitelem
                        while (!double.TryParse(inputTwo, out secondNumber) || (secondNumber == 0 && firstOperator == "/") || (firstOperator == "^" && secondNumber % 1 != 0))
                        {
                            // Kontrola, zda se nejedná o dělení nulou
                            if ((secondNumber == 0 && firstOperator == "/"))
                            {
                                Console.WriteLine("Nulou nelze dělit, zadej prosím druhé číslo (b)");
                            }
                            //Kontrola, zda se nejedná o mocnění zlomkem
                            else if (firstOperator == "^" && secondNumber % 1 != 0)
                            {
                                Console.WriteLine("Nezadal jsi celé číslo, zadej prosím druhé číslo (b)");
                            }
                            else
                            {
                                Console.WriteLine("Nezadal jsi číslo, zadej prosím druhé číslo (b)");
                            }
                            inputTwo = Console.ReadLine();
                        }
                        Console.WriteLine($"({firstNumber}) ({firstOperator}) ({secondNumber}) = (c) ");
                        // Výpočet na základě zadaného operátoru pomocí switch s operátory +, -, *, /, ^
                        double vysledek;
                        switch (firstOperator)
                        {
                            case "+":
                                vysledek = firstNumber + secondNumber;
                                Console.WriteLine($"{firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                                Console.WriteLine($"Výsledek: {vysledek}");
                                break;
                            case "-":
                                vysledek = firstNumber - secondNumber;
                                Console.WriteLine($"{firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                                Console.WriteLine($"Výsledek: {vysledek}");
                                break;
                            case "*":
                                vysledek = firstNumber * secondNumber;
                                Console.WriteLine($"{firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                                Console.WriteLine($"Výsledek: {vysledek}");
                                break;
                            case "/":
                                vysledek = firstNumber / secondNumber;
                                Console.WriteLine($"{firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                                Console.WriteLine($"Výsledek: {vysledek}");
                                break;
                            case "^":
                                vysledek = Umocni(firstNumber, (int)secondNumber);
                                Console.WriteLine($"{firstNumber} {firstOperator} {(int)secondNumber} = {vysledek}");
                                Console.WriteLine($"Výsledek: {vysledek}");
                                break;
                        }
                    }
                    // Dotaz na uživatele, zda chce program ukončit
                    {
                        Console.WriteLine("Chcete ukončit program? ano / ne");
                        string dotazKonec = Console.ReadLine().ToLower();
                        if (dotazKonec == "ano")
                        {
                            Console.WriteLine("Konec Programu");
                            ukoncitProgram = true;
                        }
                    
                        // Pokud uživatel zadá cokoliv jiného než "ano", nezávisle na velikosti písmen, program se znovu spustí
                        // numerické metody pro výpočet ingerálů, obdelníková a lichoběžníková metoda
                    }
                    double vysledek = 100;
                    string xFiles = "sSs";
                    while (xFiles != "x")
                    {
                        vysledek = vysledek + 5;
                        xFiles = string Console.ReadLine();
                    }    
                }
            }
        }
    }
}
