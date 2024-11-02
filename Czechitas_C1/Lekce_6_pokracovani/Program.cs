namespace DU_Lekce_6_DomaciUkol_test
{
    internal class Program
    {
        static double Umocni(double mocnenec, int mocnitel)
        {
            if (mocnitel == 0) return 1;
            double vysledekUmocni = 1;
            int absMocnitel = Math.Abs(mocnitel);
            for (int i = 1; i <= absMocnitel; i++)
            {
                vysledekUmocni *= mocnenec;
            }
            return mocnitel < 0 ? 1 / vysledekUmocni : vysledekUmocni;
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
            string firstOperator = Console.ReadLine();
            while (!(firstOperator == "+" || firstOperator == "-" || firstOperator == "*" || firstOperator == "/" || firstOperator == "^"))
            {
                Console.WriteLine($"Nezadal jsi správný operátor, zadej operátor (+) (-) (*) (/) ");
                firstOperator = Console.ReadLine();
            }
            if (firstOperator.ToLower() == "x")
            {
                return "x";
            }
            return firstOperator;
        }

    static void Main(string[] args)
        {
            Console.WriteLine("Začátek programu");
            bool ukoncitProgram = false;
            bool prvniIterace = true;

            while (!ukoncitProgram)
            {
                if (prvniIterace)
                {
                    Console.WriteLine($"(a) (operator) (b) = (c) ");
                    Console.WriteLine("Zadej první číslo (a).");


                    double firstNumber = zadejPrvniCislo();
                    prvniIterace = false;

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
                    while (!double.TryParse(inputTwo, out secondNumber) || (secondNumber == 0 && firstOperator == "/") || (firstOperator == "^" && secondNumber != Math.Floor(secondNumber)))
                    {
                        if (secondNumber == 0 && firstOperator == "/")
                        {
                            Console.WriteLine("Nulou nelze dělit, zadej prosím druhé číslo (b)");
                        }
                        else if (firstOperator == "^" && secondNumber != Math.Floor(secondNumber))
                        {
                            Console.WriteLine("Nezadal jsi celé číslo, zadej prosím druhé číslo (b)");
                        }
                        else
                        {
                            Console.WriteLine("Nezadal jsi číslo, zadej prosím druhé číslo (b)");
                        }
                        inputTwo = Console.ReadLine();
                    }

                    double vysledek = firstOperator switch
                    {
                        "+" => firstNumber + secondNumber,
                        "-" => firstNumber - secondNumber,
                        "*" => firstNumber * secondNumber,
                        "/" => firstNumber / secondNumber,
                        "^" => Umocni(firstNumber, (int)secondNumber),
                        _ => 0
                    };

                    Console.WriteLine($"{firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                }
                string dalsiOperator = zadejDalsiOperator();
                if (dalsiOperator == "x")
                {
                    break;
                }



                //Console.WriteLine("Chcete ukončit program? ano / ne");

                if (Console.ReadLine()?.ToLower() == "ano")
                {
                    Console.WriteLine("Konec Programu");
                    ukoncitProgram = true;
                }
            }
        }
    }
}
