namespace ProjektC_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej prvni cislo");
            ;
            double firstNumber;
            bool isFirstNumber = double.TryParse(Console.ReadLine(), out firstNumber);
            while (jePrvnicislo == false)
            {
                isFirstNumber.WriteLine("Nezadal jsi cislo, zadej cislo.");
                isFirstNumber = double.TryParse(Console.ReadLine(), out firstNumber);
            }
            Console.WriteLine("Zadej prvni operator.");
            string firstOperator = Console.ReadLine();
            bool jeOperator = (firstOperator == "+" || firstOperator == "-" || firstOperator == "*" || firstOperator == "/" || firstOperator == "^" || firstOperator.ToLower() == "x");
            while (!jeOperator)
            {
                Console.WriteLine("Nezadal jsi spravny operator, zadej operátor (+) (-) (*) (/) (^)");
                firstOperator = Console.ReadLine();
                jeOperator = (firstOperator == "+" || firstOperator == "-" || firstOperator == "*" || firstOperator == "/" || firstOperator == "^" || firstOperator.ToLower() == "x");
            }
            bool isSecondNumber = ;
            
            
            
            
            
            
            
            
            Kalkulacka prvniPriklad = new Kalkulacka(2, "^", 0);
            double vysledek = prvniPriklad.Umocni();
            Console.WriteLine(vysledek);
        }
        public static void Test()
        {
            Console.WriteLine("blabla");
        }
    }
}
