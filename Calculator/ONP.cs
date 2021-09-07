using System;
using System.Collections.Generic;
using System.Globalization;
namespace Kalkulator
{
    public static class ONP
    {
        public static bool isOperator(char c)
        {
            return (c == '+' || c == '-' || c == '×' || c == '÷' || c == '*' || c == '/' || c == '~' || c == '^');
        }
        private static int priority(char c)
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

        private static bool isNegative(string str, int i)
        {
            if (i == 0 && str[i] == '-')
            {
                return true;
            }
            else if (str[i] == '-' && (str[i - 1] == '(' || isOperator(str[i - 1])))
            {
                return true;
            }

            return false;
        }

        private static bool isNegativeONP(string str, int i)
        {
            if (i < str.Length - 1)
            {
                return (str[i] == '-' && !isOperator(str[i + 1]) && str[i + 1] != ' ');
            }
            return false;
        }
        private static string changedivtimes(string input)
        {
            string buf = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '×')
                {
                    buf += '*';
                }
                else if (input[i] == '÷')
                {
                    buf += '/';
                }
                else
                {
                    buf += input[i];
                }
            }
            return buf;
        }
        public static string translate(string x)
        {
            Stack<string> s1 = new Stack<string>();
            string output = "";
            string input = changedivtimes(x);
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    output += input[i];
                }
                else if (isNegative(input, i))
                {
                    output += '-';
                }
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
                            {
                                break;
                            }
                        }
                    }
                    s1.Push(input[i].ToString());
                }
                else if (input[i] == '(')
                {
                    s1.Push(input[i].ToString());
                }
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
                        {
                            output += input[j];
                        }
                        else
                        {
                            break;
                        }
                    }
                    i = j - 1;
                }
            }
            while (s1.Count != 0)
            {
                output += " " + s1.Peek().ToString();
                s1.Pop();
            }
            return output;
        }
        private static string equasion(string a, char operation, string b)
        {
            double sol = 0;
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ",";
            double aa = System.Convert.ToDouble(a, provider);
            double bb = 0;
            if (operation != '~')
            {
                bb = System.Convert.ToDouble(b, provider);
            }

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
        public static string calculate(string output)
        {
            Stack<string> s1 = new Stack<string>();
            string reader = "";
            char c;
            string result = "";
            for (int i = 0; i < output.Length; i++)
            {
                c = output[i];
                if (Char.IsDigit(c) || isNegativeONP(output, i))
                {
                    do
                    {
                        if (c == ',')
                        {
                            reader += ',';
                            int j = i + 1;
                            for (; j < output.Length; j++)
                            {
                                if (Char.IsDigit(output[j]) || isNegativeONP(output, i))
                                {
                                    reader += output[j];
                                }
                                else
                                {
                                    break;
                                }
                            }
                            i = j - 1;
                        }
                        else
                        {
                            reader += c.ToString();
                        }

                        if (++i == output.Length)
                        {
                            break;
                        }

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
                        if (s1.Count == 0)
                        {
                            return "";
                        }

                        string a = s1.Peek();
                        s1.Pop();
                        s1.Push(equasion(a, c, ""));
                    }
                    else
                    {
                        if (s1.Count == 0)
                        {
                            return "";
                        }

                        string a = s1.Peek();
                        s1.Pop();
                        if (s1.Count == 0)
                        {
                            return "";
                        }

                        string b = s1.Peek();
                        s1.Pop();
                        if (c == '/' && a == "0")
                        {
                            return "Division By Zero!";
                        }
                        s1.Push(equasion(b, c, a));
                    }
                }
            }
            if (s1.Count != 0)
            {
                result = s1.Peek();
            }
            return result;
        }
    }
}
