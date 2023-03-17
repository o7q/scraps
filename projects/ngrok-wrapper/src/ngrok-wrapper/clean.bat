@echo off
set name=ngrok-wrapper
title Cleaning %name%
color 7
del "%name%.exe" /f 2> nul
rmdir "ngrok-wrapper" /s /q 2> nul
title DONE!
echo.