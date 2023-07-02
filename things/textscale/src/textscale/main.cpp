#include <iostream>
using namespace std;

int main()
{
    string message[5] =
        {
            "SSSSS CCCCC IIIII",
            "S     C       I  ",
            "SSSSS C       I  ",
            "    S C       I  ",
            "SSSSS CCCCC IIIII"};
    int size;
    cin >> size;
    string temp = "";

    for (int i = 0; i < 5; i++)
    {
        for (int m = 0; m < size; m++)
        {
            for (int j = 0; j < 17; j++)
            {
                for (int k = 0; k < size; k++)
                {
                    temp += message[i][j];
                }
            }
            temp += "\n";
        }
    }

    cout << temp;
    system("pause");
}