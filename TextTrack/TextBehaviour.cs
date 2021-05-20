// ----------------------------------------------------------------------------
// based on  25games' Unity Timeline Scripting - Custom Playables, Tracks and Clips | Unity and C# | Tutorial
// https://www.youtube.com/watch?v=LSrcQJHDUT4
// ----------------------------------------------------------------------------

using System;
using UnityEngine;
using UnityEngine.Playables;

namespace ArtCom.TimelineUtilities
{
    [Serializable]
    public class TextBehaviour : PlayableBehaviour
    {
        private bool firstFrameHappened = false;
        private String defaultText;
        private UnityEngine.UI.Text textfield;
        private TextClip clip;

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            base.ProcessFrame(playable, info, playerData);

            if (!firstFrameHappened)
            {
                textfield = playerData as UnityEngine.UI.Text;
                defaultText = textfield.text;
                firstFrameHappened = true;
            }
            else
            {
                if (clip.text.Length > 0)
                {
                    clip.progress = (float)(playable.GetTime() / playable.GetDuration());
                    int index = Mathf.RoundToInt((clip.text.Length - 1) * clip.progress);

                    String croppedText = "";
        
                    int start = Mathf.Max(0, index - clip.span);
                    int stop = Mathf.Min(clip.text.Length - 1, index + clip.span);
                    croppedText = clip.text.Substring(start, stop-start);
                    textfield.text = croppedText;
                }
            }
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            firstFrameHappened = false;
            if (textfield == null) return;

            textfield.text = defaultText;

            clip.name = clip.text.Substring(0, Mathf.Min(20, clip.text.Length - 1)) + "..."; // TODO: not working

            base.OnBehaviourPause(playable, info);
        }

        public void SetClip(TextClip _clip)
        {
            clip = _clip;
        }
    }
}