// The MIT License (MIT)
//
// Copyright (c) 2014 Daniel Groft
//
// https://github.com/dgroft/UnityExtensions
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using UnityEngine;
using System;
using System.Collections;

namespace dgroft.UnityExtensions.Scripts.Interpolation
{
    public static class Interpolate
    {
        /// <summary>
        /// Performs spherical interpolation of a game object's transform from its current
        /// position to its new position in seconds, and invokes the callback upon completion.
        /// </summary>
        public static void PositionSlerp(this MonoBehaviour obj, Vector3 toPos, float seconds, Action done)
        {
            Vector3 origin = obj.gameObject.transform.position;

            Action<float> applyInterpFunc = (f) => {
            	obj.gameObject.transform.position = Vector3.Slerp(origin, toPos, f);
            };

            if (obj != null) { obj.StartCoroutine(Interpolate(applyInterpFunc, seconds, done)); }
        }

		/// <summary>
        /// Performs linear interpolation of a game object's transform from its current
        /// rotation to its new rotation in seconds, and invokes the callback upon completion.
        /// </summary>
        public static void RotationLerp(this MonoBehaviour obj, Quaternion toRot, float seconds, Action done)
        {
            Quaternion origin = obj.gameObject.transform.rotation;

            Action<float> applyInterpFunc = (f) => {
            	obj.gameObject.transform.rotation = Quaternion.Lerp(origin, toRot, f);
            };

            if (obj != null) { obj.StartCoroutine(Interpolate(applyInterpFunc, seconds, done)); }
        }

		/// <summary>
        /// Performs linear interpolation of a game object's transform from its current
        /// local scale to its new local scale in seconds, and invokes the callback upon completion.
        /// </summary>
        public static void ScaleLerp(this MonoBehaviour obj, Vector3 toScale, float seconds, Action done)
        {
            Vector3 origin = obj.gameObject.transform.localScale;

            Action<float> applyInterpFunc = (f) => {
            	obj.gameObject.transform.localScale = Vector3.Lerp(origin, toScale, f);
            };

            if (obj != null) { obj.StartCoroutine(Interpolate(applyInterpFunc, seconds, done)); }
        }

	private static IEnumerator Interpolate(Action<float> applyInterpFunc, float seconds, Action done)
	{
		float accumulatedTime = 0;

		int percent = 0;

		while (percent <= 100)
		{
			applyInterpFunc(Mathf.SmoothStep(0.0f, 1.0f, accumulatedTime / seconds));
			accumulatedTime += Time.deltaTime;
			percent = (int)((accumulatedTime / seconds) * 100);
			yield return true;	
		}

		if (done != null) { done(); }
	}
    }
}
