namespace Lekce_11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zmenBarvuPozadi_Click(object sender, EventArgs e)
        {

            Button tlacitko = (Button)sender;
            switch (tlacitko.Text)
            {
                case "Cervena":
                    this.BackColor = Color.Red;
                    break;
                case "Modra":
                    this.BackColor = Color.Blue;
                    break;
                case "Ruzova":
                    this.BackColor = Color.Pink;
                    break;
            }
        }
    }
}
