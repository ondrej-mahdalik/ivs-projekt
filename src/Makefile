#Makefile

all: run


Pack: clean packfolder
	cd ../.. && zip -r $@ ivs-projektzip


packfolder
	mkdir ../../ivs-projektzip/repo
	mkdir ../../ivs-projektzip/installer
	mkdir ../../ivs-projektzip/doc
	cp -a ../../ivs-projekt ../../ivs-projektzip/repo/
	cp -a ../installer/. ../../ivs-projetzip/installer/
	cp -a ../doc/. ../../ivs-projektzip/doc/

clean:
#TODO

run: 
	cd src/gui/bin/Debug && \.gui.exe

profile:
	cd src/StandardDeviation/bin/Debug/netcoreapp3.1 && \.StandardDeviation < data.txt

help
	echo "#TODO"