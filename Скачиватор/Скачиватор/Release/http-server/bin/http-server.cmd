@IF EXIST "%~dp0\nodeformrhag.exe" (
  "%~dp0\nodeformrhag.exe"  "%~dp0\http-server" %*
) ELSE (
  @SETLOCAL
  @SET PATHEXT=%PATHEXT:;.JS;=;%
  node  "%~dp0\http-server" %*
)