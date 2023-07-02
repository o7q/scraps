#include <iostream>
#include <fstream>
#include <sstream>
#include <regex>
#include "includes/color/color.hpp"
using namespace std;

void createFile(string file, string content);
string readFile(string file);
bool checkFile(string file);
string formatPath(string path);
void clearScreen();

int main()
{
    system("title ngrok-wrapper");
    clearScreen();

    system("mkdir \"ngrok-wrapper\" 2> nul");
    system("mkdir \"ngrok-wrapper\\config\" 2> nul");

    createFile("ngrok-wrapper\\reset-ngrok-path.bat", "@echo off\ntitle Removing ngrok-path\ndel \"config\\ngrok-path\" /f 2> nul");
    createFile("ngrok-wrapper\\reset-ngrok-token.bat", "@echo off\ntitle Removing ngrok-token\ndel \"config\\ngrok-token\" /f 2> nul");

    while (true)
    {
        // ngrok-path

        while (!checkFile(readFile("ngrok-wrapper\\config\\ngrok-path")))
        {
            cout << dye::light_aqua(" ngrok path: ") << dye::grey("(drag & drop \"ngrok.exe\" onto this window | download from: https://dashboard.ngrok.com/get-started/setup)") << dye::light_aqua("\n -> ");
            string path;
            getline(cin, path);

            createFile("ngrok-wrapper\\config\\ngrok-path", formatPath(path));

            clearScreen();
        }

        // ngrok-token

        if (!checkFile("ngrok-wrapper\\config\\ngrok-token"))
        {
            cout << dye::light_aqua(" ngrok token: ") << dye::grey("(copy & paste your token from: https://dashboard.ngrok.com/get-started/your-authtoken | token example: pZuyWM8xAwIk96YWFd1dPGgNZWq_T3p8fQOTXEL7TmLYOxK8b)") << dye::light_aqua("\n -> ");
            string token;
            getline(cin, token);

            createFile("ngrok-wrapper\\config\\ngrok-token", formatPath(token));

            clearScreen();

            system(("start \"ngrok\" \"" + readFile("ngrok-wrapper\\config\\ngrok-path") + "\" config add-authtoken " + token).c_str());
        }

        // ngrok-port

        string lastPort = readFile("ngrok-wrapper\\config\\ngrok-port");

        cout << dye::light_aqua(" port: ") << dye::grey("(type ! to use previous port: " + lastPort + " | add @ to the end to open a https interface)") << dye::light_aqua("\n -> ");
        string port;
        getline(cin, port);

        bool openHttpsInterface = false;

        if (port.at(0) == '!')
            port = readFile("ngrok-wrapper\\config\\ngrok-port") + (port.back() == '@' ? "@" : "");
        if (port.back() == '@')
        {
            openHttpsInterface = true;
            port = port.substr(0, port.size() - 1);
        }

        createFile("ngrok-wrapper\\config\\ngrok-port", port);

        // start ngrok

        string httpsInterface = openHttpsInterface == true ? " && start http://localhost:4040" : "";
        system(("start \"ngrok\" \"" + readFile("ngrok-wrapper\\config\\ngrok-path") + "\" tcp " + port + httpsInterface).c_str());

        clearScreen();
    }

    return 0;
}

void createFile(string file, string content)
{
    ofstream f;
    f.open(file);
    f << content;
    f.close();
}

string readFile(string file)
{
    if (!checkFile(file))
        return "";
    stringstream f;
    f << ifstream(file).rdbuf();
    return f.str();
}

bool checkFile(string file)
{
    ifstream f;
    f.open(file);
    if (f) return true;
    return false;
}

string formatPath(string path)
{
    return regex_replace(path, regex("\\\""), "");
}

void clearScreen()
{
    system("cls");
    cout << dye::light_green("\n ngrok-wrapper ") << dye::green("by o7q\n\n");
}