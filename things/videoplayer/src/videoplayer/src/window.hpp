#pragma once

#include <string>

#include <SDL2/SDL.h>

#include "types.hpp"

class Window
{
public:
    Window(const std::string &title, unsigned int width, unsigned int height)
    {
        window = SDL_CreateWindow(title.c_str(), SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, width, height, 0);
        renderer = SDL_CreateRenderer(window, -1, 0);

        this->width = width;
        this->height = height;
    }
    ~Window()
    {
        SDL_DestroyRenderer(renderer);
        SDL_DestroyWindow(window);
    }

    SDL_Renderer *getRenderer() const
    {
        return renderer;
    }

    int getWidth() const
    {
        return width;
    }

    int getHeight() const
    {
        return height;
    }

private:
    SDL_Window *window = nullptr;
    SDL_Renderer *renderer = nullptr;

    unsigned int width = 0;
    unsigned int height = 0;
};