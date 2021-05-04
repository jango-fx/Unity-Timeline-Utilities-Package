using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace ArtCom.TimelineUtilities
{
    [Serializable, DisplayName("GoToFrame Marker")]
    public class GoToMarker : Marker, INotification//, INotificationOptionProvider 
    {
        /* public bool retroactive; */
        /* public bool emitOnce; */

        public float theTime;
        public PropertyName id { get { return new PropertyName(); } }

        /* NotificationFlags INotificationOptionProvider.flags
        {
            get
            {
                return (retroactive ? NotificationFlags.Retroactive : default(NotificationFlags)) |
                    (emitOnce ? NotificationFlags.TriggerOnce : default(NotificationFlags));
            }
        } */
    }

    public class GoToMarkerReceiver : MonoBehaviour, INotificationReceiver
    {
        public PlayableDirector playableDirector;

        void Start()
        {
            if (playableDirector == null) playableDirector = GetComponent<PlayableDirector>();
        }

        public void OnNotify(Playable origin, INotification notification, object context)
        {
            var marker = notification as GoToMarker;
            if (marker == null)
                return;

            Debug.Log("Go To Frame #" + marker.theTime);
            playableDirector.Play();
            playableDirector.time = marker.theTime;
        }
    }
}