# Marker-Based AR Cube for Android

An XR Workshop mini-project by Vernit Gupta. Point an ARCore-compatible Android phone at the printed reference image to see a Unity cube appear over it.

## Run the project

1. Open this folder in Unity Hub with Unity 2022.3.62f2 and Android Build Support (SDK, NDK and OpenJDK).
2. Print `Assets/AR-Marker-14cm.png` at its actual size. The full square should be 14 cm wide.
3. Open `Assets/PhoneMarkerInteractive.unity`. Use Android with Google ARCore enabled in XR Plug-in Management.
4. Select File > Build Settings > Build And Run on a compatible Android phone. Grant camera permission and scan the print in good light.

## Workshop result

Marker detection and cube appearance were tested on an Android phone. I also added a touchscreen selection and scaling experiment. Reliable pinch resizing and camera-based hand tracking are outside the demonstrated result.

## Repository contents

- Assets contains the marker image and library, the cube prefab, and the Unity scenes.
- Packages records the Unity package dependencies.
- ProjectSettings contains build and editor configuration.

Unity regenerates its cache and imports packages on the first open.
