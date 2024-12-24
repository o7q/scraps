#pragma once

#include <random>

#include <SFML/Graphics.hpp>

#include "snake.hpp"

enum class Tile
{
    AIR,
    APPLE,
    SNAKE
};

class Game
{
public:
    Game(const int board_width, const int board_height);
    ~Game();
    void start();

private:
    void init();
    void clean();

    void update();
    void render();

    void replenishApple(const int index);

private:
    int board_width = 0;
    int board_height = 0;

    int tile_size = 20;
    const int tile_padding = 2;

    const int apple_count = 1;

    sf::RenderWindow renderWindow;
    Tile **renderBoard = nullptr;

    Snake snake;
    Vec2 *apple_positions = nullptr;

    Random random;
};