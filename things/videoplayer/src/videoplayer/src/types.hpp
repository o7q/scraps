#pragma once

template <typename T>
struct Vec2
{
    Vec2(T a, T b) : a(a), b(b) {}
    T a, b;
};