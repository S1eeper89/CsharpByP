namespace Lekce_11_breakoutroom_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOdeslat_Click(object sender, EventArgs e)
        {
            label1.Text = "Odeslano";
            label2.Text = textBoxVstupUzivatele.Text;

        }

        private void checkBoxPodminky_CheckedChanged(object sender, EventArgs e)
        {
            buttonOdeslat.Enabled = checkBoxPodminky.Checked;
            textBoxVstupUzivatele.Enabled = checkBoxPodminky.Checked;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
