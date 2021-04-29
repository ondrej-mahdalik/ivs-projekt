#Makefile
.PHONY: all clean run help

all: run


pack: clean packfolder
	cd ..\.. && 7z a -tzip xmahda14_xdenka00_xvacla35_xvrana29.zip xmahda14_xdenka00_xvacla35_xvrana29


packfolder:
	mkdir ..\..\xmahda14_xdenka00_xvacla35_xvrana29\repo
	mkdir ..\..\xmahda14_xdenka00_xvacla35_xvrana29\installer
	mkdir ..\..\xmahda14_xdenka00_xvacla35_xvrana29\docs\HTML
	cd ..\.. && xcopy ivs-projekt xmahda14_xdenka00_xvacla35_xvrana29\repo /s /q /y
	cd .. && xcopy install ..\xmahda14_xdenka00_xvacla35_xvrana29\installer /s /q /y
	xcopy docs\html ..\..\xmahda14_xdenka00_xvacla35_xvrana29\docs\HTML /s /q /y
	xcopy docs\Dokumentace.pdf ..\..\xmahda14_xdenka00_xvacla35_xvrana29\docs /s /q /y
	

clean:
	if exist GUI\bin rmdir /q /s GUI\bin 
	if exist GUI\obj rmdir /q /s gui\obj 
	if exist Math\bin rmdir /q /s Math\bin 
	if exist Math\obj rmdir /q /s Math\obj 
	if exist MathTest\bin rmdir /p /s MathTest\bin 
	if exist MathTest\obj rmdir /q /s MathTest\obj 
	if exist StandardDeviationTest\bin rmdir /q /s StandardDeviationTests\bin 
	if exist StandardDeviationTest\obj rmdir /q /s StandardDeviationTests\obj 
	if exist ..\..\xmahda14_xdenka00_xvacla35_xvrana29 rmdir /q /s ..\..\xmahda14_xdenka00_xvacla35_xvrana29 	

run: 
	cd ..\install\ && .\setup.exe

profile:
	cd StandardDeviation\bin\Release\netcoreapp3.1 && .\StandardDeviation < data.txt

help:
	echo "To run our calculator you need to run setup.exe in /installer or you can use make run."
	echo "Then you need to run gui.exe to start the application." 