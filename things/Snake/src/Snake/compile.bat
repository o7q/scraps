@echo off
mkdir build 2> nul
cd build
cmake .. -G "MinGW Makefiles"
cmake --build .
copy "Snake.exe" "../Snake.exe"
pause