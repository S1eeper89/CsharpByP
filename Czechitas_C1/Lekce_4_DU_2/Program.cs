namespace Lekce_4_DU_2_DOMA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Začátek programu");

                // cylus while pro iteraci celého procesu kalkulačky

                while (true)
                {
                    {
                        // definované proměnné pro první, druhé číslo a výsledek

                        double firstNumber;
                        double secondNumber;
                        double vysledek;

                        Console.WriteLine($"(a) (operator) (b) = (c) ");
                        Console.WriteLine("Zadej první číslo (a).");

                        string inputOne = Console.ReadLine();
                        bool isNumberOne = double.TryParse(inputOne, out firstNumber);

                        // Cyklus while pro iteraci vstupu prvního čísla, dokud není zadáno platné číslo

                        while (!isNumberOne)
                        {
                            Console.WriteLine("Nezadal jsi číslo, prosím zadej první číslo (a).");
                            inputOne = Console.ReadLine();
                            isNumberOne = double.TryParse(inputOne, out firstNumber);
                        }

                        Console.WriteLine($"({firstNumber}) (operator) (b) = (c) ");

                        Console.WriteLine("Zadej operátor (+) (-) (*) (/) ");


                        // Cyklus while pro iteraci vstupu operátoru, dokud není zadán platný operátor 
                        string firstOperator = Console.ReadLine();
                        bool isOperator = (firstOperator == "+" || firstOperator == "-" || firstOperator == "*" || firstOperator == "/");

                        while (!isOperator)
                        {
                            Console.WriteLine($"Nezadal jsi správný operátor, zadej operátor (+) (-) (*) (/) ");
                            firstOperator = Console.ReadLine();
                            // Kontrola platnosti operátoru (musí být +, -, *, nebo /)
                            isOperator = (firstOperator == "+" || firstOperator == "-" || firstOperator == "*" || firstOperator == "/");
                        }

                        // Pokud je operátor platný, pokračuje se zadáním druhého čísla
                        Console.WriteLine($"({firstNumber}) ({firstOperator}) (b) = (c) ");
                        Console.WriteLine("Zadej druhé číslo (b).");

                        // Cyklus while pro iteraci vstupu druhého čísla, dokud není zadáno platné číslo

                        string inputTwo = Console.ReadLine();
                        bool isNumberTwo = double.TryParse(inputTwo, out secondNumber);
                        bool devideNull = (secondNumber == 0) && (firstOperator == "/");
                        while (!isNumberTwo || devideNull)
                        // Pokud je zadaná nula a operátor je dělení, program nedovolí dělení nulou
                        {
                            if (!isNumberTwo)
                            {
                                Console.WriteLine("Nezadal jsi číslo, zadej prosím druhé číslo (b).");
                            }
                            // Kontrola, zda se nejedná o dělení nulou
                            else if (devideNull)
                            {
                                Console.WriteLine("Nulou nelze dělit, zadej prosím druhé číslo (b)");
                            }
                            inputTwo = Console.ReadLine();
                            isNumberTwo = double.TryParse(inputTwo, out secondNumber);
                            devideNull = (secondNumber == 0) && (firstOperator == "/");

                        }
                        Console.WriteLine($"({firstNumber}) ({firstOperator}) ({secondNumber}) = (c) ");

                        // Výpočet na základě zadaného operátoru pomocí switch
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



                        }
                    }
                    // Dotaz na uživatele, zda chce program ukončit
                    {
                        Console.WriteLine("Chcete ukončit program? ano / ne");
                        string dotazKonec = Console.ReadLine().ToLower();
                        if (dotazKonec == "ano")
                        {
                            Console.WriteLine("Konec Programu");
                            return;
                        }
                        // Pokud uživatel zadá cokoliv jiného než "ano", nezávisle na velikosti písmen, program se znovu spustí
                        // numerické metody pro výpočet ingerálů, obdelníková a lichoběžníková metoda
                    }
                }







            }
        }
    }
}
