@echo off
chcp 65001 >nul
echo "This starts frida server."
echo "Don't close this window."
echo "If you don't see any error, it starts successfully."
echo/

adb start-server
adb root
adb shell "data/local/tmp/frida-server"

echo/
echo "Some error happened."
adb kill-server
pause
