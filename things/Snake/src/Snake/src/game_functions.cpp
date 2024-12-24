#include "game.hpp"

void Game::replenishApple(const int index)
{
    int x = random.getInt(0, board_width);
    int y = random.getInt(0, board_height);

    apple_positions[index].x = x;
    apple_positions[index].y = y;
}