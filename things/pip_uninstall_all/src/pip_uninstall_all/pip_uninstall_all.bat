@echo off
title Uninstalling Python Packages...
pip freeze > requirements.txt
pip uninstall -r requirements.txt -y
pip cache purge
pause