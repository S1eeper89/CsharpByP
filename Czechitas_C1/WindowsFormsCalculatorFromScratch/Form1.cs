using System.Globalization;

namespace WindowsFormsCalculatorFromScratch
{
    public partial class KalkulackaHH : Form
    {
        private Kalkulacka kalkulacka;
        bool zadavamCislo;
        string posledniOperator = "";
        double cislo;
        bool preskakujiRovnaSe = false;
        public KalkulackaHH()
        {
            InitializeComponent();
            kalkulacka = new Kalkulacka(0);
            ObnovStav();
        }
        private void numberClick(object sender, EventArgs e)
        {
            Button tlacitko = (Button)sender;
            // pokud zaciname nove cislo, vycisti textbox
            if (zadavamCislo)
            {
                textBox1.Text = "";
                zadavamCislo = false;
            }
            // pridej cislo do textboxu
            textBox1.Text += tlacitko.Text;
        }

        private void tlacitkoZnamenko(object sender, EventArgs e)
        {
            Button tlacitkoZnamenko = (Button)sender;

            // pokud se operator zadava po cisle
            if (!zadavamCislo)
            {
                cislo = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                // zobrazeni operatoru
                if (!string.IsNullOrEmpty(posledniOperator))
                {
                    ProvedOperaci(posledniOperator, cislo);
                }
                else
                {
                    kalkulacka.NastavVysledek(cislo);
                }
            }

            //nastaveni noveho operatoru
            posledniOperator = tlacitkoZnamenko.Text;
            zadavamCislo = true;
            label2.Text = posledniOperator;
            if (posledniOperator == "/" && cislo == 0)
            {
                textBox1.Text = "Nulou nelze d�lit";
                zadavamCislo = true;
                return;
            }
            if (preskakujiRovnaSe)
            {
                // Zobraz�me v�sledek
                double vysledek = kalkulacka.VratAktualniVysledek();
                textBox1.Text = vysledek.ToString(CultureInfo.InvariantCulture);
                label1.Text = $"= {vysledek}";

                // P�ipraveno na nov� zad�v�n�
                zadavamCislo = true;
                posledniOperator = ""; // Reset oper�toru

                if (checkBoxZaokruhliDve.Checked)
                {
                    kalkulacka.ZaokrouhliNaDveDesetinnaMista();
                    vysledek = kalkulacka.VratAktualniVysledek();
                    textBox1.Text = vysledek.ToString(CultureInfo.InvariantCulture);
                    label1.Text = $"= {vysledek}";

                }
            }
            preskakujiRovnaSe = true;

        }
        private void ProvedOperaci(string operace, double hodnota)
        {
            switch (operace)
            {
                case "+":
                    kalkulacka.Secti(hodnota);
                    break;
                case "-":
                    kalkulacka.Odecti(hodnota);
                    break;
                case "*":
                    kalkulacka.Nasob(hodnota);
                    break;
                case "/":
                    kalkulacka.Del(hodnota);
                 
                    break;
                default:
                    MessageBox.Show("Nezn�m� oper�tor!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); //melo by uz byt zbytecne
                    break;
            }
        }


        private void RovnaSeClick(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out cislo))
            {
                MessageBox.Show("Neplatn� ��slo!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ( cislo == 0)
            {

            }

            // Provedeme operaci, pokud existuje platn� oper�tor
            if (!string.IsNullOrEmpty(posledniOperator))
            {
                ProvedOperaci(posledniOperator, cislo);
            }
            if (posledniOperator == "/" && cislo == 0)
            {
                textBox1.Text = "Nulou nelze d�lit";
                zadavamCislo = true;
            }
            else
            {
                // Zobraz�me v�sledek
                double vysledek = kalkulacka.VratAktualniVysledek();
                textBox1.Text = vysledek.ToString(CultureInfo.InvariantCulture);
                label1.Text = $"= {vysledek}";

                // P�ipraveno na nov� zad�v�n�
                zadavamCislo = true;
                posledniOperator = ""; // Reset oper�toru

                if (checkBoxZaokruhliDve.Checked)
                {
                    kalkulacka.ZaokrouhliNaDveDesetinnaMista();
                    vysledek = kalkulacka.VratAktualniVysledek();
                    textBox1.Text = vysledek.ToString(CultureInfo.InvariantCulture);
                    label1.Text = $"= {vysledek}";

                }
            }
        }

        // metoda pro uvedeni kalkulackz do vychoziho stavu
        private void resetKalkulackyClick(object sender, EventArgs e)
        {
            ObnovStav();
        }

        // metoda pro tlacitko DEL na mazani posledniho znaku
        private void Umazclick(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)  //podminka pro ochrano pro mazani v pripade 0 znaku

            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "0";
                zadavamCislo = true;
            }
        }
        //funkce pro zmenu zmanenka
        private void ZmenHodnotuClick(object sender, EventArgs e)
        {
            //osetreni prazdneho vstupu pro zmenu znamenka 
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "0";
            }
            double zmenHodnotu = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = (-zmenHodnotu).ToString(CultureInfo.InvariantCulture);
            zadavamCislo = false;

        }
        private void ObnovStav()
        {
            {
                // Resetuj instance kalkula�ky
                kalkulacka.VycistiAktualniVysledek();

                // Vy�isti textbox
                textBox1.Text = "0";

                // Resetuj stavov� prom�nn�
                zadavamCislo = true;
                posledniOperator = "";
                label1.Text = "";
                label2.Text = "";

                // Vy�isti �t�tky nebo dal�� vizu�ln� indik�tory
                label1.Text = "";
                label2.Text = "";
            }
        }
        // Metoda pro ziskani zaokrouhleneho vysledeku
        private void buttonRoundClick(object sender, EventArgs e)
        {
            double zaokrouhlenyVysledek = kalkulacka.VratAktualniVysledek();
            textBox1.Text = zaokrouhlenyVysledek.ToString();
           
        }
        // gombik pro zaokruhlovani
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
                kalkulacka.NastavVysledek(0);
            }
            zadavamCislo = false;
        }
    }
}
