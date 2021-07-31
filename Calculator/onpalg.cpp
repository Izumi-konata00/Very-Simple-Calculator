#include <iostream>
#include <string> 
#include <cmath> 
#include <stack>
using namespace std;
bool isINF(string input);   //Sprawdza czy wyrazenie jest infiksowe czy w ONP
bool isOperator(char c);    //Sprawdza czy kolejny znak jest operatorem
int priority(char c);   //Sprawdza priorytet operatora
string equasion(string a, char operation, string b);
bool isOperator(char c)
{
    return (c == '+' || c == '-' || c == '*' || c == '/' || c == '~' || c == '^');
}
bool isINF(string input)
{
    char c = input.back(); //Pobiera ostatni element wejscia
    return (isdigit(c) || c == ')');
}
int priority(char c)
{
    switch (c)
    {
    case '~':;
    case '+':;
    case '-':return 1;
    case '*':;
    case '/':return 2;
    case '^':return 3;
    }
    return 0;
}
int main()
{
    std::stack<std::string> s1;
    string input;   //Wejscie (INF lub ONP)
    string output = "";
    cout << "--------|   Program konwertuje wyrazenie   |--------\n";
    cout << "--------|    w postaci infiksowej do ONP   |--------\n";
    cout << "--------|oraz oblicza wartosc wyrazenia ONP|--------\n" << endl;;
    cout << "Podaj wyrazenie INF lub ONP: ";
    getline(cin, input);
    if (isINF(input))
    {
        for (register unsigned int i = 0; i < input.length(); i++)
        {
            if (isdigit(input[i]))
                output += input[i];
            else if (isOperator(input[i]))
            {
                output += " ";
                if (!s1.empty())
                {
                    while (priority(s1.top()[0]) >= priority(input[i]))
                    {
                        output += s1.top() + " ";
                        s1.pop();
                        if (s1.empty())
                            break;
                    }
                }
                s1.push(string(1, input[i]));
            }
            else if (input[i] == '(')
                s1.push(string(1, input[i]));
            else if (input[i] == ')')
            {
                while (s1.top().compare("(") != 0)
                {
                    output += " " + s1.top();
                    s1.pop();
                }
                s1.pop();    //Usuwamy nawias "(" ze stosu
            }
        }
        while (!s1.empty())
        {
            output += " " + s1.top();
            s1.pop();
        }
        cout << "\n\n---------------|Po konwersji|---------------\n\n";
        cout << output << endl;
        cout << "\n--------------------------------------------\n";
    }
  /*  else
    {
        stack.makeEmpty();
        string reader = "";
        for (unsigned int i = 0; i < input.length(); i++)
        {
            char c = input[i];
            if (isdigit(c))
            {
                do
                {
                    reader += string(1, c);
                    i++;
                    c = input[i];
                } while (c != ' ');    //Czytamy cyfry az do napotkania spacji
                stack.push(reader);
                reader = "";
                continue;
            }
            if (isOperator(c))
            {
                if (c == '~')
                {
                    string a = stack.top();
                    stack.pop();

                    stack.push(equasion(a, c, ""));
                }
                else
                {
                    string a = stack.top();
                    stack.pop();

                    string b = stack.top();
                    stack.pop();

                    stack.push(equasion(b, c, a));
                }
            }
        }
        cout << "\n\n---------------|Wynik ONP|---------------\n\n";
        cout << "\t\t   " << s1.top() << endl;
        cout << "\n-----------------------------------------\n";
    }*/
    return 0;
}
string equasion(string a, char operation, string b)
{
    int sol;
    int aa = stoi(a);   //stoi() zamienia string na integer
    int bb;
    if (operation != '~')
        bb = stoi(b);
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
        sol = (int)pow(aa, bb);
        break;
    default:
        break;
    }
    return(to_string(sol)); //to_string zamienia integer na string
}