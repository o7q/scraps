#include "game.hpp"

// setup game objects
void Game::init()
{
    renderBoard = new Tile *[board_height];
    for (int row = 0; row < board_height; ++row)
    {
        renderBoard[row] = new Tile[board_width];
    }

    for (int y = 0; y < board_height; ++y)
    {
        for (int x = 0; x < board_width; ++x)
        {
            renderBoard[y][x] = Tile::AIR;
        }
    }

    snake.create(3);
    snake.move(Vec2(1, 0));

    apple_positions = new Vec2[apple_count];

    for (int i = 0; i < apple_count; ++i)
    {
        replenishApple(i);
    }
}

// clean/reset game objects
void Game::clean()
{
    for (int row = 0; row < board_height; ++row)
    {
        if (renderBoard[row] != nullptr)
        {
            delete[] renderBoard[row];
            renderBoard[row] = nullptr;
        }
    }

    if (renderBoard != nullptr)
    {
        delete renderBoard;
    }

    if (apple_positions != nullptr)
    {
        delete[] apple_positions;
    }
}