namespace Lekce_11_breakoutroom_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonVytvorUcet_Click(object sender, EventArgs e)
        {
            if (textBoxHesloUzivatele.TextLength >= 8)
            {
                labelVypisVyberu.Text = $"Uzivatel {textBoxJmenoUzivatele.Text} vytvoren.";
            }
            else
            {
                labelVypisVyberu.Text = $"Heslo je prilis krakte, zadej alespon 8 znaku.";
                labelVypisVyberu.BackColor = Color.Red;
            }
        }

        private void checkBoxSouhlasSPodminkami_CheckedChanged(object sender, EventArgs e)
        {
            buttonVytvorUcet.Enabled = checkBoxSouhlasSPodminkami.Checked;
        }
    }
}
