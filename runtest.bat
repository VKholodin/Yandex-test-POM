call "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\vcvarsall.bat"

vstest.console.exe "C:\Your_location\YandexSimpleTest\YandexSimpleTest\bin\Debug\YandexSimpleTest.dll" /Tests:VerifyYandexLinkAsFisrt,  /logger:trx 
