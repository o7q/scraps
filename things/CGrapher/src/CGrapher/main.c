#include <iostream>
#include <stdio.h>
#include <math.h>

int main(void)
{
    int countx = 0;
    int county = 0;

    int width = 50;
    int height = 50;

    // int x = 8 - 1;
    // int y = height - 5;

    int slope = 2;
    int intercept = 3;
    // int ymxb = (slope*xin[0]) + intercept;

    int xin[] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

    int x[1024];
    int y[1024];

    // for (int i = 0; i < 4; i++)
    // {
    //     x[i] = xin[i];
    //     y[i] = (slope*x[i]) + intercept;
    // }

    for (int i = 0; i < 20; i++)
    {
        x[i] = xin[i];
        y[i] = pow(xin[i], 2);
    }

    int index = 0;

    int area = width*height;

    for (int i = 0; i < area; i++)
    {
        if (countx == x[index] && county == y[index])
        {
            printf("@ ");
            index++;
        }
        else
        {
            printf(". ");
        }

        countx++;
        if (countx == width)
        {
            printf("\n");
            county++;
            countx = 0;
        }
    }
    

    system("pause");

    return 0;
}