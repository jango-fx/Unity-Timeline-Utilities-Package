using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using ArtCom.ScriptableObjects.Events;

namespace ArtCom.TimelineUtilities
{
    [Serializable, DisplayName("GameEvent Marker")]
    public class GameEventMarker : Marker, INotification//, INotificationOptionProvider 
    {
        /* public bool retroactive; */
        /* public bool emitOnce; */

        public string msg;
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

    public class GameEventMarkerReceiver : MonoBehaviour, INotificationReceiver
    {
        public void OnNotify(Playable origin, INotification notification, object context)
        {
            var marker = notification as GameEventMarker;
            if (marker == null)
                return;

            // GameEvent e = message.theEvent;
            Debug.Log(marker.msg);
            // Debug.Log(e);
            // e.Raise();
        }
    }
}