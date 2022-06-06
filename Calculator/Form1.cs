using System;
using System.Globalization;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        private string output;
        private string result;
        private bool clearScreen = false;
        private double Memory = 0;
        private ulong leftbrackets = 0;
        private ulong rightbrackets = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void EnableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                EnableControls(c);
            }

            con.Enabled = true;
        }
        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }

            if (con.Name != "Form1" && con.Name != "Screen" && con.Name != "clearButton")
            {
                con.Enabled = false;
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            char ch = Screen.Text[Screen.Text.Length - 1];
            if (bt.Text[0] == ')' && leftbrackets == 0)
            {
                return;
            }
            if (Screen.Text == "0" && !ONP.isOperator(bt.Text[0]))
            {
                Screen.Text = "";
            }

            if (bt.Text[0] == ')')
            {
                if (leftbrackets == rightbrackets)
                {
                    return;
                }

                rightbrackets++;
            }
            if (bt.Text[0] == '(')
            {
                leftbrackets++;
            }

            if ((ch == '(' && ONP.isOperator(bt.Text[0]) && bt.Text[0] != '-') || (ch == ')' && !ONP.isOperator(bt.Text[0])))
            {
                return;
            }

            if (!ONP.isOperator(ch) && !ONP.isOperator(bt.Text[0]))
            {

                if (clearScreen == true)
                {
                    clearScreen = false;
                    Screen.Text = "";
                }
                Screen.Text += bt.Text;
            }
            else if (!(ONP.isOperator(ch) && ONP.isOperator(bt.Text[0])))
            {
                Screen.Text += bt.Text;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {
            output = ONP.translate(Screen.Text);
            result = ONP.calculate(output);
            if (result != "")
            {
                if (result == "Division By Zero!")
                    DisableControls(this);
                leftbrackets = 0;
                rightbrackets = 0;
                Screen.Text = result;
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            EnableControls(this);
            output = "";
            Screen.Text = "0";
        }
        private ulong calculate_factorial(ulong x)
        {
            ulong fact = 1;
            for (ulong i = 2; i <= x; i++)
            {
                fact *= i;
            }

            return fact;
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        private double calculate_Bracket()
        {
            uint amt = 0;
            string equ = "";
            int n = 0;
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ",";
            for (int i = Screen.Text.Length - 1; i >= 0; i--)
            {
                if (Screen.Text[i] == ')')
                {
                    amt++;
                }
                else if (Screen.Text[i] == '(')
                {
                    equ += Screen.Text[i];
                    n++;
                    amt--;
                    continue;
                }
                if (amt > 0)
                {
                    equ += Screen.Text[i];
                    n++;
                }
            }
            Screen.Text = Screen.Text.Remove(Screen.Text.Length - n);
            output = ONP.translate(Reverse(equ));
            result = ONP.calculate(output);
            return Convert.ToDouble(result, provider);
        }
        private void factorial_Click(object sender, EventArgs e)
        {
            string input = Screen.Text;
            string buf = "";
            if (input.IndexOf(',') != -1)
            {
                return;
            }

            if (input[Screen.Text.Length - 1] == ')')
            {
                ulong buf2 = calculate_factorial((ulong)calculate_Bracket());
                if (result != "")
                {
                    Screen.Text += buf2.ToString();
                }

                return;
            }
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (!ONP.isOperator(input[i]))
                {
                    int j = i;
                    for (; j >= 0; j--)
                    {
                        if (!ONP.isOperator(input[j]))
                        {
                            buf += input[j];
                            if (j == 0)
                            {
                                clearScreen = true;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    Screen.Text = Screen.Text.Remove(j + 1);
                    Screen.Text += calculate_factorial(System.Convert.ToUInt64(Reverse(buf))).ToString();
                    return;
                }
            }
        }
        private void sqrtButton_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ",";
            string input = Screen.Text;
            if (input[Screen.Text.Length - 1] == ')')
            {
                double buf2 = Math.Sqrt(calculate_Bracket());
                if (result != "")
                {
                    Screen.Text += buf2.ToString();
                }
            }
            else
            {
                string buf = "";
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (!ONP.isOperator(input[i]))
                    {
                        int j = i;
                        for (; j >= 0; j--)
                        {
                            if (!ONP.isOperator(input[j]))
                            {
                                buf += input[j];
                                if (j == 0)
                                {
                                    clearScreen = true;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        Screen.Text = Screen.Text.Remove(j + 1);
                        Screen.Text += Math.Sqrt(System.Convert.ToDouble(Reverse(buf), provider)).ToString();
                        return;
                    }
                }
            }
        }
        private void buttonClearLast_Click(object sender, EventArgs e)
        {
            if (Screen.Text[Screen.Text.Length - 1] == '(')
            {
                leftbrackets--;
            }
            else if (Screen.Text[Screen.Text.Length - 1] == ')')
            {
                rightbrackets--;
            }

            if (Screen.Text.Length == 1)
            {
                Screen.Text = "0";
            }
            else
            {
                Screen.Text = Screen.Text.Remove(Screen.Text.Length - 1);
            }
        }
        private void memorySet_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ",";
            output = ONP.translate(Screen.Text);
            result = ONP.calculate(output);
            Memory = System.Convert.ToDouble(result, provider);
        }

        private void memoryReset_Click(object sender, EventArgs e)
        {
            Memory = 0;
        }

        private void memoryPlus_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ",";
            Memory += System.Convert.ToDouble(Screen.Text, provider);
        }

        private void memoryMinus_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ",";
            Memory -= Convert.ToDouble(Screen.Text, provider);
        }

        private void memoryDsiplay_Click(object sender, EventArgs e)
        {
            Screen.Text = Memory.ToString();
        }
    }
}
