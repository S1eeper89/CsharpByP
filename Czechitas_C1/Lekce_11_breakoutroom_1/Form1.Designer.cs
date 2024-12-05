namespace Lekce_11_breakoutroom_1
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
            button1 = new Button();
            button2 = new Button();
            labelPopisek = new Label();
            labelOdpoved = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(197, 188);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Hory";
            button1.UseVisualStyleBackColor = true;
            button1.Click += labelNasmeruj_Click;
            // 
            // button2
            // 
            button2.Location = new Point(500, 188);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "More";
            button2.UseVisualStyleBackColor = true;
            button2.Click += labelNasmeruj_Click;
            // 
            // labelPopisek
            // 
            labelPopisek.AutoSize = true;
            labelPopisek.Location = new Point(197, 100);
            labelPopisek.Name = "labelPopisek";
            labelPopisek.Size = new Size(139, 15);
            labelPopisek.TabIndex = 2;
            labelPopisek.Text = "Moje idealni dovolena je:";
            // 
            // labelOdpoved
            // 
            labelOdpoved.AutoSize = true;
            labelOdpoved.Location = new Point(342, 100);
            labelOdpoved.Name = "labelOdpoved";
            labelOdpoved.Size = new Size(57, 15);
            labelOdpoved.TabIndex = 3;
            labelOdpoved.Text = "Neznama";
            labelOdpoved.Click += labelNasmeruj_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelOdpoved);
            Controls.Add(labelPopisek);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label labelPopisek;
        private Label labelOdpoved;
    }
}
