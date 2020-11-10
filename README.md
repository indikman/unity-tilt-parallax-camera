# Unity Tilt Parallax Camera

This is the one of the easiest implementation to create a tilt parallax camera in Unity.

Does not use the Gyroscope, only take the accelerometer sensor inputs and gives an acceleration to the perspective camera in the viewport.

The movement is clamped by a maximum value, easily making this a parallax camera.

Can be used as a menu background.

### Usage

Download the project or the package and export.

Drag the `Parallax Tilt Camera` prefab in to the scene

Replace and Arrange the Images (Sprites) in the 3D viewport and adjust scale and position as necessary

Change the `Speed` variable to adjut the sensitivity value

Adjust the `CAM` positions to match your mix and max x,y values and change Clamp Min and Clamp Max values as necessary.

The images uses a separate layer and the camera has a culling mask for the layers. Be mindful about the layer name or the images wont be visible in the viewport.

**Images used in the project :**
<a href='https://www.freepik.com/vectors/background'>Background vector created by pikisuperstar - www.freepik.com</a>

[© Indika Wijesooriya ](https://www.wijesooriya.com)