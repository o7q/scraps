#pragma once

#include <string>
#include <vector>

#include <SDL2/SDL.h>

class Media
{
public:
    Media(const std::string &media_path);
    ~Media();

    void decode(SDL_Renderer *renderer, const std::string &decode_path);

    SDL_Texture *getFrame(int index) const;

    const std::string &getMediaPath() const { return media_path; }
    const std::string &getMediaName() const { return media_name; }

    int getFrameCount() const { return frame_count; }
    int getWidth() const { return width; }
    int getHeight() const { return height; }

private:
    std::string media_path = "";
    std::string media_name = "";

    std::vector<SDL_Texture *> frames;
    unsigned int frame_count = 0;

    unsigned int width = 0;
    unsigned int height = 0;
};