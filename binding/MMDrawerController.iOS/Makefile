MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild
VERSION=1.21

all: Gimbal.iOS.dll

gimbalsdk_$(VERSION)_ios.zip:
	curl -O http://storage.bos.xamarin.com/tmp/bholmes/cbt/sdk-inputs/gimbalsdk_$(VERSION)_ios.zip > $@
	unzip $@ -d gimbalsdk_1

Binaries: gimbalsdk_$(VERSION)_ios.zip
	cp gimbalsdk_1/Frameworks/Common.embeddedframework/Common.framework/Versions/$(VERSION)/Common Common
	cp gimbalsdk_1/Frameworks/ContextCore.embeddedframework/ContextCore.framework/Versions/$(VERSION)/ContextCore ContextCore
	cp gimbalsdk_1/Frameworks/ContextLocation.embeddedframework/ContextLocation.framework/Versions/$(VERSION)/ContextLocation ContextLocation
	cp gimbalsdk_1/Frameworks/ContextProfiling.embeddedframework/ContextProfiling.framework/Versions/$(VERSION)/ContextProfiling ContextProfiling
	cp gimbalsdk_1/Frameworks/NetworkServices.embeddedframework/NetworkServices.framework/Versions/$(VERSION)/NetworkServices NetworkServices
	cp gimbalsdk_1/Frameworks/FYX.framework/Versions/$(VERSION)/FYX FYX

Resources/DataModels.bundle: gimbalsdk_$(VERSION)_ios.zip Binaries
	mkdir Resources
	cp -R gimbalsdk_1/Frameworks/ContextLocation.embeddedframework/ContextLocation.framework/Versions/$(VERSION)/Resources/* Resources/DataModels.bundle

Gimbal.iOS.dll: Makefile StructsAndEnums.cs Binaries Resources/DataModels.bundle
	$(MONOXBUILD) /p:Configuration=Release Gimbal.iOS.csproj
	cp bin/Release/Gimbal.iOS.dll Gimbal.iOS.dll

prepare: Resources/DataModels.bundle

clean:
	-rm -rf list ios Resources/ gimbalsdk_1/ bin/ obj/ *.sln *.userprefs *.dll *.o *.zip *.mdb Common ContextCore ContextLocation ContextProfiling NetworkServices FYX