#include <iostream>

#include <SFML/Graphics.hpp>

#include "game.hpp"

int main()
{
    Game game(20, 20);
    game.start();

    return 0;
}