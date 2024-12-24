#pragma once

#include <random>

struct Vec2
{
    Vec2() = default;
    Vec2(const int x, const int y) : x(x), y(y) {}

    bool operator==(const Vec2 &other) const
    {
        return x == other.x && y == other.y;
    }

    bool operator!=(const Vec2 &other) const
    {
        return x == other.x && y == other.y;
    }

    Vec2 operator+(const Vec2 &b) const
    {
        return Vec2(x + b.x, y + b.y);
    }

    Vec2 operator-(const Vec2 &b) const
    {
        return Vec2(x - b.x, y - b.y);
    }

    int x = 0, y = 0;
};

class Random
{
public:
    Random() : random(rd()) {}

    int getInt(int min, int max)
    {
        std::uniform_int_distribution<int> dist(min, max - 1);
        return dist(random);
    }

private:
    std::random_device rd;
    std::mt19937 random;
};