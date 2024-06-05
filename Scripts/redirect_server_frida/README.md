# Redirect server via Frida

## Install Frida's CLI tools

Make sure [Python](https://python.org/) is installed before you start.

Install Frida's CLI tools via Pypi.

```sh
pip install frida-tools
```

## Run Frida server on device/emulator

Download Frida server [here](https://github.com/frida/frida/releases/).

Make sure adb is enabled and Android is rooted and launched.

Run:

```sh
adb push frida-server /data/local/tmp
adb shell
# in adb shell
su
chmod 755 /data/local/tmp/frida-server
/data/local/tmp/frida-server
```

> [!TIP]  
> For Windows users that have already done the steps above,
you can also double click [frida-server.bat](/Scripts/redirect_server_frida/frida-server.bat) to launch Frida server instead of using commands.

## Hook client with frida

Set your server address in `ba.js`.

Launch the client, then immediately run the following command on host:

```sh
frida -U "ブルアカ" -l ba.js --realm=emulated
```

> [!TIP]  
> For Windows users, you can also double click [frida-inject.bat](/Scripts/redirect_server_frida/frida-inject.bat) instead of using commands.
