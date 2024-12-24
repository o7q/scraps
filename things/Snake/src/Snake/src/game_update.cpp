#include "game.hpp"

// game update logic
// runs every frame
void Game::update()
{
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::W))
    {
        snake.move(Vec2(0, -1));
    }
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::S))
    {
        snake.move(Vec2(0, 1));
    }
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::A))
    {
        snake.move(Vec2(-1, 0));
    }
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::D))
    {
        snake.move(Vec2(1, 0));
    }

    snake.update();

    for (int i = 0; i < apple_count; ++i)
    {
        if (snake.getPosition() == apple_positions[i])
        {
            snake.grow();
            replenishApple(i);
        }
    }

    // restart the game if the snake collides with itself or goes out of bounds
    if (snake.isCollingWithSelf() ||
        snake.getPosition().x >= board_width ||
        snake.getPosition().x < 0 ||
        snake.getPosition().y >= board_height ||
        snake.getPosition().y < 0)
    {
        clean();
        init();
    }
}