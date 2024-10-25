
//    Přidejte nový operátor mocnění(^). Pro operaci mocnění nepoužívejte funkci Math.Pow, ale napište si vlastní logiku.Stačí k tomu jeden for cyklus.Mocnění totiž není nic jiného než opakované násobení.

//Například:
//2^4=16 (dvě na čtvrtou) se dá rozepsat jako 2 * 2 * 2 * 2
//3^3=27 se dá rozepsat jako 3 * 3 * 3 apod.
//Předpokládejte, že mocnitel je celé kladné číslo.

//Muzete mit metodu double Umocni(double mocnenec, int mocnitel){ //vas kod mocneni}

namespace Lekce_5_DU
{
    internal class Program
    {
        static double Umocni(double mocnenec, int mocnitel)
        {
            if (mocnitel == 0)
            {
                return 1;
            }
            double mezikrok = 1;
            for (int i = 1; i <= mocnitel; i++)
            {
                mezikrok = mezikrok * mocnenec;
            }
            if (mocnitel < 0)
            {
                return 1 / mezikrok;
            }
            return mezikrok;


        }


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

                        Console.WriteLine("Zadej operátor (+) (-) (*) (/) (^) ");


                        //Console.WriteLine("Zadej Mocnence");
                        //string vstupMocnenec = Console.ReadLine();
                        //String.IsNullOrEmpty(vstupMocnenec);
                        //isNumberOne = double.TryParse(vstupMocnenec, out double mocnenec);
                        //bool notEmptyOne = String.IsNullOrEmpty(vstupMocnenec);
                        //while (notEmptyOne || !isNumberOne)
                        //{
                        //    Console.WriteLine("Zadej Mocnence, cislo!");
                        //    string vstup2 = Console.ReadLine();
                        //    isNumberOne = double.TryParse(vstupMocnenec, out mocnenec);
                        //    notEmptyOne = String.IsNullOrEmpty(vstupMocnenec);
                        //}



                        //Console.WriteLine("Zadej Mocnitele");
                        //string vstupMocnitel = Console.ReadLine();
                        //String.IsNullOrEmpty(vstupMocnitel);
                        //bool isNumberTwo = double.TryParse(vstupMocnitel, out double mocnitel);
                        //bool notEmptyTwo = String.IsNullOrEmpty(vstupMocnitel);
                        //while (notEmptyTwo || !isNumberOne)
                        //{
                        //    Console.WriteLine("Zadej Mocnence, cislo!");
                        //    string vstup2 = Console.ReadLine();
                        //    isNumberOne = double.TryParse(vstupMocnitel, out mocnitel);
                        //    notEmptyTwo = String.IsNullOrEmpty(vstupMocnitel);
                        //}


                        // Cyklus while pro iteraci vstupu operátoru, dokud není zadán platný operátor 
                        string firstOperator = Console.ReadLine();
                        bool isOperator = (firstOperator == "+" || firstOperator == "-" || firstOperator == "*" || firstOperator == "/" || firstOperator == "^");

                        while (!isOperator)
                        {
                            Console.WriteLine($"Nezadal jsi správný operátor, zadej operátor (+) (-) (*) (/) ");
                            firstOperator = Console.ReadLine();
                            // Kontrola platnosti operátoru (musí být +, -, *, nebo /)
                            isOperator = (firstOperator == "+" || firstOperator == "-" || firstOperator == "*" || firstOperator == "/" || firstOperator == "^");
                        }

                        // Pokud je operátor platný, pokračuje se zadáním druhého čísla
                        Console.WriteLine($"({firstNumber}) ({firstOperator}) (b) = (c) ");
                        Console.WriteLine("Zadej druhé číslo (b).");

                        // Cyklus while pro iteraci vstupu druhého čísla, dokud není zadáno platné číslo

                        string inputTwo = Console.ReadLine();
                        bool doubleOperator = (firstOperator == "+" || firstOperator == "-" || firstOperator == "*" || firstOperator == "/");
                        bool intOperator = (firstOperator == "^");
                        bool isIntNumberTwo = int.TryParse(inputTwo, out int intSecondNumber);

                        //bool correctParse = ((doubleOperator && isDoubleNumberTwo) || (intOperator && isIntNumberTwo));
                        //bool devideNull = (secondNumber == 0) && (firstOperator == "/");

                        //while (!correctParse || devideNull)
                        // Pokud je zadaná nula a operátor je dělení, program nedovolí dělení nulou
                        {
                            if (doubleOperator)
                            {
                                double secondNumber;
                                bool isDoubleNumberTwo = double.TryParse(inputTwo, out double doubleSecondNumber);
                                bool devideNull = (doubleSecondNumber == 0) && (firstOperator == "/");
                                while (!isDoubleNumberTwo || devideNull)
                                {
                                    if (!isDoubleNumberTwo)
                                    {
                                        Console.WriteLine("Nezadal jsi číslo, zadej prosím druhé číslo (b).");
                                    }
                                    // Kontrola, zda se nejedná o dělení nulou
                                    else if (devideNull)
                                    {
                                        Console.WriteLine("Nulou nelze dělit, zadej prosím druhé číslo (b)");
                                    }
                                    inputTwo = Console.ReadLine();
                                    isDoubleNumberTwo = double.TryParse(inputTwo, out doubleSecondNumber);
                                    devideNull = (doubleSecondNumber == 0) && (firstOperator == "/");
                                    secondNumber = doubleSecondNumber;
                                }

                            }
                            if (intOperator)
                            {
                                bool isAbsoluteNumber = (intSecondNumber >= 0);
                                int secondNumber;
                                while (!isIntNumberTwo || !isAbsoluteNumber)
                                    
                                {
                                    if (!isIntNumberTwo)
                                    {
                                        Console.WriteLine("Nezadal jsi číslo, zadej prosím druhé číslo (b).");
                                    }
                                    // Kontrola, zda se nejedná o dělení nulou
                                    else if (isAbsoluteNumber)
                                    {
                                        Console.WriteLine("Nezadal jsi celé, kladné číslo, zadej prosím druhé číslo (b)");
                                    }
                                    inputTwo = Console.ReadLine();
                                    isIntNumberTwo = int.TryParse(inputTwo, out intSecondNumber);
                                    isAbsoluteNumber = (intSecondNumber >= 0);
                                    secondNumber = intSecondNumber;
                                }
                            }
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
                            case "^":
                                vysledek = Umocni(firstNumber, secondNumber);
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
