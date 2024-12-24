#include "game.hpp"

// game render logic
// runs every frame (after the update function)
void Game::render()
{
    // clear board
    for (int y = 0; y < board_height; ++y)
    {
        for (int x = 0; x < board_width; ++x)
        {
            renderBoard[y][x] = Tile::AIR;
        }
    }

    // set apple render tile
    for (int i = 0; i < apple_count; ++i)
    {
        Vec2 apple_position = apple_positions[i];
        renderBoard[apple_position.y][apple_position.x] = Tile::APPLE;
    }

    // set snake render tiles
    for (const Vec2 &position : snake.getBody())
    {
        // modulate to these values to ensure the snake is never placed outside of the board, resulting in a crash
        renderBoard[std::abs(position.y) % board_height][std::abs(position.x) % board_width] = Tile::SNAKE;
    }

    // render the board
    for (int y = 0; y < board_height; ++y)
    {
        for (int x = 0; x < board_width; ++x)
        {
            // create a rectangle
            sf::RectangleShape rect;
            rect.setPosition(sf::Vector2f(x * (tile_size + tile_padding), y * (tile_size + tile_padding)));
            rect.setSize(sf::Vector2f(tile_size, tile_size));

            // determine rectangle color
            sf::Color color;
            switch (renderBoard[y][x])
            {
            case Tile::AIR:
                color = sf::Color(50, 50, 50, 255);
                break;
            case Tile::SNAKE:
                color = sf::Color(40, 255, 60, 255);
                break;
            case Tile::APPLE:
                color = sf::Color(255, 40, 60, 255);
                break;
            }

            rect.setFillColor(color);

            renderWindow.draw(rect);
        }
    }
}