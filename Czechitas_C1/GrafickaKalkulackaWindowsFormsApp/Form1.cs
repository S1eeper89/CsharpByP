namespace GrafickaKalkulackaWindowsFormsApp
{
    public partial class Calculator4every1 : Form
    {
        private Kalkulacka kalkulacka; // Instance kalkula�ky pro logiku
        private string aktualniOperator = ""; // Uchov�v� aktu�ln� oper�tor
        private double posledniCislo = 0; // Posledn� ��slo zadan� p�ed operac�

        public Calculator4every1()
        {
            InitializeComponent();
            kalkulacka = new Kalkulacka(); // Inicializace kalkula�ky
        }

        // Obsluha ��seln�ch tla��tek (ru�n� p�i�ad�me ka�d� tla��tko)
        private void ButtonCislo_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxVysledek.Text += button.Text; // P�id�n� ��sla k aktu�ln�mu vstupu
        }

        private void ButtonOperator_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            // Kontrola, zda je textBoxVysledek nepr�zdn�
            if (double.TryParse(textBoxVysledek.Text, out posledniCislo))
            {
                // �sp�n� p�evod
            }
            else
            {
                // Nastav�me v�choz� hodnotu
                posledniCislo = 0;
            }


            posledniCislo = double.Parse(textBoxVysledek.Text); // Ulo�en� posledn�ho ��sla
            aktualniOperator = button.Text; // Ulo�en� aktu�ln�ho oper�toru
            textBoxVysledek.Clear(); // Vymaz�n� pole pro zad�n� dal��ho ��sla
        }

        // Obsluha tla��tka "="
        private void ButtonRovnitko_Click(object sender, EventArgs e)
        {
            double druheCislo = double.Parse(textBoxVysledek.Text); // Na�ten� druh�ho ��sla

            // Vol�n� metod kalkula�ky podle oper�toru
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
                    MessageBox.Show("Neplatn� oper�tor!");
                    break;
            }

            // Zobrazen� v�sledku
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
            string value = button.Text; // Z�sk� text tla��tka
            // Zpracov�n� podle textu tla��tka
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

        }
    }
}
