namespace ProjektC_1
{
    internal class Program
    {
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

        public static string NactiDesetinneCisloZKonzole(string firstOperator)
        {
            string inputTwo = Console.ReadLine();
            bool isSecondNumber = double.TryParse(inputTwo, out double secondNumber);

            while ((inputTwo.ToLower() != "x" && !double.TryParse(inputTwo, out secondNumber)) || (secondNumber == 0 && firstOperator == "/") || (firstOperator == "^" && secondNumber % 1 != 0))
            {
                if (inputTwo == "x")
                    break;
                if (secondNumber == 0 && firstOperator == "/")
                {
                    Console.WriteLine("Nulou nelze dělit, zadej číslo, nebo (x) pro ukonceni");
                }
                else if (firstOperator == "^" && secondNumber % 1 != 0)
                {
                    Console.WriteLine("Nezadal jsi celé číslo, zadej celé číslo, nebo (x) pro ukonceni");
                }
                else
                {
                    Console.WriteLine("Nezadal jsi číslo zadej cislo, nebo (x) pro ukonceni");
                }
                inputTwo = Console.ReadLine();
            }
            return inputTwo;
        }

        static void Main(string[] args)
        {
            bool ukoncitProgram = false;
            while (!ukoncitProgram)
            {
                Kalkulacka kalkulacka = new Kalkulacka();
                Console.WriteLine($"Vysledek: {kalkulacka.VratAktualniVysledek()}");

                Console.WriteLine("Zadej prvni cislo");
                bool isFirstNumber = double.TryParse(Console.ReadLine(), out double firstNumber);
                while (isFirstNumber == false)
                {
                    Console.WriteLine("Nezadal jsi cislo, zadej cislo.");
                    isFirstNumber = double.TryParse(Console.ReadLine(), out firstNumber);
                }
                kalkulacka.Secti(firstNumber);

                string firstOperator = null;

                while (firstOperator != "x")
                {

                    Console.WriteLine("Zadej operator.");

                    firstOperator = NactiOperatorKonzole();
                    if (firstOperator == "x")
                    {
                        Console.WriteLine($"Konečný výsledek = {kalkulacka.Result}");
                        break;
                    }

                    Console.WriteLine("Zadej dalsi císlo, nebo x pro ukonceni");

                    string inputSecondNumber = NactiDesetinneCisloZKonzole(firstOperator);

                    double.TryParse(inputSecondNumber, out double secondNumber);
                    if (inputSecondNumber == "x")
                    {
                        firstOperator = "x";
                    }

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
