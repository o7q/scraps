@echo off
set name=cavegen
title Cleaning %name%
color 7
del "%name%.exe" /f 2> nul
del "cave.txt" /f 2> nul
title DONE!
echo.