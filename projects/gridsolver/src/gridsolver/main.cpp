#include <iostream>
#include <ctime>
#include <random>
#include <algorithm>
using namespace std;

int main()
{
    system("title gridsolver");

    srand(time(NULL));
    const int MAX_ATTEMPTS = 512;

    int attempt = 0;
    int grid[16];
    string grid_solution[MAX_ATTEMPTS] = {};

    while (attempt < MAX_ATTEMPTS)
    {
        int solved_index = 0;

        while (solved_index != 8)
        {
            solved_index = 0;
            int grid_sum = 0;
            while (grid_sum != 6)
            {
                grid_sum = 0;

                for (int i = 0; i < 16; i++)
                    grid[i] = 0;

                for (int i = 0; i < 6; i++)
                {
                    mt19937 gen(rand());
                    uniform_int_distribution<> dist(0, 15);
                    grid[dist(gen)] = 1;
                }

                for (int i = 0; i < 16; i++)
                    grid_sum += grid[i];
            }

            solved_index += (grid[0] + grid[1] + grid[2] + grid[3]) % 2 == 0 ? 1 : 0;
            solved_index += (grid[4] + grid[5] + grid[6] + grid[7]) % 2 == 0 ? 1 : 0;
            solved_index += (grid[8] + grid[9] + grid[10] + grid[11]) % 2 == 0 ? 1 : 0;
            solved_index += (grid[12] + grid[13] + grid[14] + grid[15]) % 2 == 0 ? 1 : 0;

            solved_index += (grid[0] + grid[4] + grid[8] + grid[12]) % 2 == 0 ? 1 : 0;
            solved_index += (grid[1] + grid[5] + grid[9] + grid[13]) % 2 == 0 ? 1 : 0;
            solved_index += (grid[2] + grid[6] + grid[10] + grid[14]) % 2 == 0 ? 1 : 0;
            solved_index += (grid[3] + grid[7] + grid[11] + grid[15]) % 2 == 0 ? 1 : 0;
        }

        for (int i = 0; i < 16; i++)
            grid_solution[attempt] += to_string(grid[i]);

        // display grids while processing (OPTIONAL)
        // int x_index = 0;
        // for (int i = 0; i < 16; i++)
        // {
        //     cout << (grid[i] == 1 ? "[]" : "::");
        //     x_index++;
        //     if (x_index == 4)
        //     {
        //         x_index = 0;
        //         cout << "\n";
        //     }
        // }
        // cout << grid_solution[attempt] << "\n\n";

        attempt++;
    }

    int unique_solutions = 0;

    sort(grid_solution, grid_solution + MAX_ATTEMPTS);
    int j = 0;
    for (int i = 0; i < MAX_ATTEMPTS - 1; i++)
    {
        if (grid_solution[i] != grid_solution[i + 1])
            grid_solution[j++] = grid_solution[i];
    }
    grid_solution[j++] = grid_solution[MAX_ATTEMPTS - 1];

    for (int i = 0; i < j; i++)
    {
        cout << grid_solution[i] << endl;
        unique_solutions++;
    }
    cout << unique_solutions << " unique solutions!\n\n";
    system("pause");

    return 0;
}