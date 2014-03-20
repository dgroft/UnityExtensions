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

using dgroft.UnityExtensions.Scripts.Interpolation.Extensions;
using System;
using UnityEngine;

namespace dgroft.UnityExtensions.Scripts.Interpolation
{
    public class Interpolate : MonoBehaviour
    {
        /// <summary>
        /// Performs spherical interpolation of a game object's transform from its current
        /// position to its new position in seconds, and invokes the callback upon completion.
        /// </summary>
        public void PositionSlerp(Vector3 toPos, float seconds, Action done)
        {
            this.PositionSlerp(toPos, seconds, done);
        }

        /// <summary>
        /// Performs linear interpolation of a game object's transform from its current
        /// rotation to its new rotation in seconds, and invokes the callback upon completion.
        /// </summary>
        public void RotationLerp(Quaternion toRot, float seconds, Action done)
        {
            this.RotationLerp(toRot, seconds, done);
        }

        /// <summary>
        /// Performs linear interpolation of a game object's transform from its current
        /// local scale to its new local scale in seconds, and invokes the callback upon completion.
        /// </summary>
        public void ScaleLerp(Vector3 toScale, float seconds, Action done)
        {
            this.ScaleLerp(toScale, seconds, done);
        }
    }
}