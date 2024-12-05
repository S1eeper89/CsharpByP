namespace Lekce_11_breakoutroom_2
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
            buttonOdeslat = new Button();
            checkBoxPodminky = new CheckBox();
            label1 = new Label();
            textBoxVstupUzivatele = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonOdeslat
            // 
            buttonOdeslat.Enabled = false;
            buttonOdeslat.Location = new Point(210, 89);
            buttonOdeslat.Name = "buttonOdeslat";
            buttonOdeslat.Size = new Size(150, 46);
            buttonOdeslat.TabIndex = 0;
            buttonOdeslat.Text = "Odeslat";
            buttonOdeslat.UseVisualStyleBackColor = true;
            buttonOdeslat.Click += buttonOdeslat_Click;
            // 
            // checkBoxPodminky
            // 
            checkBoxPodminky.AutoSize = true;
            checkBoxPodminky.Location = new Point(225, 162);
            checkBoxPodminky.Name = "checkBoxPodminky";
            checkBoxPodminky.Size = new Size(112, 19);
            checkBoxPodminky.TabIndex = 1;
            checkBoxPodminky.Text = "Povolit Odeslani";
            checkBoxPodminky.UseVisualStyleBackColor = true;
            checkBoxPodminky.CheckedChanged += checkBoxPodminky_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 211);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // textBoxVstupUzivatele
            // 
            textBoxVstupUzivatele.Enabled = false;
            textBoxVstupUzivatele.Location = new Point(210, 263);
            textBoxVstupUzivatele.Name = "textBoxVstupUzivatele";
            textBoxVstupUzivatele.Size = new Size(100, 23);
            textBoxVstupUzivatele.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 238);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 4;
            label2.Text = "Text od Uzivatele";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBoxVstupUzivatele);
            Controls.Add(label1);
            Controls.Add(checkBoxPodminky);
            Controls.Add(buttonOdeslat);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOdeslat;
        private CheckBox checkBoxPodminky;
        private Label label1;
        private TextBox textBoxVstupUzivatele;
        private Label label2;
    }
}
