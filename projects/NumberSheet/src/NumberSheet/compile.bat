@echo off
set name=NumberSheet
title Compiling %name%
color 7
g++ *.cpp -Wall -O2 -o "%name%.exe" -static-libstdc++ -static-libgcc
title DONE!
echo.
pause