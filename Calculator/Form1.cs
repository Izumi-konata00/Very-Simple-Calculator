using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        string output;
        string result;
        bool clearScreen = false;
        double Memory = 0;
        ulong leftbrackets=0;
        ulong rightbrackets=0;
        public Form1()
        {
            InitializeComponent();
        }
        private bool isOperator(char c)
        {
            return (c == '+' || c == '-' || c=='×'||c=='÷'||c =='*' || c == '/' || c == '~' || c == '^');
        }
        private int priority(char c)
        {
            switch (c)
            {
                case '~':
                case '+':
                case '-': return 1;
                case '*':
                case '/': return 2;
                case '^': return 3;
            }
            return 0;
        }
        private string changedivtimes(string input)
        {
            string buf = "";
            for(int i=0;i<input.Length;i++)
            {
                if (input[i] == '×')
                    buf += '*';
                else if (input[i] == '÷')
                    buf += '/';
                else
                    buf += input[i];
            }
            return buf;
        }
        private void translate(string x)
        {
            Stack<string> s1 = new Stack<string>();
            output="";
            string input = changedivtimes(x);
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                    output += input[i];   
                else if (isOperator(input[i]))
                {
                    output += " ";
                    if (s1.Count != 0)
                    {
                        while (priority(s1.Peek().ToString()[0]) >= priority(input[i]))
                        {
                            output += s1.Peek().ToString() + " ";
                            s1.Pop();
                            if (s1.Count == 0)
                                break;
                        }
                    }
                    s1.Push(input[i].ToString());
                }
                else if (input[i] == '(')
                    s1.Push(input[i].ToString());
                else if (input[i] == ')')
                {
                    while (s1.Peek().ToString() != "(")
                    {
                        output += " " + s1.Peek();
                        s1.Pop();
                    }
                    s1.Pop();
                }
                else if (Char.IsDigit(input[i - 1]) && input[i] == ',')
                {
                    output += ',';
                    int j = i + 1;
                    for (; j < input.Length; j++)
                    {
                        if (Char.IsDigit(input[j]))
                            output += input[j];
                        else break;
                    }
                    i = j - 1;
                }
            }
            while (s1.Count!=0)
            {
                output += " " + s1.Peek().ToString();
                s1.Pop();
            }
        }
        private  string equasion(string a, char operation, string b)
        {
            double sol=0;
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ",";
            double aa = System.Convert.ToDouble(a,provider);
            double bb=0;
            if (operation != '~')
                bb = System.Convert.ToDouble(b,provider);
            switch (operation)
            {
                case '~':
                    sol = -1 * aa;
                    break;
                case '+':
                    sol = aa + bb;
                    break;
                case '-':
                    sol = aa - bb;
                    break;
                case '*':
                    sol = aa * bb;
                    break;
                case '/':
                    sol = aa / bb;
                    break;
                case '^':
                    sol = Math.Pow(aa, bb);
                    break;
                default:
                    break;
            }
            return (sol.ToString());
        }
        private void EnableControls(Control con)
        {
            foreach (Control c in con.Controls)
                EnableControls(c);
            con.Enabled = true;
        }
        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
                DisableControls(c);
            if(con.Name!="Form1"&&con.Name!="Screen"&&con.Name!="clearButton")
                con.Enabled = false;
        }
        private void DivisionbyZero()
        {
            Screen.Text = "Division by Zero!";
            DisableControls(this);
        }
        private void calculate()
        {
            Stack<string> s1= new Stack<string>();
            string reader = "";
            char c;
            result = "";
            for (int i = 0; i < output.Length; i++)
            {
                c= output[i];
                if (Char.IsDigit(c))
                {
                     do
                     {
                        if(c==',')
                        {
                            reader += ',';
                            int j = i + 1;
                            for (; j < output.Length; j++)
                            {
                                if (Char.IsDigit(output[j]))
                                    reader += output[j];
                                else break;
                            }
                            i = j - 1;
                        }
                        else
                            reader += c.ToString();
                        if (++i == output.Length)
                            break;
                        c = output[i];
                     } while (c != ' ');
                    s1.Push(reader);
                    reader = "";
                    continue;
                }
                else if (isOperator(c))
                {
                    if (c == '~')
                    {
                        if(s1.Count==0)
                            return;
                        string a = s1.Peek();
                        s1.Pop();
                        s1.Push(equasion(a, c, ""));
                    }
                    else
                    {
                        if (s1.Count == 0)
                            return;
                        string a = s1.Peek();
                        s1.Pop();
                        if (s1.Count == 0)
                            return;
                        string b = s1.Peek();
                        s1.Pop();
                        if(c=='/' && a=="0")
                        {
                            DivisionbyZero();
                            return;
                        }
                        s1.Push(equasion(b, c, a));
                    }
                }
            }
            if(s1.Count!=0)
                result = s1.Peek();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            char ch = Screen.Text[Screen.Text.Length - 1];
            if (Screen.Text == "0" && !isOperator(bt.Text[0]))
                Screen.Text = "";
            if (bt.Text[0] == ')')
            {
                    if (leftbrackets == rightbrackets)
                        return;
                    rightbrackets++;
            }
            if (bt.Text[0] == '(')
                    leftbrackets++;
                if ((ch == '(' && isOperator(bt.Text[0]))||( ch == ')' && !isOperator(bt.Text[0])))
                    return;
            if (!isOperator(ch) && !isOperator(bt.Text[0]))
            {

                if (clearScreen == true)
                {
                    clearScreen = false;
                    Screen.Text = "";
                }
                Screen.Text += bt.Text;
            }
            else if (!(isOperator(ch) && isOperator(bt.Text[0])))
                Screen.Text += bt.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {
            translate(Screen.Text);
            calculate();
            if(result!="")
            {
                Screen.Text = result;
                clearScreen = true;
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
                fact *= i;
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
            for (int i= Screen.Text.Length-1;i>=0;i--)
            {
                if (Screen.Text[i] == ')')
                    amt++;
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
            Screen.Text=Screen.Text.Remove(Screen.Text.Length - n);
            translate(Reverse(equ));
            calculate();
            return System.Convert.ToDouble(result,provider);
        }
        private void factorial_Click(object sender, EventArgs e)
        {
            string input = Screen.Text;
            string buf = "";
            if (input.IndexOf(',') != -1)
                return;
            if (input[Screen.Text.Length-1] == ')')
            {
                ulong buf2 = calculate_factorial((ulong)calculate_Bracket());
                if(result!="")
                    Screen.Text += buf2.ToString();
                return;
            }
            for (int i=input.Length-1;i>=0;i--)
            {
                if (!isOperator(input[i]) )
                {
                    int j = i;
                    for(;j>=0;j--)
                    {
                        if (!isOperator(input[j]))
                        {
                            buf += input[j];
                            if (j == 0)
                                clearScreen = true;
                        }
                        else break;
                    }
                    Screen.Text = Screen.Text.Remove( j+1);
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
                    Screen.Text += buf2.ToString();
            }
            else
            {
                string buf = ""; 
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (!isOperator(input[i]))
                    {
                        int j = i;
                        for (; j >= 0; j--)
                        {
                            if (!isOperator(input[j]))
                            {
                                buf += input[j];
                                if (j == 0)
                                    clearScreen = true;
                            }
                            else break;
                        }
                        Screen.Text = Screen.Text.Remove(j+1);
                        Screen.Text  += Math.Sqrt(System.Convert.ToDouble(Reverse(buf),provider)).ToString();
                        return;
                    }                  
                }
            }
        }
        private void buttonClearLast_Click(object sender, EventArgs e)
        {
            if (Screen.Text[Screen.Text.Length - 1] == '(')
                leftbrackets--;
            else if (Screen.Text[Screen.Text.Length - 1] == ')')
                rightbrackets--;
            if (Screen.Text.Length == 1)
                Screen.Text = "0";
            else
                Screen.Text = Screen.Text.Remove(Screen.Text.Length - 1);
        }
        private void memorySet_Click(object sender, EventArgs e)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ",";
            translate(Screen.Text);
            calculate();
            Memory = System.Convert.ToDouble(result,provider);
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
            Memory -= System.Convert.ToDouble(Screen.Text, provider);
        }

        private void memoryDsiplay_Click(object sender, EventArgs e)
        {
            Screen.Text = Memory.ToString();
        }
    }
}
