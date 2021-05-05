using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace ArtCom.TimelineUtilities
{
    public class GoToTimeMarkerReceiver : MonoBehaviour, INotificationReceiver
    {
        public PlayableDirector playableDirector;

        void Start()
        {
            if (playableDirector == null) playableDirector = GetComponent<PlayableDirector>();
        }

        public void OnNotify(Playable origin, INotification notification, object context)
        {
            var marker = notification as GoToTimeMarker;
            if (marker == null)
                return;

            Debug.Log("Go To Frame #" + marker.theTime);
            playableDirector.Play();
            playableDirector.time = marker.theTime;
        }
    }
}