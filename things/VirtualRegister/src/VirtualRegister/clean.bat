@echo off
set name=VirtualRegister
title Cleaning %name%
color 7
del "%name%.exe" /f 2> nul
rmdir "VirtualRegister" /s /q 2> nul
title DONE!
echo.