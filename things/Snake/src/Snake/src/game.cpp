#include "game.hpp"

#include "math.hpp"

Game::Game(const int board_width, const int board_height)
{
    this->board_width = board_width;
    this->board_height = board_height;
}

Game::~Game()
{
    clean();
}

// function to start the game
// this is designed to be ran outside
void Game::start()
{
    init();

    renderWindow.create(sf::VideoMode((tile_size + tile_padding) * board_width, (tile_size + tile_padding) * board_height), "Snake", sf::Style::Default);
    renderWindow.setFramerateLimit(15);

    while (renderWindow.isOpen())
    {
        sf::Event event;
        while (renderWindow.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
            {
                renderWindow.close();
            }
        }

        update();

        // render
        renderWindow.clear();
        render();
        renderWindow.display();
    }
}