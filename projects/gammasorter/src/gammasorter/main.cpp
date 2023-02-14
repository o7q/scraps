#include <iostream>
#include <fstream>
#include <vector>
#include <dirent.h>
#include <algorithm>
using namespace std;

// code forked from: https://cplusplus.com/forum/beginner/267364
extern "C"
{
#define STB_IMAGE_IMPLEMENTATION
#include "includes/stb_image/stb_image.h"
}
bool load_frame_raw(vector<unsigned char> &image, const string &filename, int &x, int &y)
{
    int n;
    unsigned char *data = stbi_load(filename.c_str(), &x, &y, &n, 3);
    if (data != nullptr)
        image = vector<unsigned char>(data, data + x * y * 3);
    stbi_image_free(data);
    return (data != nullptr);
}
//

int main()
{
    system("title gammasorter");
    system("mkdir input 2> nul");

    int width, height;
    cout << "width:\n"; cin >> width;
    cout << "height:\n"; cin >> height;
    int area = width * height;

    cout << endl;

    system("mkdir working & mkdir output");

    string convertScript = "@echo off\n"
                           "setlocal enabledelayedexpansion\n"
                           "set img=0\n"
                           "for %%i in (\"input\\*.png\", \"input\\*.jpg\") do (\n"
                           "    echo PREPARING IMAGE !img!\n"
                           "    \"ffmpeg\" -loglevel quiet -i \"%%i\" -vf scale=\"" + to_string(width) + ":" + to_string(height) + "\" -q:v 1 \"working\\!img!.jpg\"\n"
                           "    set /a img+=1\n"
                           ")\n";
    ofstream out;
    out.open("script.bat");
    out << convertScript;
    out.close();
    system("script.bat");

    cout << endl;

    int imgCount = 0;
    if (auto dir = opendir(("working")))
    {
        while (auto f = readdir(dir))
        {
            if (!f->d_name || f->d_name[0] == '.') continue;
            imgCount++;
        }
        closedir(dir);
    }

    int gammaStore[imgCount];
    int imgStore[imgCount];

    int imgIndex = 0;

    for (int j = 0; j < imgCount; j++)
    {
        // load image
        int img_width, img_height;
        vector<unsigned char> img;
        bool success = load_frame_raw(img, "working\\" + to_string(imgIndex) + ".jpg", img_width, img_height);
        if (!success)
        {
            cout << "ERROR LOADING FRAME\n";
            gammaStore[j] = 0;
            imgStore[j] = j;
            imgIndex++;
            continue;
        }

        int gammaValue = 0;

        int x_pos = 0;
        int y_pos = 0;
        const size_t RGB = 3;

        for (int i = 0; i < area; i++)
        {
            if (x_pos == width)
            {
                x_pos = 0;
                y_pos++;
            }

            int tempGamma = 0;

            size_t pixelIndex = RGB * (y_pos * img_width + x_pos);
            for (int j = 0; j < 3; j++) tempGamma += static_cast<int>(img[pixelIndex + j]);
            gammaValue += tempGamma / 3;

            x_pos++;
        }

        cout << gammaValue << " : " << j << endl;

        gammaStore[j] = gammaValue;
        imgStore[j] = j;

        imgIndex++;
    }

    vector<pair <int, int>> vect;
    // init 1st and 2nd element of pairs with array values
    int n = sizeof(gammaStore)/sizeof(gammaStore[0]);
    // enter values in vector of pairs
    for (int i=0; i<n; i++) vect.push_back( make_pair(gammaStore[i],imgStore[i]) );
    // using simple sort() function to sort
    sort(vect.begin(), vect.end());

    cout << endl;

    for (int i = 0; i < n; i++)
        cout << vect[i].first << " : " << vect[i].second << endl;

    cout << endl;

    for (int i = 0; i < imgCount; i++)
    {
        cout << vect[i].second << ".* -> " << i << ".jpg\n";
        system(("copy \"working\\" + to_string(vect[i].second) + ".jpg\" \"output\\" + to_string(i) + ".jpg\"").c_str());
    }
    system("del /f \"script.bat\" 2> nul");
    // system("del /f \"script.bat\" 2> nul & rmdir \"working\" /s /q 2> nul");

    cout << endl;
    system("pause");
}