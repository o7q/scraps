#include <iostream>
#include <fstream>
using namespace std;

void master();
void printHello();
void yesOrNo();
void adder();
void exit();

int main() 
{
    system("color A");

    master();

    system("pause");
}

void master()
    {
        cout << "1 = printHello (prints Hello), 2 = yesOrNo (1 = yes, 0 = no), 3 = adder (adds two numbers), 4 = exit (exits the program)" << endl;

        int input;
        cin >> input;

        if(input == 1)
        {
            printHello();
        }

        if(input == 2)
        {
            yesOrNo();
        }

        if(input == 3)
        {
            adder();
        }

        if(input == 4)
        {
            exit();
        }

        master();
    }

void printHello()
    {
        cout << "Hello" << endl;

        return;
    }

void yesOrNo()
    {
        int test;
        cin >> test;

        if (test == 1) 
        {
            cout << "yes" << endl;
        }
        else
        {
            cout << "no" << endl;
        }

        return;
    }

void adder()
    {
        long long int num1, num2;
        cin >> num1;
        cin >> num2;
        cout << num1 + num2 << endl;

        return;
    }

void exit()
    {
        _Exit(0);
    }