@echo off
set name=NumberSheet
title Cleaning %name%
color 7
del "%name%.exe" /f 2> nul
rmdir ".vscode" /s /q 2> nul
title DONE!
echo.