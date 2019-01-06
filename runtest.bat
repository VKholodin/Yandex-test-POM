call "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\vcvarsall.bat"

vstest.console.exe "D:\My_GIT\YandexSimpleTest\YandexSimpleTest\bin\Debug\YandexSimpleTest.dll" /Tests:Verify_Yandex_Link_As_Fisrt,  /logger:trx 
