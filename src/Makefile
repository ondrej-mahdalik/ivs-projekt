#Makefile

all: run


Pack: clean packfolder
	cd ../.. && zip -r $@ xmahda14_xdenka00_xvacla35_xvrana29


packfolder
	mkdir ../../xmahda14_xdenka00_xvacla35_xvrana29/repo
	mkdir ../../xmahda14_xdenka00_xvacla35_xvrana29/installer
	mkdir ../../xmahda14_xdenka00_xvacla35_xvrana29/doc
	cp -a ../../ivs-projekt ../../xmahda14_xdenka00_xvacla35_xvrana29/repo/
	cp -a ../installer/. ../../xmahda14_xdenka00_xvacla35_xvrana29/installer/
	cp -a ../doc/. ../../xmahda14_xdenka00_xvacla35_xvrana29/doc/

clean:
	del -rf src/gui/bin src/gui/obj src/Math/bin src/Math/obj src/MathTest/bin src/MathTest/obj src/StandardDeviationTests/bin src/StandardDeviationTests/obj ../../xmahda14_xdenka00_xvacla35_xvrana29/

run: 
	cd install/ && .\setup.exe

profile:
	cd src/StandardDeviation/bin/Debug/netcoreapp3.1 && \.StandardDeviation < data.txt

help
	echo "To run our calculator you need to run setup.exe in /installer or you can use make run."
	echo "Then you need to run gui.exe to start the application." 