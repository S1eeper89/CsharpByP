using System.Globalization;

namespace WindowsFormsCalculatorFromScratch
{
    public partial class KalkulackaHH : Form
    {
        private Kalkulacka kalkulacka;
        bool prvniIterace = true;
        bool zadavamNoveCislo = true;
        bool zadavamCisloPovysledku = false;
        string posledniOperator = "";
        double cislo;
        public KalkulackaHH()
        {
            kalkulacka = new Kalkulacka(0);
            InitializeComponent();
        }
        private void numberClick(object sender, EventArgs e)
        {
            Button tlacitko = (Button)sender;
            // uprava pro prvni iteraci s inicializaci vysledku
            //if (prvniIterace == true)
            //{
            //    kalkulacka.Secti(double.Parse(tlacitko.Text));
            //    prvniIterace = false;
            //}
            // if podminka umoznujici zacit po vysledku s novym cislem bez dalsiho operatoru
            if (zadavamCisloPovysledku == true)
            {
                textBox1.Text = "";
                zadavamCisloPovysledku = false;
                kalkulacka.VycistiAktualniVysledek();
            }
            // if podminka pro vymazani textboxu po zadani operatoru
            if (zadavamNoveCislo)
            {
                textBox1.Text = "";
                zadavamNoveCislo = false;
            }
            textBox1.Text += tlacitko.Text;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button tlacitkoZnamenko = (Button)sender;
            if (prvniIterace == true)
            {
                kalkulacka.NastavVysledek(double.Parse(textBox1.Text, CultureInfo.InvariantCulture));
                prvniIterace = false;
            }

            zadavamNoveCislo = true;
            cislo = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            posledniOperator = tlacitkoZnamenko.Text;
            label2.Text = tlacitkoZnamenko.Text;
            // bool umoznujici prepsat posledni vysledek novym cislem pro novy vypocet
            zadavamCisloPovysledku = false;
        }

        private void RovnaSeClick(object sender, EventArgs e)
        {
            bool jeCislo = double.TryParse(textBox1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out cislo);
            if (prvniIterace)
            {
                kalkulacka.NastavVysledek(cislo);
                prvniIterace = false;
            }
            else
            {
                switch (posledniOperator)
                {
                    case "+":
                        kalkulacka.Secti(cislo);
                        break;
                    case "-":
                        kalkulacka.Odecti(cislo);
                        break;
                    case "*":
                        kalkulacka.Nasob(cislo);
                        break;
                    case "/":
                        kalkulacka.Del(cislo);
                        break;
                    case "^":
                        kalkulacka.Umocni(cislo);
                        break;
                    default:
                        break;

                }

            }
            
            // bool umoznujici prepsat posledni vysledek novym cislem pro novy vypocet
            zadavamCisloPovysledku = true;
            double vysledek = kalkulacka.VratAktualniVysledek();
            textBox1.Text = vysledek.ToString(CultureInfo.InvariantCulture);
            label1.Text = $"= {vysledek.ToString(CultureInfo.InvariantCulture)}";

        }
        // metoda pro tlacitko DEL na mazani posledniho znaku
        private void Umazclick(object sender, EventArgs e)
        {
            //podminka pro ochrano pro mazani v pripade 0 znaku
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
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

        }
        private void resetKalkulackyClick(object sender, EventArgs e)
        {
            {
                // Resetuj instance kalkulaèky
                kalkulacka.VycistiAktualniVysledek();

                // Vyèisti textbox
                textBox1.Text = "0";

                // Resetuj stavové promìnné
                prvniIterace = true;
                zadavamNoveCislo = true;
                zadavamCisloPovysledku = false;
                posledniOperator = "";

                // Vyèisti štítky nebo další vizuální indikátory
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
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            // Pokud právì zadávám nové èíslo, pøiprav textBox na nový vstup
            if (zadavamNoveCislo)
            {
                textBox1.Text = "0";
                zadavamNoveCislo = false;
            }

            // Zkontroluj, jestli èíslo již obsahuje desetinnou teèku
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }
    }
}
