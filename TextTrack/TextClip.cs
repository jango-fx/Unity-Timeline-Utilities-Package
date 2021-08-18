// ----------------------------------------------------------------------------
// based on  25games' Unity Timeline Scripting - Custom Playables, Tracks and Clips | Unity and C# | Tutorial
// https://www.youtube.com/watch?v=LSrcQJHDUT4
// ----------------------------------------------------------------------------

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace ƒx.UnityUtils.Timeline
{
    [Serializable]
    public class TextClip : PlayableAsset, ITimelineClipAsset
    {
        //[SerializeField]
        // public TextBehaviour template = new TextBehaviour();
        public float progress;
        public String text;
        public int span;
        //public String theText = "";

        public ClipCaps clipCaps { get { return ClipCaps.None; } }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            TextBehaviour template = new TextBehaviour();
            template.SetClip(this);
            return ScriptPlayable<TextBehaviour>.Create(graph, template);
        }
    }
}