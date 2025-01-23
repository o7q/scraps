#pragma once

#include <string>
#include <filesystem>

#include <SDL2/SDL.h>

#include "media.hpp"
#include "window.hpp"

class Timeline
{
public:
    Timeline(Window &window, std::string media_path) : window(window), proxy_media(media_path)
    {
        this->project_root = "videoplayer/projects/" + proxy_media.getMediaName();
        std::filesystem::remove_all(project_root);
        proxy_media.decode(window.getRenderer(), project_root + "/proxy");
    }

    void renderPreview()
    {
        float ratio = proxy_media.getWidth() / static_cast<float>(proxy_media.getHeight());
        int width = preview_width;
        int height = static_cast<int>(preview_width / ratio);

        SDL_Rect trans_rect{window.getWidth() / 2 - width / 2, 0, width, height};

        SDL_Texture *frame = proxy_media.getFrame(current_frame);
        if (frame == nullptr)
        {
            return;
        }

        SDL_RenderCopyEx(window.getRenderer(), frame, NULL, &trans_rect, 0, NULL, SDL_FLIP_NONE);
    }

    void seek(int direction)
    {
        current_frame += direction;
    }

    void setPlayhead(int frame)
    {
        current_frame = frame;
    }

    int getFrameCount() const
    {
        return proxy_media.getFrameCount();
    }

private:
    Window &window;

    Media proxy_media;

    unsigned int current_frame = 0;

    const int preview_width = 512;

    std::string project_root = "";
};