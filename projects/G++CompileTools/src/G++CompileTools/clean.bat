@echo off
set name=NAME
title Cleaning %name%
color 7
del "%name%.exe" /f 2> nul
title DONE!
echo.