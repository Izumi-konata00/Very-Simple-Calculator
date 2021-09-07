
namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Screen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_times = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.buttonLeftBracket = new System.Windows.Forms.Button();
            this.buttonRightBracket = new System.Windows.Forms.Button();
            this.buttonClearLast = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.memorySet = new System.Windows.Forms.Button();
            this.memoryReset = new System.Windows.Forms.Button();
            this.memoryPlus = new System.Windows.Forms.Button();
            this.memoryMinus = new System.Windows.Forms.Button();
            this.memoryDsiplay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Screen.Dock = System.Windows.Forms.DockStyle.Top;
            this.Screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Screen.Location = new System.Drawing.Point(0, 0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(351, 111);
            this.Screen.TabIndex = 0;
            this.Screen.Text = "0";
            this.Screen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(93, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(174, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(12, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(93, 329);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(174, 329);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 30);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(12, 365);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 30);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(93, 365);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 30);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(174, 365);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 30);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(12, 401);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(237, 30);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_plus.Location = new System.Drawing.Point(255, 293);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(75, 30);
            this.button_plus.TabIndex = 11;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_minus.Location = new System.Drawing.Point(255, 329);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(75, 30);
            this.button_minus.TabIndex = 12;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_Click);
            // 
            // button_times
            // 
            this.button_times.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_times.Location = new System.Drawing.Point(255, 365);
            this.button_times.Name = "button_times";
            this.button_times.Size = new System.Drawing.Size(75, 30);
            this.button_times.TabIndex = 13;
            this.button_times.Text = "×";
            this.button_times.UseVisualStyleBackColor = true;
            this.button_times.Click += new System.EventHandler(this.button_Click);
            // 
            // button_div
            // 
            this.button_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_div.Location = new System.Drawing.Point(255, 401);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(75, 30);
            this.button_div.TabIndex = 14;
            this.button_div.Text = "÷";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_Click);
            // 
            // equals
            // 
            this.equals.Dock = System.Windows.Forms.DockStyle.Right;
            this.equals.FlatAppearance.BorderSize = 0;
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equals.Location = new System.Drawing.Point(235, 0);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(116, 53);
            this.equals.TabIndex = 15;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.Location = new System.Drawing.Point(13, 135);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 30);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // factorial
            // 
            this.factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.factorial.Location = new System.Drawing.Point(174, 257);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(75, 30);
            this.factorial.TabIndex = 17;
            this.factorial.Text = "x!";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // powerButton
            // 
            this.powerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powerButton.Location = new System.Drawing.Point(255, 257);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(75, 30);
            this.powerButton.TabIndex = 18;
            this.powerButton.Text = "^";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.button_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sqrtButton.Location = new System.Drawing.Point(255, 221);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(75, 30);
            this.sqrtButton.TabIndex = 19;
            this.sqrtButton.Text = "√";
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
            // 
            // buttonLeftBracket
            // 
            this.buttonLeftBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLeftBracket.Location = new System.Drawing.Point(12, 257);
            this.buttonLeftBracket.Name = "buttonLeftBracket";
            this.buttonLeftBracket.Size = new System.Drawing.Size(75, 30);
            this.buttonLeftBracket.TabIndex = 20;
            this.buttonLeftBracket.Text = "(";
            this.buttonLeftBracket.UseVisualStyleBackColor = true;
            this.buttonLeftBracket.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonRightBracket
            // 
            this.buttonRightBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRightBracket.Location = new System.Drawing.Point(93, 257);
            this.buttonRightBracket.Name = "buttonRightBracket";
            this.buttonRightBracket.Size = new System.Drawing.Size(75, 30);
            this.buttonRightBracket.TabIndex = 21;
            this.buttonRightBracket.Text = ")";
            this.buttonRightBracket.UseVisualStyleBackColor = true;
            this.buttonRightBracket.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonClearLast
            // 
            this.buttonClearLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClearLast.Location = new System.Drawing.Point(94, 135);
            this.buttonClearLast.Name = "buttonClearLast";
            this.buttonClearLast.Size = new System.Drawing.Size(75, 30);
            this.buttonClearLast.TabIndex = 22;
            this.buttonClearLast.Text = "CE";
            this.buttonClearLast.UseVisualStyleBackColor = true;
            this.buttonClearLast.Click += new System.EventHandler(this.buttonClearLast_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDot.FlatAppearance.BorderSize = 0;
            this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDot.Location = new System.Drawing.Point(0, 0);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(235, 53);
            this.buttonDot.TabIndex = 23;
            this.buttonDot.Text = ",";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.button_Click);
            // 
            // memorySet
            // 
            this.memorySet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.memorySet.Location = new System.Drawing.Point(12, 171);
            this.memorySet.Name = "memorySet";
            this.memorySet.Size = new System.Drawing.Size(75, 30);
            this.memorySet.TabIndex = 24;
            this.memorySet.Text = "M";
            this.memorySet.UseVisualStyleBackColor = true;
            this.memorySet.Click += new System.EventHandler(this.memorySet_Click);
            // 
            // memoryReset
            // 
            this.memoryReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.memoryReset.Location = new System.Drawing.Point(94, 171);
            this.memoryReset.Name = "memoryReset";
            this.memoryReset.Size = new System.Drawing.Size(75, 30);
            this.memoryReset.TabIndex = 25;
            this.memoryReset.Text = "MR";
            this.memoryReset.UseVisualStyleBackColor = true;
            this.memoryReset.Click += new System.EventHandler(this.memoryReset_Click);
            // 
            // memoryPlus
            // 
            this.memoryPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.memoryPlus.Location = new System.Drawing.Point(174, 171);
            this.memoryPlus.Name = "memoryPlus";
            this.memoryPlus.Size = new System.Drawing.Size(75, 30);
            this.memoryPlus.TabIndex = 26;
            this.memoryPlus.Text = "M+";
            this.memoryPlus.UseVisualStyleBackColor = true;
            this.memoryPlus.Click += new System.EventHandler(this.memoryPlus_Click);
            // 
            // memoryMinus
            // 
            this.memoryMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.memoryMinus.Location = new System.Drawing.Point(254, 171);
            this.memoryMinus.Name = "memoryMinus";
            this.memoryMinus.Size = new System.Drawing.Size(75, 30);
            this.memoryMinus.TabIndex = 27;
            this.memoryMinus.Text = "M-";
            this.memoryMinus.UseVisualStyleBackColor = true;
            this.memoryMinus.Click += new System.EventHandler(this.memoryMinus_Click);
            // 
            // memoryDsiplay
            // 
            this.memoryDsiplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.memoryDsiplay.Location = new System.Drawing.Point(174, 135);
            this.memoryDsiplay.Name = "memoryDsiplay";
            this.memoryDsiplay.Size = new System.Drawing.Size(75, 30);
            this.memoryDsiplay.TabIndex = 28;
            this.memoryDsiplay.Text = "MD";
            this.memoryDsiplay.UseVisualStyleBackColor = true;
            this.memoryDsiplay.Click += new System.EventHandler(this.memoryDsiplay_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDot);
            this.panel1.Controls.Add(this.equals);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 53);
            this.panel1.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 515);
            this.Controls.Add(this.memoryDsiplay);
            this.Controls.Add(this.memoryMinus);
            this.Controls.Add(this.memoryPlus);
            this.Controls.Add(this.memoryReset);
            this.Controls.Add(this.memorySet);
            this.Controls.Add(this.buttonClearLast);
            this.Controls.Add(this.buttonRightBracket);
            this.Controls.Add(this.buttonLeftBracket);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_times);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Screen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_times;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button buttonLeftBracket;
        private System.Windows.Forms.Button buttonRightBracket;
        private System.Windows.Forms.Button buttonClearLast;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button memorySet;
        private System.Windows.Forms.Button memoryReset;
        private System.Windows.Forms.Button memoryPlus;
        private System.Windows.Forms.Button memoryMinus;
        private System.Windows.Forms.Button memoryDsiplay;
        private System.Windows.Forms.Panel panel1;
    }
}

