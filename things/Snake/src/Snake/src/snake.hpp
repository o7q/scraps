#pragma once

#include <iostream>
#include <vector>

#include "math.hpp"

class Snake
{
public:
    Snake() = default;

    void create(const int start_length);
    void update();

    void move(Vec2 moveDirection);
    void grow();

    const std::vector<Vec2> &getBody() const;
    Vec2 getPosition() const;

    bool isCollingWithSelf() const;

private:
    std::vector<Vec2> bodySegments;
    Vec2 moveDirection;
};