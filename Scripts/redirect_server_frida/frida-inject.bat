@echo off
chcp 65001 >nul
echo "This starts ba private server."
echo "Don't close this window."
echo/

frida -U "ブルアカ" -l ba.js --realm=emulated

echo/
echo "Some error happened."
pause
