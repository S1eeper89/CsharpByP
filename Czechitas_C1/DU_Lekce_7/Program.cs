namespace DU_Lekce_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulacka kalkulacka = new Kalkulacka();
            Console.WriteLine($"Vysledek: {kalkulacka.VratAktualniVysledek()}");

            Console.WriteLine("Zadej prvni cislo");
            bool isFirstNumber = double.TryParse(Console.ReadLine(), out double firstNumber);
            kalkulacka.Secti(firstNumber);

            Console.WriteLine("Zadej prvni operator.");
            string firstOperator = Console.ReadLine();
            
            if (kalkulacka.JePlatnyOperator(firstOperator))
            {
                Console.WriteLine("Operator je platny");
            }
            else
            {
                Console.WriteLine("Operator je neplatny");
                return;
            }
            Console.WriteLine("Zadej druhé číslo");
            bool isSecondNumber = double.TryParse(Console.ReadLine(), out double secondNumber);
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
    }
}