UnityExtensions
===============

This project contains a series of extensions for use with Unity 3D.

## Interpolation

You'll notice that with interpolations, the extension methods for interpolation can only be called on objects that derive from MonoBehaviour. This is required because the interpolation relies on CoRoutines, which MonoBehaviour provides access to.

The use of the extension methods directly is recommended, but a separate Interpolate.cs script is provided so that you can attach it to GameObject you wish to interpolate, complete with wrapper functions to the extensions.

### Usage

The MonoBehavior-derived script is pretty straight-forward. The use of the extensions directly is recommended, and below outlines their use.

```
using dgroft.UnityExtensions.Scripts.Interpolation;

...

// your destination
Vector3 newPos = new Vector3(100, 200, 300);

// your duration
float seconds = 1.0f;

// somewhere inside of your existing MonoBehaviour script that's attached to the object you wish to interpolate
this.PositionSlerp(newPos, seconds, () => {
  // do some work here when the interpolation is complete
});
```
