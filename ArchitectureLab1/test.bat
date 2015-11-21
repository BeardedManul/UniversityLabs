@echo off
chcp 866 >nul
rem TEST 1
del .\testres.txt
cd.>.\Test\test1\test.txt
.\FileDel.exe .\Test\test1\test.txt /F
Echo Test 1 - Deleting single files > .\testres.txt
if "%ERRORLEVEL%" == "0" goto success1

:fail1
Echo Test fails >> .\testres.txt
Echo return value = "%ERRORLEVEL%" >> .\testres.txt
pause
goto TEST_2
:success1
Echo Test passed >> .\testres.txt
Echo return value = "%ERRORLEVEL%" >> .\testres.txt
goto TEST_2

:TEST_2
md .\Test\test2\test
.\FileDel.exe .\Test\test2\test /P
Echo Test 2 - Deleting single folders >> .\testres.txt
if "%ERRORLEVEL%" == "0" goto success2

:fail2
Echo Test fails
Echo Test fails >> .\testres.txt
Echo return value = "%ERRORLEVEL%" >> .\testres.txt
pause
goto TEST_3
:success2
Echo Test passed
Echo Test passed >> .\testres.txt
Echo return value = "%ERRORLEVEL%" >> .\testres.txt
goto TEST_3

:TEST_3
md .\Test\test3\test
md .\Test\test3\test\test
cd.>.\Test\test3\test\test.txt
.\FileDel.exe .\Test\test3\test /S
Echo Test 3 - Remove the contents of the folder >> .\testres.txt
if "%ERRORLEVEL%" == "0" goto success3

:fail3
Echo Test fails
Echo Test fails >> .\testres.txt
Echo return value = "%ERRORLEVEL%" >> .\testres.txt
pause
goto TEST_4
:success3
Echo Test passed
Echo Test passed >> .\testres.txt
Echo return value = "%ERRORLEVEL%" >> .\testres.txt
goto TEST_4

:TEST_4
.\FileDel.exe .\Test\test4\test.txt /F
Echo Test 4 - Entering an incorrect file path >> .\testres.txt
if "%ERRORLEVEL%" == "-1" goto success4

:fail4
Echo Test fails
Echo Test fails >> .\testres.txt
Echo return value = "%ERRORLEVEL%" >> .\testres.txt
pause
goto TEST_5
:success4
Echo Test passed >> .\testres.txt
Echo return value = "%ERRORLEVEL%" >> .\testres.txt
goto TEST_5

:TEST_5
.\FileDel.exe .\Test\test5\test /P
Echo Test 5 - Entering an incorrect folder path. Part 1 >> .\testres.txt
if "%ERRORLEVEL%" == "-1" goto success5

:fail5
Echo Test fails
Echo Test fails >> .\testres.txt
Echo return value = "%ERRORLEVEL%" >> .\testres.txt
pause
goto TEST_6
:success5
Echo Test passed
Echo Test passed >> .\testres.txt
Echo return value = "%ERRORLEVEL%" >> .\testres.txt
goto TEST_6

:TEST_6
.\FileDel.exe .\Test\test3\test /S
Echo Test 6 - Entering an incorrect folder path. Part 2 >> .\testres.txt
if "%ERRORLEVEL%" == "-1" goto success6

:fail6
Echo Test fails
Echo Test fails >> .\testres.txt
Echo return value = "%ERRORLEVEL%" >> .\testres.txt
pause
goto TEST_7
:success6
Echo Test passed
Echo Test passed >> .\testres.txt
Echo return value = "%ERRORLEVEL%" >> .\testres.txt
goto TEST_7

:TEST_7
md .\Test\test8\test1\
md .\Test\test8\test2\
cd.>.\Test\test8\test1\test.txt
cd.>.\Test\test8\test2\test.txt
.\FileDel.exe .\Test\test8\ test.txt /C
Echo Test 8 - Find and delete chosen file >> .\testres.txt
if "%ERRORLEVEL%" == "0" goto success7

:fail7
Echo Test fails
Echo Test fails >> .\testres.txt
Echo return value = "%ERRORLEVEL%" >> .\testres.txt
pause
exit
:success7
Echo Test passed
Echo Test passed >> .\testres.txt
Echo return value = "%ERRORLEVEL%" >> .\testres.txt
exit