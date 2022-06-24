@echo off
setlocal

set ThisDir=%~dp0
pushd .
cd %ThisDir%

:: Source design files
set Design=%ThisDir%Design\ChatServerDesign
set DesignXml=%Design%.xml
set DesignCsv=%Design%.csv

:: DesignXml is mandatory.
if not exist %DesignXml% (
    echo "%DesignXml%" is not found.
    pause
    exit /b 1
)

:: Before run this script, download https://github.com/OPCFoundation/UA-ModelCompiler and build in 'Release'.
set ModelCompiler=..\..\..\..\UA-ModelCompiler\build\bin\Release\net6.0\Opc.Ua.ModelCompiler.exe
if not exist %ModelCompiler% (
   echo "%ModelCompiler%" is not found.
   pause
   exit /b 1
)

set PublishedDir=%ThisDir%Published
if not exist %PublishedDir% (
    mkdir %PublishedDir%
)

:: See https://github.com/OPCFoundation/UA-ModelCompiler/blob/master/Opc.Ua.ModelCompiler/HelpFile.txt
echo %ModelCompiler% compile -d2 "%DesignXml%" -cg "%DesignCsv%" -o2 "%PublishedDir%"
%ModelCompiler% compile -d2 "%DesignXml%" -cg "%DesignCsv%" -o2 "%PublishedDir%"
if %ERRORLEVEL% NEQ 0 (
   echo Failed.
   pause
   exit /b 1
)
echo Done.

:: Copy design files to 'Published'
copy "%DesignXml%" "%PublishedDir%"
echo %DesignXml% copied.
copy "%DesignCsv%" "%PublishedDir%"
echo %DesignCsv% copied.

:: NodeSet.xml is obsolete, no longer needed.
del /f /q "%PublishedDir%\*NodeSet.xml"

echo Completed.
pause

popd
endlocal