$scriptpath = $MyInvocation.MyCommand.Path
$dir = Split-Path $scriptpath
cd $dir
cd ..\..\
$SolutionDir = Get-Location
$CMD = "$SolutionDir\packages\Redis-64.2.8.9\redis-server.exe"
$CMD
$configArg = "$SolutionDir\packages\Redis-64.2.8.9\redis.windows.conf"
& $CMD $configArg