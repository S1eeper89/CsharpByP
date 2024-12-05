namespace GrafickaKalkulackaWindowsFormsApp
{
    public partial class Calculator4every1 : Form
    {
        private Kalkulacka kalkulacka; // Instance kalkulaèky pro logiku
        private string aktualniOperator = ""; // Uchovává aktuální operátor
        private double posledniCislo = 0; // Poslední èíslo zadané pøed operací

        public Calculator4every1()
        {
            InitializeComponent();
            kalkulacka = new Kalkulacka(); // Inicializace kalkulaèky
        }

        // Obsluha èíselných tlaèítek (ruènì pøiøadíme každé tlaèítko)
        private void ButtonCislo_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxVysledek.Text += button.Text; // Pøidání èísla k aktuálnímu vstupu
        }

        private void ButtonOperator_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            // Kontrola, zda je textBoxVysledek neprázdný
            if (double.TryParse(textBoxVysledek.Text, out posledniCislo))
            {
                // Úspìšný pøevod
            }
            else
            {
                // Nastavíme výchozí hodnotu
                posledniCislo = 0;
            }


            posledniCislo = double.Parse(textBoxVysledek.Text); // Uložení posledního èísla
            aktualniOperator = button.Text; // Uložení aktuálního operátoru
            textBoxVysledek.Clear(); // Vymazání pole pro zadání dalšího èísla
        }

        // Obsluha tlaèítka "="
        private void ButtonRovnitko_Click(object sender, EventArgs e)
        {
            double druheCislo = double.Parse(textBoxVysledek.Text); // Naètení druhého èísla

            // Volání metod kalkulaèky podle operátoru
            switch (aktualniOperator)
            {
                case "+":
                    kalkulacka.Secti(druheCislo);
                    break;
                case "-":
                    kalkulacka.Odecti(druheCislo);
                    break;
                case "*":
                    kalkulacka.Nasob(druheCislo);
                    break;
                case "/":
                    kalkulacka.Del(druheCislo);
                    break;
                case "^":
                    kalkulacka.Umocni(druheCislo);
                    break;
                default:
                    MessageBox.Show("Neplatný operátor!");
                    break;
            }

            // Zobrazení výsledku
            double vysledekProVysledek = kalkulacka.VratAktualniVysledek();
            textBoxVysledek.Text = vysledekProVysledek.ToString();
        }

        private void Calculator4every1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonErease_Click(object sender, EventArgs e)
        {

        }

        private void buttonErease_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonn1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string value = button.Text; // Získá text tlaèítka
            // Zpracování podle textu tlaèítka
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

        }
    }
}
