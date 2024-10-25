namespace Lekce_4_DU
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
                        Console.WriteLine($"(a) (operator) (b) = (c) ");

                        Console.WriteLine("Zadej první číslo (a).");

                        string inputOne = Console.ReadLine();
                        bool isNumber = double.TryParse();


                        // definované proměnné pro první, druhé číslo a výsledek

                        double firstNumber;
                        double secondNumber;
                        double vysledek;
                        string firstOperator;
                        string dotazKonec;
                        bool isNumber;
                        bool isOperator;

                        // Cyklus while pro iteraci vstupu prvního čísla, dokud není zadáno platné číslo

                        isNumber = double.TryParse(inputOne, out firstNumber);

                        while (!isNumber)
                        {
                            Console.WriteLine("Nezadal jsi číslo, prosím zadej první číslo (a).");
                            isNumber = double.TryParse(inputOne, out firstNumber);
                        }

                        Console.WriteLine($"({firstNumber}) (operator) (b) = (c) ");

                        Console.WriteLine("Zadej operátor (+) (-) (*) (/) ");


                        // Cyklus while pro iteraci vstupu operátoru, dokud není zadán platný operátor 
                        //bool isOperator

                        while (true)
                        {
                            firstOperator = Console.ReadLine();
                            // Kontrola platnosti operátoru (musí být +, -, *, nebo /)
                            if (firstOperator == "+" || firstOperator == "-" || firstOperator == "*" || firstOperator == "/")
                            // Pokud je operátor platný, pokračuje se zadáním druhého čísla
                            {
                                Console.WriteLine($"({firstNumber}) ({firstOperator}) (b) = (c) ");
                                Console.WriteLine("Zadej druhé číslo (b).");
                                break;
                            }
                            else
                            // Pokud je zadaný operátor neplatný, program se znovu dotáže
                            {
                                Console.WriteLine($"Nezadal jsi správný operátor, zadej operátor (+) (-) (*) (/) ");
                            }
                        }
                        // Cyklus while pro iteraci vstupu druhého čísla, dokud není zadáno platné číslo
                        while (true)
                        {
                            if (double.TryParse(Console.ReadLine(), out secondNumber))
                            {
                                // Kontrola, zda se nejedná o dělení nulou
                                if ((secondNumber == 0) && (firstOperator == "/"))
                                // Pokud je zadaná nula a operátor je dělení, program nedovolí dělení nulou
                                {
                                    Console.WriteLine("Nulou nelze dělit, zadej prosím druhé číslo (b)");
                                }
                                else
                                // Pokud je vstup platný, vypíše se vzorec a cyklus se ukončí
                                {
                                    Console.WriteLine($"({firstNumber}) ({firstOperator}) ({secondNumber}) = (c) ");
                                    break;
                                }
                            }
                            else
                            // Pokud je zadané číslo neplatné, program se znovu dotáže
                            {
                                Console.WriteLine("Nezadal jsi číslo, zadej prosím druhé číslo (b).");
                            }
                        }


                        // Výpočet na základě zadaného operátoru pomocí switch
                        switch (firstOperator)
                        {
                            case "+":
                                vysledek = firstNumber + secondNumber;
                                Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                                break;
                            case "-":
                                vysledek = firstNumber - secondNumber;
                                Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                                break;
                            case "*":
                                vysledek = firstNumber * secondNumber;
                                Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                                break;

                            // Ošetření dělení nulou, je pokryto výše, má smysl ho nechat pro jistotu, nebo se podobné redudnantní prvky považují za chybu?
                            case "/":
                                if (secondNumber == 0)
                                {
                                    Console.WriteLine("Nulou nelze dělit");
                                }
                                else
                                {
                                    vysledek = firstNumber / secondNumber;
                                    Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");

                                }
                                break;



                        }
                    }
                    // Dotaz na uživatele, zda chce program ukončit
                    {
                        Console.WriteLine("Chcete ukončit program? ano / ne");
                        dotazKonec = Console.ReadLine().ToLower();
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
