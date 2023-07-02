@echo off
title vid2sequence

set /p "name=Sequence Name: "
set /p "video=Video Path: "
set /p "width=Width: "
set /p "height=Height: "
set /p "fps=Framerate: "

mkdir %name% 2> nul
ffmpeg -i %video% -vf scale=%width%:%height% -r %fps% %name%\%name%.%%d.png

pause