﻿namespace WindowsFormsCalculatorFromScratch
{
    partial class KalkulackaHH
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            textBox1 = new TextBox();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonEquals = new Button();
            buttonDel = new Button();
            label1 = new Label();
            label2 = new Label();
            buttonZmenHodnotu = new Button();
            buttonC = new Button();
            buttonRound = new Button();
            buttonPoint = new Button();
            checkBoxZaokruhliDve = new CheckBox();
            buttonSave = new Button();
            buttonLoad = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(167, 305);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += numberClick;
            // 
            // button2
            // 
            button2.Location = new Point(265, 305);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += numberClick;
            // 
            // button3
            // 
            button3.Location = new Point(364, 305);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += numberClick;
            // 
            // button4
            // 
            button4.Location = new Point(167, 264);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += numberClick;
            // 
            // button5
            // 
            button5.Location = new Point(265, 264);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += numberClick;
            // 
            // button6
            // 
            button6.Location = new Point(364, 264);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += numberClick;
            // 
            // button7
            // 
            button7.Location = new Point(167, 218);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += numberClick;
            // 
            // button8
            // 
            button8.Location = new Point(265, 218);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += numberClick;
            // 
            // button9
            // 
            button9.Location = new Point(364, 218);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += numberClick;
            // 
            // button0
            // 
            button0.Location = new Point(265, 346);
            button0.Name = "button0";
            button0.Size = new Size(75, 23);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += numberClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(478, 177);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(75, 23);
            buttonPlus.TabIndex = 11;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += tlacitkoZnamenko;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(478, 218);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(75, 23);
            buttonMinus.TabIndex = 12;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += tlacitkoZnamenko;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(478, 264);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(75, 23);
            buttonMultiply.TabIndex = 13;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += tlacitkoZnamenko;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(478, 305);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(75, 23);
            buttonDivide.TabIndex = 14;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += tlacitkoZnamenko;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(478, 346);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(75, 23);
            buttonEquals.TabIndex = 15;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += RovnaSeClick;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(364, 177);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(75, 23);
            buttonDel.TabIndex = 16;
            buttonDel.Text = "DEL";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += Umazclick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 85);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 85);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 18;
            // 
            // buttonZmenHodnotu
            // 
            buttonZmenHodnotu.Location = new Point(167, 346);
            buttonZmenHodnotu.Name = "buttonZmenHodnotu";
            buttonZmenHodnotu.Size = new Size(75, 23);
            buttonZmenHodnotu.TabIndex = 19;
            buttonZmenHodnotu.Text = "+/-";
            buttonZmenHodnotu.UseVisualStyleBackColor = true;
            buttonZmenHodnotu.Click += ZmenHodnotuClick;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(265, 177);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(75, 23);
            buttonC.TabIndex = 20;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += resetKalkulackyClick;
            // 
            // buttonRound
            // 
            buttonRound.Location = new Point(167, 177);
            buttonRound.Name = "buttonRound";
            buttonRound.Size = new Size(75, 23);
            buttonRound.TabIndex = 21;
            buttonRound.Text = "ROUND";
            buttonRound.UseVisualStyleBackColor = true;
            buttonRound.Click += buttonRoundClick;
            // 
            // buttonPoint
            // 
            buttonPoint.Location = new Point(364, 346);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(75, 23);
            buttonPoint.TabIndex = 22;
            buttonPoint.Text = ".";
            buttonPoint.UseVisualStyleBackColor = true;
            buttonPoint.Click += btnDecimal_Click;
            // 
            // checkBoxZaokruhliDve
            // 
            checkBoxZaokruhliDve.AutoSize = true;
            checkBoxZaokruhliDve.Location = new Point(478, 121);
            checkBoxZaokruhliDve.Name = "checkBoxZaokruhliDve";
            checkBoxZaokruhliDve.Size = new Size(96, 19);
            checkBoxZaokruhliDve.TabIndex = 23;
            checkBoxZaokruhliDve.Text = "ROUND TWO";
            checkBoxZaokruhliDve.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(167, 61);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 24;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(265, 61);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 25;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            // 
            // KalkulackaHH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(checkBoxZaokruhliDve);
            Controls.Add(buttonPoint);
            Controls.Add(buttonRound);
            Controls.Add(buttonC);
            Controls.Add(buttonZmenHodnotu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDel);
            Controls.Add(buttonEquals);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(textBox1);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "KalkulackaHH";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private TextBox textBox1;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonEquals;
        private Button buttonDel;
        private Label label1;
        private Label label2;
        private Button buttonZmenHodnotu;
        private Button buttonC;
        private Button buttonRound;
        private Button buttonPoint;
        private CheckBox checkBoxZaokruhliDve;
        private Button buttonSave;
        private Button buttonLoad;
    }
}
