namespace Lekce_11_breakoutroom_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxJmenoUzivatele = new TextBox();
            textBoxHesloUzivatele = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkBoxSouhlasSPodminkami = new CheckBox();
            buttonVytvorUcet = new Button();
            labelVypisVyberu = new Label();
            SuspendLayout();
            // 
            // textBoxJmenoUzivatele
            // 
            textBoxJmenoUzivatele.Location = new Point(159, 77);
            textBoxJmenoUzivatele.Name = "textBoxJmenoUzivatele";
            textBoxJmenoUzivatele.Size = new Size(100, 23);
            textBoxJmenoUzivatele.TabIndex = 0;
            textBoxJmenoUzivatele.TextChanged += textBox1_TextChanged;
            // 
            // textBoxHesloUzivatele
            // 
            textBoxHesloUzivatele.Location = new Point(159, 149);
            textBoxHesloUzivatele.Name = "textBoxHesloUzivatele";
            textBoxHesloUzivatele.Size = new Size(100, 23);
            textBoxHesloUzivatele.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 80);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 2;
            label1.Text = "Jmeno uzivatele:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 152);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "Heslo uzivatele:";
            // 
            // checkBoxSouhlasSPodminkami
            // 
            checkBoxSouhlasSPodminkami.AutoSize = true;
            checkBoxSouhlasSPodminkami.Location = new Point(59, 223);
            checkBoxSouhlasSPodminkami.Name = "checkBoxSouhlasSPodminkami";
            checkBoxSouhlasSPodminkami.Size = new Size(160, 19);
            checkBoxSouhlasSPodminkami.TabIndex = 4;
            checkBoxSouhlasSPodminkami.Text = "Souhlasim s podminkami";
            checkBoxSouhlasSPodminkami.UseVisualStyleBackColor = true;
            checkBoxSouhlasSPodminkami.CheckedChanged += checkBoxSouhlasSPodminkami_CheckedChanged;
            // 
            // buttonVytvorUcet
            // 
            buttonVytvorUcet.Enabled = false;
            buttonVytvorUcet.Location = new Point(59, 277);
            buttonVytvorUcet.Name = "buttonVytvorUcet";
            buttonVytvorUcet.Size = new Size(75, 23);
            buttonVytvorUcet.TabIndex = 5;
            buttonVytvorUcet.Text = "VytvorUcet";
            buttonVytvorUcet.UseVisualStyleBackColor = true;
            buttonVytvorUcet.Click += buttonVytvorUcet_Click;
            // 
            // labelVypisVyberu
            // 
            labelVypisVyberu.AutoSize = true;
            labelVypisVyberu.Location = new Point(59, 329);
            labelVypisVyberu.Name = "labelVypisVyberu";
            labelVypisVyberu.Size = new Size(0, 15);
            labelVypisVyberu.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelVypisVyberu);
            Controls.Add(buttonVytvorUcet);
            Controls.Add(checkBoxSouhlasSPodminkami);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxHesloUzivatele);
            Controls.Add(textBoxJmenoUzivatele);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxJmenoUzivatele;
        private TextBox textBoxHesloUzivatele;
        private Label label1;
        private Label label2;
        private CheckBox checkBoxSouhlasSPodminkami;
        private Button buttonVytvorUcet;
        private Label labelVypisVyberu;
    }
}
