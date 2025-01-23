#include <iostream>

#include <SDL2/SDL.h>
#include <SDL2/SDL_image.h>
#include <SDL2/SDL_mixer.h>

#include "timeline.hpp"
#include "window.hpp"

int main(int argc, char **argv)
{
    Window window("videoplayer", 512, 720);
    SDL_Renderer *window_renderer = window.getRenderer();

    Timeline *timeline = nullptr;

    bool running = true;
    while (running)
    {
        SDL_Event event;
        while (SDL_PollEvent(&event))
        {
            switch (event.type)
            {
            case SDL_QUIT:
                running = false;
                break;
            case SDL_DROPFILE:
            {
                if (timeline != nullptr)
                {
                    delete timeline;
                    timeline = nullptr;
                }
                timeline = new Timeline(window, event.drop.file);
                SDL_free(event.drop.file);
            }
            break;
            case SDL_KEYDOWN:
                if (event.key.keysym.sym == SDLK_LEFT && timeline != nullptr)
                {
                    timeline->seek(-1);
                }
                if (event.key.keysym.sym == SDLK_RIGHT && timeline != nullptr)
                {
                    timeline->seek(1);
                }
                break;
            }
        }

        int x, y;
        SDL_GetMouseState(&x, &y);

        if (timeline != nullptr)
        {
            int index = timeline->getFrameCount() * (x / static_cast<float>(window.getWidth()));
            timeline->setPlayhead(index);
        }

        SDL_RenderClear(window_renderer);
        if (timeline != nullptr)
        {
            timeline->renderPreview();
        }
        SDL_RenderPresent(window_renderer);
    }

    if (timeline != nullptr)
    {
        delete timeline;
    }

    return 0;
}