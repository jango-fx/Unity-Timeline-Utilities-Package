// ----------------------------------------------------------------------------
// based on  25games' Unity Timeline Scripting - Custom Playables, Tracks and Clips | Unity and C# | Tutorial
// https://www.youtube.com/watch?v=LSrcQJHDUT4
// ----------------------------------------------------------------------------

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.UI;

namespace UnityUtils.TimelineUtilities
{
    [TrackColor(1.0f,1.0f,1.0f)]
    [TrackBindingType(typeof(UnityEngine.UI.Text))]
    [TrackClipType(typeof(UnityUtils.TimelineUtilities.TextClip))]
    public class TextTrack : TrackAsset
    { }
}