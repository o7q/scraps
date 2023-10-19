@echo off
title media_splitter

set /p "name=Name: "
set /p "path=Media Path: "
set /p "interval=Split Interval: "
set /p "filetype=Filetype: "

mkdir %name% 2> nul
ffmpeg -i %path% -f segment -segment_time %interval% -c copy %name%\%%d.%filetype%

pause