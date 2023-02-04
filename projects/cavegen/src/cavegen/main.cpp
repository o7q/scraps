#include <iostream>
#include <ctime>
#include <random>
#include <windows.h>
#include <fstream>
using namespace std;

int main()
{
    // SETTINGS
    const int width = 50; // grid width
    const int height = 50; // grid height
    const int x_start = 10; // x starting position
    const int y_start = 10; // y starting position
    const int x_leap = 1; // x jump amount
    const int y_leap = 1; // y jump amount
    const int x_cave = 0; // flatness of cave, less than 13
    const int y_cave = 0; // verticality of cave, less than 13
    const int iterations = 1000; // cave length, iteration amount
    const int seed = 0; // 0 for time
    const bool showLeap = false; // show each leap
    const bool forMap = false; // render as a binary map (for games or whatever you want)
    const bool save = false; // save buffer as file

    int area = width * height;
    srand(seed == 0 ? time(NULL) : seed);

    while (true)
    {
        int x = x_start;
        int y = y_start;

        int swap = 1;

        int grid[width][height] = {0};

        string buffer = "";

        for (int i = 0; i < iterations; i++)
        {
            int random = rand() % 100;

            if (random > 0 && random < 25 + x_cave) x++;
            if (random > 25 && random < 50 + y_cave) y++;
            if (random > 50 && random < 75 - x_cave) x--;
            if (random > 75 && random < 100 - y_cave) y--;

            if (x >= width) x -= x_leap;
            if (y >= height) y -= x_leap;
            if (x < 0) x += y_leap;
            if (y < 0) y += y_leap;

            grid[x][y] = grid[x][y] == 0 ? 1 : grid[x][y] == 1 ? 2 : 1;
            grid[x][y] = 3;

            int x_index = 0;
            int y_index = 0;

            buffer = "";

            for (int j = 0; j < area; j++)
            {
                if (x_index == width)
                {
                    buffer += "\n";
                    x_index = 0;
                    y_index++;
                }

                if (forMap == false) buffer += grid[x_index][y_index] == 3 ? "[]" : grid[x_index][y_index] == 2 ? "##" : grid[x_index][y_index] == 1 ? "$$" : "  ";
                else
                {
                    switch(grid[x_index][y_index])
                    {
                        case 1: case 2: case 3: buffer += "1"; break;
                        default: buffer += "0"; break;
                    }
                }

                x_index++;
            }

            if (grid[x][y] == 3) grid[x][y] = swap;
            swap = swap == 1 ? 2 : 1;

            cout << buffer;
            if (showLeap == true) system("pause");

            HANDLE oHandle;
            COORD pos;
            oHandle = GetStdHandle(STD_OUTPUT_HANDLE);
            pos.X = 0;
            pos.Y = 0;
            SetConsoleCursorPosition(oHandle, pos);
        }

        system("cls");
        cout << buffer << endl;

        if (save == true)
        {
            ofstream out;
            out.open("cave.txt");
            out << buffer;
            out.close();
        }

        system("pause");
    }

    return 0;
}