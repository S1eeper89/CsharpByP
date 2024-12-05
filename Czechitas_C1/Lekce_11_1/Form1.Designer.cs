namespace Lekce_11_1
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
            buttonPozadiCervene = new Button();
            buttonPozadiModre = new Button();
            buttonPozadiRuzove = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonPozadiCervene
            // 
            buttonPozadiCervene.Location = new Point(293, 163);
            buttonPozadiCervene.Name = "buttonPozadiCervene";
            buttonPozadiCervene.Size = new Size(150, 46);
            buttonPozadiCervene.TabIndex = 0;
            buttonPozadiCervene.Text = "Cervena";
            buttonPozadiCervene.UseVisualStyleBackColor = true;
            buttonPozadiCervene.Click += zmenBarvuPozadi_Click;
            // 
            // buttonPozadiModre
            // 
            buttonPozadiModre.Location = new Point(449, 163);
            buttonPozadiModre.Name = "buttonPozadiModre";
            buttonPozadiModre.Size = new Size(150, 46);
            buttonPozadiModre.TabIndex = 1;
            buttonPozadiModre.Text = "Modra";
            buttonPozadiModre.UseVisualStyleBackColor = true;
            buttonPozadiModre.Click += zmenBarvuPozadi_Click;
            // 
            // buttonPozadiRuzove
            // 
            buttonPozadiRuzove.Location = new Point(605, 163);
            buttonPozadiRuzove.Name = "buttonPozadiRuzove";
            buttonPozadiRuzove.Size = new Size(150, 46);
            buttonPozadiRuzove.TabIndex = 2;
            buttonPozadiRuzove.Text = "Ruzova";
            buttonPozadiRuzove.UseVisualStyleBackColor = true;
            buttonPozadiRuzove.Click += zmenBarvuPozadi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 130);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(449, 130);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonPozadiRuzove);
            Controls.Add(buttonPozadiModre);
            Controls.Add(buttonPozadiCervene);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPozadiCervene;
        private Button buttonPozadiModre;
        private Button buttonPozadiRuzove;
        private Label label1;
        private Label label2;
    }
}
