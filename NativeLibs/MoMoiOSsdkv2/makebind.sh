echo "Binding stated"
 sharpie bind \
    -o Binding \
    -sdk iphoneos11.2 \
    -scope . \
        ./MoMoiOSsdkv2/Classes/MoMo.h \
    -c \
        -Ibuild/Release-iphoneos/include -unified
