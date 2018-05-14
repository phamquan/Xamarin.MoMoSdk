echo "Hello"

rm -rf /output
mkdir output

echo "Building x86 libs"
xcodebuild -project MoMoiOSsdkv2.xcodeproj -target MoMoiOSsdkv2 -sdk iphonesimulator -configuration Release clean build
cp build/Release-iphonesimulator/libMoMoiOSsdkv2.a output/MoMoiOSsdkv2-i386.a

echo "Building arm64 libs"
xcodebuild -project MoMoiOSsdkv2.xcodeproj -target MoMoiOSsdkv2 -sdk iphoneos -arch arm64 -configuration Release clean build
cp build/Release-iphoneos/libMoMoiOSsdkv2.a output/MoMoiOSsdkv2-arm64.a

echo "Building armv7 libs"
xcodebuild -project MoMoiOSsdkv2.xcodeproj -target MoMoiOSsdkv2 -sdk iphoneos -arch armv7 -configuration Release clean build
cp build/Release-iphoneos/libMoMoiOSsdkv2.a output/MoMoiOSsdkv2-armv7.a

echo "Building armv7s libs"
xcodebuild -project MoMoiOSsdkv2.xcodeproj -target MoMoiOSsdkv2 -sdk iphoneos -arch armv7s -configuration Release clean build
cp build/Release-iphoneos/libMoMoiOSsdkv2.a output/MoMoiOSsdkv2-armv7s.a

echo "Building universal libs"
lipo -create -output output/MoMoiOSsdkv2-universal.a output/MoMoiOSsdkv2-i386.a output/MoMoiOSsdkv2-arm64.a output/MoMoiOSsdkv2-armv7.a output/MoMoiOSsdkv2-armv7s.a
