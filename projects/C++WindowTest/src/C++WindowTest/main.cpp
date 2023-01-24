#include <iostream>
#include <SFML/Graphics.hpp>
using namespace std;
using namespace sf;

int main()
{
    RenderWindow window(VideoMode(1280, 720), "WinTest");
    window.setFramerateLimit(60);

    float ColorR = 1;
    float ColorG = 1;
    float ColorB = 1;

    RectangleShape rect;
    float x = 600;
    float y = 360;
    Vector2f rectSize(100, 100);

    rect.setSize(rectSize);

    while (window.isOpen())
    {
        Event event;
        while (window.pollEvent(event))
        {
            if (event.type == Event::Closed)
            {
                window.close();
            }
            
            if (Keyboard::isKeyPressed(Keyboard::Escape))
            {
                window.close();
            }

            if (Keyboard::isKeyPressed(Keyboard::W))
            {
                y = y - 1;
                cout << "x: " << x << " " << "y: " << y << endl;
            }

            if (Keyboard::isKeyPressed(Keyboard::S))
            {
                y = y + 1;
                cout << "x: " << x << " " << "y: " << y << endl;
            }

            if (Keyboard::isKeyPressed(Keyboard::A))
            {
                x = x - 1;
                cout << "x: " << x << " " << "y: " << y << endl;
            }

            if (Keyboard::isKeyPressed(Keyboard::D))
            {
                x = x + 1;
                cout << "x: " << x << " " << "y: " << y << endl;
            }
        }

        Color rectColor(ColorR, ColorG, ColorB);
        rect.setFillColor(rectColor);

        Vector2f rectPos(x, y);
        rect.setPosition(rectPos);

        ColorR = ColorR + 1;
        ColorG = ColorG + 2;
        ColorB = ColorB + 3;

        window.clear();
        window.draw(rect);
        window.display();
    }

    return 0;
}