namespace Lekce_2_summary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 2;

            int numberTwo = 5;

            int numberThree = numberOne + numberTwo;

            Console.WriteLine(numberThree);

            Console.WriteLine("Napis jmeno");

            string name = Console.ReadLine();

            if (name == "Admin")
            {
                Console.WriteLine("Jsi prihlasen s přihlášen s administrátorskými právy");
            }
            else if (name == "User")
            {
                Console.WriteLine("Jsi prihlasen s přihlášen s uživatelskými právy");
            }
            else
            {
                Console.WriteLine("Uzivatel je neznamy a nebyl prihlasen");
            }


            Console.WriteLine("Konec programu");

            int correctNumber = 666;


            int guessNumber = 666;

            if (guessNumber > correctNumber && guessNumber naber)

            else if (guessNumber > correctNumber)
            {
                Console.WriteLine("tip je příliš vysoký");
            }
            else if (guessNumber < correctNumber)
            {
                Console.WriteLine("tip je příliš nízký");
            }
            else if (guessNumber == correctNumber)
            {
                Console.WriteLine("gratuluji uživateli, uhádl jsi správně");
            }

            Console.WriteLine("Začátek programu");

            Console.WriteLine("Zadej první hodnotu.");

            string firstNumberText = Console.ReadLine();

            double firstNumber = double.Parse(firstNumberText);

            Console.WriteLine("Zadej operátor (+) (-) (*) (/) ");

            string firstOperator = Console.ReadLine();

            Console.WriteLine("Zadej druhou hodnotu.");

            string secondNumberText = Console.ReadLine();

            double secondNumber = double.Parse(secondNumberText);

            double vysledek;


            if (firstOperator == "+")
            {
                vysledek = firstNumber + secondNumber;
                Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
            }
            else if (firstOperator == "-")
            {
                vysledek = firstNumber - secondNumber;
                Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
            }
            else if (firstOperator == "*")
            {
                vysledek = firstNumber * secondNumber;
                Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
            }
            else if (firstOperator == "/")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("Nulou nelze dělit");
                }
                else
                {
                    vysledek = firstNumber / secondNumber;
                    Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                }
            }
            else
            {
                Console.WriteLine("Zadal jsi neplatný operátor");
            }


            Console.WriteLine("Konec Programu");

            Console.WriteLine("Začátek programu");

            // Ověření prvního čísla
            Console.WriteLine("Zadej první hodnotu.");
            string firstNumberText = Console.ReadLine();
            if (!double.TryParse(firstNumberText, out double firstNumber))
            {
                Console.WriteLine("Zadal jsi neplatný vstup pro první číslo.");
                return; // Konec programu
            }

            // Ověření operátoru
            Console.WriteLine("Zadej operátor (+) (-) (*) (/)");
            string firstOperator = Console.ReadLine();
            if (firstOperator != "+" && firstOperator != "-" && firstOperator != "*" && firstOperator != "/")
            {
                Console.WriteLine("Zadal jsi neplatný operátor.");
                return; // Konec programu
            }

            // Ověření druhého čísla
            Console.WriteLine("Zadej druhou hodnotu.");
            string secondNumberText = Console.ReadLine();
            if (!double.TryParse(secondNumberText, out double secondNumber))
            {
                Console.WriteLine("Zadal jsi neplatný vstup pro druhé číslo.");
                return; // Konec programu
            }

            // Výpočet výsledku
            double vysledek;
            if (firstOperator == "+")
            {
                vysledek = firstNumber + secondNumber;
                Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
            }
            else if (firstOperator == "-")
            {
                vysledek = firstNumber - secondNumber;
                Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
            }
            else if (firstOperator == "*")
            {
                vysledek = firstNumber * secondNumber;
                Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
            }
            else if (firstOperator == "/")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("Nulou nelze dělit.");
                }
                else
                {
                    vysledek = firstNumber / secondNumber;
                    Console.WriteLine($"Výsledek: {firstNumber} {firstOperator} {secondNumber} = {vysledek}");
                }
            }

            Console.WriteLine("Konec programu");



        }
    }
}
