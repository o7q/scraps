#include <iostream>
#include <string>
#include <fstream>
#include <sstream>
#include <iomanip>
using namespace std;

void CreateFile(string file, string content);
string ReadFile(string file);
bool CheckFile(string file);
string FormatString(string input, int length);
string FloatToString(float input);
void ClearScreen();

string VERSION = "v1.1.0";

int main()
{
    system("title VirtualRegister");
    ClearScreen();

    system("mkdir \"VirtualRegister\\data\" 2> nul");
    system("mkdir \"VirtualRegister\\previous\" 2> nul");

    string balance_string;
    if (CheckFile("VirtualRegister\\data\\balance"))
        balance_string = ReadFile("VirtualRegister\\data\\balance");
    else
    {
        cout << "\n- Balance: ";
        getline(cin, balance_string);
        CreateFile("VirtualRegister\\register.txt", FormatString("DATE", 5) + " | " + FormatString("DESCRIPTION", 20) + " | " + FormatString("AMOUNT", 10) +  " | " + FormatString("BALANCE", 10) + " | ✔️ |");
        ClearScreen();
    }

    float balance = stof(balance_string);

    while (true)
    {
        cout << endl;

        cout << " Balance: $" + FloatToString(balance) << "\n\n";

        string date;
        string description;
        string amount;

        cout << "- Date: ";
        getline(cin, date);

        cout << "- Description: ";
        getline(cin, description);

        cout << "- Amount (+/-): ";
        getline(cin, amount);

        string amountString = "";

        if (amount.at(0) == '+')
        {
            balance += stof(amount.substr(1));
            amountString += "+$" + amount.substr(1);
        }
        if (amount.at(0) == '-')
        {
            balance -= stof(amount.substr(1));
            amountString += "-$" + amount.substr(1);
        }

        string balanceString = FloatToString(balance);

        string output = FormatString(date, 5) + " | " + FormatString(description, 20) + " | " + FormatString(amountString, 10) +  " | " + FormatString("$" + balanceString, 10) + " | ❌ |";

        CreateFile("VirtualRegister\\data\\balance", balanceString);
        CreateFile("VirtualRegister\\register.txt", ReadFile("VirtualRegister\\register.txt") + "\n" + output);

        ClearScreen();
    }

    return 0;
}

void CreateFile(string file, string content)
{
    ofstream f;
    f.open(file);
    f << content;
    f.close();
}

string ReadFile(string file)
{
    if (!CheckFile(file))
        return "";
    stringstream f;
    f << ifstream(file).rdbuf();
    return f.str();
}

bool CheckFile(string file)
{
    ifstream f;
    f.open(file);
    if (f)
        return true;
    return false;
}

string FormatString(string input, int length)
{
    while (input.length() < (size_t)length)
        input += " ";

    return input;
}

string FloatToString(float input)
{
    ostringstream oss;
    oss << fixed << setprecision(2) << input;
    return oss.str();
}

void ClearScreen()
{
    system("cls");
    cout << " VirtualRegister " + VERSION + "\n by o7q\n";
}