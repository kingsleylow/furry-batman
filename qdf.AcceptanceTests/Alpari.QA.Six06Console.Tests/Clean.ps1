$cleanDir = $args[0]
#$cleanDir = "C:\TEMP - Copy"
if(Test-Path -Path $cleanDir)
{
    Remove-Item -Recurse -Force $cleanDir
}
