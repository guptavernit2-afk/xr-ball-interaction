# XR Workshop Mini Projects

Two Unity projects by **Vernit Gupta** from the XR Workshop. One is a ball interaction demo for Meta Quest. The other is an Android phone app that places a cube over a printed image.

| Project | Device | What to try |
| --- | --- | --- |
| [XR Ball Interaction](XR-Ball-Interaction/) | Meta Quest | Try grabbing the sphere with the hand interaction rig and experiment with the in-world motion controls. |
| [Marker AR Cube](Marker-AR-Cube/) | ARCore-compatible Android phone | Point the rear camera at the printed reference image to see the cube appear over it. |

## Open either project

1. Clone this repository or choose **Code > Download ZIP** on GitHub and extract it.
2. Install **Unity 2022.3.62f2** with **Android Build Support**, **Android SDK & NDK Tools**, and **OpenJDK**.
3. In Unity Hub, choose **Add > Add project from disk** and select the individual project folder. Each folder has its own Assets, Packages, and ProjectSettings.
4. Let Unity finish importing the project before opening its scene. Build each project separately for its target device.

## XR Ball Interaction

Open [SampleScene.unity](XR-Ball-Interaction/Assets/Scenes/SampleScene.unity). The sphere moves side to side while travelling forward and back at a fixed height. The scene includes an Oculus Interaction Sample Rig and a control panel for speed, travel range, side swing, and frequency.

- [SineWaveMovement.cs](XR-Ball-Interaction/Assets/scripts/SineWaveMovement.cs) drives the sphere's motion.
- [BallControlPanel.cs](XR-Ball-Interaction/Assets/scripts/BallControlPanel.cs) builds the controls and updates their values.

For a headset test, use a Meta Quest with Developer Mode enabled, connect it via USB, and choose **File > Build Settings > Android > Build And Run** with **SampleScene** included. Set down the controllers if you are testing tracked hands, then reach for the sphere and try a grab.

## Marker AR Cube

Open [PhoneMarkerInteractive.unity](Marker-AR-Cube/Assets/PhoneMarkerInteractive.unity). Print the [reference marker](Marker-AR-Cube/Assets/AR-Marker-14cm.png) at actual size and check that the full square is **14 cm wide**. Build and run on an ARCore-compatible Android phone, grant camera access, and aim the rear camera at the print in good light.

Marker detection and cube placement were demonstrated on a phone. Touchscreen pinch scaling is an experiment and was unreliable during testing. This phone demo uses ARCore image tracking. The Quest project uses headset hand input.

## Workshop screenshots

- [Android tracked-image scene in Unity](Marker-AR-Cube/docs/unity-tracking-setup.png)
- [Cube prefab in Unity](Marker-AR-Cube/docs/unity-cube-prefab.png)

## Android live demo photos

- [Cube shown between two fingers in the camera view](Marker-AR-Cube/docs/android-ar-cube-pinch-view.png)
- [Cube shown over an open palm in the camera view](Marker-AR-Cube/docs/android-ar-cube-palm-view.png)

Both photos show the cube rendered with the reference image visible in the background. They capture the marker AR demo during interaction testing.
