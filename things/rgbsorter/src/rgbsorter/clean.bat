@echo off
set name=rgbsorter
title Cleaning %name%
color 7
del "%name%.exe" /f 2> nul
del "script.bat" /f 2> nul
rmdir "working" /s /q 2> nul
rmdir "output" /s /q 2> nul
title DONE!
echo.