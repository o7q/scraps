#include "media.hpp"

#include <iostream>
#include <string>
#include <filesystem>

#include <SDL2/SDL_image.h>

Media::Media(const std::string &media_path)
{
    this->media_path = media_path;
    this->media_name = std::filesystem::path(media_path).filename().string();
}

Media::~Media()
{
    for (SDL_Texture *texture : frames)
    {
        SDL_DestroyTexture(texture);
    }
}

void Media::decode(SDL_Renderer *renderer, const std::string &decode_path)
{
    std::filesystem::create_directories(decode_path);
    std::string ffmpeg_script = "ffmpeg -loglevel info -y -i \"" + media_path + "\" -vf \"scale=256:-1:sws_flags=fast_bilinear\" -an \"" + decode_path + "/%04d.png\"";
    std::system(ffmpeg_script.c_str());

    int count = 0;
    for (const std::filesystem::directory_entry &media_frame : std::filesystem::directory_iterator(decode_path))
    {
        if (media_frame.is_regular_file() && media_frame.path().extension() != ".png")
        {
            continue;
        }

        SDL_Surface *surface = IMG_Load(media_frame.path().string().c_str());

        width = surface->w;
        height = surface->h;

        if (count % 100 == 0)
        {
            std::cout << "Generating proxy: " << count << std::endl;
        }

        SDL_Texture *texture = SDL_CreateTextureFromSurface(renderer, surface);
        frames.push_back(texture);
        SDL_FreeSurface(surface);

        ++count;
    }

    frame_count = count;
}

SDL_Texture *Media::getFrame(int index) const
{
    if (frames.empty() || index >= frames.size())
    {
        return nullptr;
    }

    return frames.at(index);
}