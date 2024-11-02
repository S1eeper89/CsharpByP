﻿namespace DU_Lekce_6_DomaciUkol_test_2
{
    internal class Program
    {
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

        static double zadejPrvniCislo()
        {
            double firstNumber;
            string inputOne = Console.ReadLine();
            while (!double.TryParse(inputOne, out firstNumber))
            {
                Console.WriteLine("Nezadal jsi číslo, prosím zadej první číslo (a).");
                inputOne = Console.ReadLine();
            }
            return firstNumber;
        }
        static string zadejDalsiOperator()
        {
            Console.WriteLine("Zadej další operátor (+) (-) (*) (/) (^) nebo pro ukončení (x) ");

            string firstOperator = Console.ReadLine();
            while (!(firstOperator == "+" || firstOperator == "-" || firstOperator == "*" || firstOperator == "/" || firstOperator == "^" || firstOperator.ToLower() == "x"))
            {
                Console.WriteLine($"Nezadal jsi správný operátor, zadej operátor (+) (-) (*) (/) (x) ");
                firstOperator = Console.ReadLine();
            }
            //if (firstOperator.ToLower() == "x")
            //{
            //    return "x";
            //}
            return firstOperator;
        }
        static string zadejDalsiCislo(string dalsiOperator)
        {
            Console.WriteLine("Zadej další číslo (b), pro ukončení zadej (x).");

            string inputTwo = Console.ReadLine();
            double secondNumber = 0;
            while ((inputTwo.ToLower() != "x" && !double.TryParse(inputTwo, out secondNumber)) || (secondNumber == 0 && dalsiOperator == "/") || (dalsiOperator == "^" && secondNumber % 1 != 0))
            {
                if (secondNumber == 0 && dalsiOperator == "/")
                {
                    Console.WriteLine("Nulou nelze dělit, zadej prosím druhé číslo (b), nebo (x)");
                }
                else if (dalsiOperator == "^" && secondNumber % 1 != 0)
                {
                    Console.WriteLine("Nezadal jsi celé číslo, zadej prosím druhé číslo (b), nebo (x)");
                }
                else
                {
                    Console.WriteLine("Nezadal jsi číslo, zadej prosím druhé číslo (b), nebo (x)");
                }
                inputTwo = Console.ReadLine();
            }
            return inputTwo;

        }
        static double Vypocti(string firstOperator, double firstNumber, double secondNumber)
        {
            double vysledek = 0;

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

            return vysledek;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Začátek programu");
            bool ukoncitProgram = false;
            //bool prvniIterace = true;

            while (!ukoncitProgram)
            {
                double vysledek;

                //if (prvniIterace)
                //{
                    Console.WriteLine($"(a) (operator) (b) = (c) ");
                    Console.WriteLine("Zadej první číslo (a).");


                    double firstNumber = zadejPrvniCislo();
                    //prvniIterace = false;

                    Console.WriteLine($"({firstNumber}) (operator) (b) = (c) ");
                    Console.WriteLine("Zadej operátor (+) (-) (*) (/) (^) ");

                    string firstOperator = Console.ReadLine();
                    while (!(firstOperator == "+" || firstOperator == "-" || firstOperator == "*" || firstOperator == "/" || firstOperator == "^"))
                    {
                        Console.WriteLine($"Nezadal jsi správný operátor, zadej operátor (+) (-) (*) (/) ");
                        firstOperator = Console.ReadLine();
                    }

                    Console.WriteLine($"({firstNumber}) ({firstOperator}) (b) = (c) ");
                    Console.WriteLine("Zadej druhé číslo (b).");

                    string inputTwo = Console.ReadLine();
                    double secondNumber;
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
                    vysledek = 0;

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

                    Console.WriteLine($"{firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                    //return vysledek; // spatna cesta
                //}
                    while (true)
                    {

                        string dalsiOperator = zadejDalsiOperator();
                        if (dalsiOperator == "x")
                        {
                            break;
                        }
                        string vstupDalsiCislo = zadejDalsiCislo(dalsiOperator);
                        double.TryParse(vstupDalsiCislo, out double dalsiCislo);
                        if (vstupDalsiCislo == "x")
                        {
                            break;
                        }
                        double vypsaneDalsiCislo = vysledek;
                        switch (dalsiOperator)
                        {
                            case "+":
                                vysledek = vysledek + dalsiCislo;
                                Console.WriteLine($"{vypsaneDalsiCislo} {dalsiOperator} {secondNumber} = {vysledek}");
                                Console.WriteLine($"Výsledek: {vysledek}");
                                break;
                            case "-":
                                vysledek = vysledek - dalsiCislo;
                                Console.WriteLine($"{vypsaneDalsiCislo} {dalsiOperator} {secondNumber} = {vysledek}");
                                Console.WriteLine($"Výsledek: {vysledek}");
                                break;
                            case "*":
                                vysledek = vysledek * dalsiCislo;
                                Console.WriteLine($"{vypsaneDalsiCislo} {dalsiOperator} {secondNumber} = {vysledek}");
                                Console.WriteLine($"Výsledek: {vysledek}");
                                break;
                            case "/":
                                vysledek = vysledek / dalsiCislo;
                                Console.WriteLine($"{vypsaneDalsiCislo} {dalsiOperator} {secondNumber} = {vysledek}");
                                Console.WriteLine($"Výsledek: {vysledek}");
                                break;
                            case "^":
                                vysledek = Umocni(vysledek, (int)dalsiCislo);
                                Console.WriteLine($"{vypsaneDalsiCislo} {dalsiOperator} {(int)secondNumber} = {vysledek}");
                                Console.WriteLine($"Výsledek: {vysledek}");
                                break;
                        }
                }

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