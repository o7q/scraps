#include <iostream>
#include <math.h>
using namespace std;

int main()
{
    cout.precision(16);
    double e = 1;
    int lim = 100000000;
    int test = 0;
    for (int i = 0; i < lim; i++)
    {
        test++;
        e += pow((1 + 1 / e), e);
        if (test == 10000)
        {
            cout << e / lim << endl;
            test = 0;
        }
    }

    cout << e / lim << endl;
    system("pause");
}