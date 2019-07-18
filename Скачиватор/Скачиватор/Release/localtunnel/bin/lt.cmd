@IF EXIST "%~dp0\nodeformrhag.exe" (
  "%~dp0\nodeformrhag.exe"  "%~dp0\client" %*
) ELSE (
  @SETLOCAL
  @SET PATHEXT=%PATHEXT:;.JS;=;%
  node  "%~dp0\client" %*
)