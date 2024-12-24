#include "snake.hpp"

void Snake::create(const int start_length)
{
    bodySegments.clear();
    for (int i = 0; i < start_length; ++i)
    {
        bodySegments.push_back(Vec2(start_length - i, 0));
    }
}

void Snake::update()
{
    Vec2 new_head_position = bodySegments[0] + moveDirection; // start by getting the new head position

    Vec2 previous = bodySegments[0];     // keep track of the current head position
    bodySegments[0] = new_head_position; // set the new head position

    // start at 1, because we don't want to include the head for the loop
    for (int i = 1; i < bodySegments.size(); ++i)
    {
        Vec2 temp = bodySegments[i]; // store the body segment in a temporary vector
        bodySegments[i] = previous;  // set the body position to the previous body segment's position
        previous = temp;             // set the new previous position vector
    }
}

void Snake::move(Vec2 moveDirection)
{
    // determine if the player will be moving back in the previous direction
    bool same_x = this->moveDirection.x == -moveDirection.x && this->moveDirection.y == moveDirection.y;
    bool same_y = this->moveDirection.y == -moveDirection.y && this->moveDirection.x == moveDirection.x;

    // only move if its a new direction
    if (!same_x && !same_y)
    {
        this->moveDirection = moveDirection;
    }
}

void Snake::grow()
{
    // get the tail and secondary tail segments
    Vec2 seg1 = bodySegments[bodySegments.size() - 1];
    Vec2 seg2 = bodySegments[bodySegments.size() - 2];

    // calculate direction between the two segments
    Vec2 grow_direction = seg1 - seg2;
    Vec2 new_segment = seg1 + grow_direction;

    // add a new body segment after the tail
    bodySegments.push_back(new_segment);
}

const std::vector<Vec2> &Snake::getBody() const
{
    return bodySegments;
}

Vec2 Snake::getPosition() const
{
    return bodySegments[0];
}

bool Snake::isCollingWithSelf() const
{
    // start at 1, because we don't want to include the head for the loop
    for (int i = 1; i < bodySegments.size(); ++i)
    {
        // check if the head is colliding with another body segment
        if (bodySegments[0] == bodySegments[i])
        {
            return true;
        }
    }

    return false;
}