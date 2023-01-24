#include <iostream>
#include <sstream>
#include <vector>
#include <fstream>
using namespace std;

int main()
{
    system("title NumberSheet");

    int sheet_index = 1;

    while (true)
    {
        string INPUT;
        cin >> INPUT;

        string FINAL = "";

        stringstream master_stream(INPUT);
        string master_seg;
        vector<std::string> master_seglist;
        while (getline(master_stream, master_seg, ',')) master_seglist.push_back(master_seg);

        for (size_t i = 0; i < master_seglist.size(); i++)
        {
            if (master_seglist[i].find('-') < master_seglist[i].length())
            {
                stringstream num_stream(master_seglist[i]);
                string num_seg;
                vector<std::string> num_seglist;
                while (getline(num_stream, num_seg, '-')) num_seglist.push_back(num_seg);

                if (num_seglist.size() == 2)
                {
                    for (int j = stoi(num_seglist[0]); j <= stoi(num_seglist[1]); j++)
                    {
                        if (j == stoi(num_seglist[1])) FINAL += to_string(j) + ")";
                        else FINAL += to_string(j) + ")\n\n\n\n";
                    }
                }

                if (master_seglist.size() > 1 && i + 1 != master_seglist.size()) FINAL += "\n\n*\n\n";
            }

            if (master_seglist[i].find('=') < master_seglist[i].length())
            {
                stringstream num_stream(master_seglist[i]);
                string num_seg;
                vector<std::string> num_seglist;
                while (getline(num_stream, num_seg, '=')) num_seglist.push_back(num_seg);

                if (num_seglist.size() == 2)
                {
                    for (int j = stoi(num_seglist[0]); j <= stoi(num_seglist[1]); j += 2)
                    {
                        if (j == stoi(num_seglist[1])) FINAL += to_string(j) + ")";
                        else FINAL += to_string(j) + ")\n\n*\n\n";
                    }
                }

                if (stoi(num_seglist[0]) % 2 != 0 && stoi(num_seglist[1]) % 2 == 0) FINAL = FINAL.substr(0, FINAL.size() - 5);
                if (master_seglist.size() > 1 && i + 1 != master_seglist.size()) FINAL += "\n\n*\n\n";
            }
        }

        ofstream out;
        out.open("sheet" + to_string(sheet_index) + ".txt");
        out << FINAL;
        out.close();

        sheet_index++;
        system("cls");
    }

    return 0;
}