namespace Lekce_11_breakoutroom_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void labelOdpoved_Click(object sender, EventArgs e)
        {

        }
        private void labelNasmeruj_Click(object sender, EventArgs e)
        {
            Button tlacitko = (Button)sender;
            switch (tlacitko.Text)
            {
                case "Hory":
                    labelOdpoved.Text = tlacitko.Text;
                    break;
                case "More":
                    labelOdpoved.Text = tlacitko.Text;
                    break;
            }
        }
    }
}
