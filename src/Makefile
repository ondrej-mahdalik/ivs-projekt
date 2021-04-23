#Makefile
.PHONY: all clean run help

all: run


Pack: clean packfolder
	cd ..\.. && zip -r $@ xmahda14_xdenka00_xvacla35_xvrana29


packfolder:
	mkdir ..\..\xmahda14_xdenka00_xvacla35_xvrana29\repo
	mkdir ..\..\xmahda14_xdenka00_xvacla35_xvrana29\installer
	mkdir ..\..\xmahda14_xdenka00_xvacla35_xvrana29\docs
	copy -a ..\..\ivs-projekt ..\..\xmahda14_xdenka00_xvacla35_xvrana29\repo\
	copy -a ..\installer\. ..\..\xmahda14_xdenka00_xvacla35_xvrana29\installer\
	copy -a docs\. ..\..\xmahda14_xdenka00_xvacla35_xvrana29\docs
	copy docs\latex\refman.pdf ..\dokumentace.pdf

clean:
	del /F /Q /P GUI\bin gui\obj Math\bin Math\obj MathTest\bin MathTest\obj StandardDeviationTests\bin StandardDeviationTests\obj ..\..\xmahda14_xdenka00_xvacla35_xvrana29

run: 
	cd ..\install\ && .\setup.exe

profile:
	cd src\StandardDeviation\bin\Debug\netcoreapp3.1 && \.StandardDeviation < data.txt

help:
	echo "To run our calculator you need to run setup.exe in /installer or you can use make run."
	echo "Then you need to run gui.exe to start the application." 