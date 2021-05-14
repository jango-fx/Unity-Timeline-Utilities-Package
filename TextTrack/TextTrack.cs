using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.UI;

namespace ArtCom.TimelineUtilities
{
    //[Serializable, DisplayName("GoToTime Marker")]
    [TrackColor(1.0f,1.0f,1.0f)]
    [TrackBindingType(typeof(UnityEngine.UI.Text))]
    [TrackClipType(typeof(ArtCom.TimelineUtilities.TextClip))]
    public class TextTrack : TrackAsset
    {
    }
}