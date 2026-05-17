# Unity WebGL Native Mobile Camera

Live Demo: https://antonio.hr/WebGL-Native-Mobile-Camera/

<img width="175" height="414" alt="image" src="https://github.com/user-attachments/assets/92fac2a4-c95e-4ac0-9bf0-4219f4aeb669" />

<img width="175" height="414" alt="image" src="https://github.com/user-attachments/assets/59ac6b11-fd00-47ca-aaf3-b8f60e51d712" />

<img width="175" height="414" alt="image" src="https://github.com/user-attachments/assets/9f4e3a8a-d7e7-464b-94af-8ce86e3791e6" />

Open the real native phone camera in Unity WebGL without using low-quality browser camera streams.

This project solves the problem of accessing the actual system camera app on mobile browsers from Unity WebGL, while also avoiding common browser camera stream limitations such as poor quality, autofocus issues, and lack of flashlight support.
## Features

* Opens the real native mobile camera
* Returns captured photos back to Unity
* Converts photos into Unity Texture2D
* Better quality than WebRTC/getUserMedia streams
* Works on Android and iPhone browsers

## Why this exists

Most Unity WebGL camera solutions use browser camera streams:

```js
navigator.mediaDevices.getUserMedia()
```

This often causes:

* low image quality
* autofocus issues
* poor OCR results
* unstable mobile browser behavior

This project avoids those problems by opening the real native system camera instead.

## Setup

Place:

```text
Assets/Plugins/WebGL/CameraBridge.jslib
```

Attach `CameraManager.cs` to a GameObject named:

```text
CameraManager
```

## Requirements

* Unity WebGL
* HTTPS hosting
* Mobile browser
