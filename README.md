UnityExtensions
===============

This project contains a series of extensions for use with Unity 3D.

## Interpolation

Inspired by many of <a href="http://jquery.com/">jQuery</a>'s functions, this project provides a way to interpolate position, rotation or scale given a basic set of parameters:
* Where you want to go?
* How long do you want it to take to get there?
* Tell me when you're done.

You'll notice that the extension methods for interpolation can only be called on objects that derive from MonoBehaviour. This is required because the interpolation relies on <a href="http://docs.unity3d.com/Documentation/Manual/Coroutines.html">Coroutines</a>, which MonoBehaviour provides access to.

The use of the extension methods directly is recommended, but a separate Interpolate.cs script is provided so that you can attach it to the GameObject you wish to interpolate, complete with wrapper functions to the underlying extensions.

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
