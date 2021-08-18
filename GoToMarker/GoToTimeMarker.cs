using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace ƒx.UnityUtils.Timeline
{
    [Serializable, DisplayName("Custom Markers/GoToTime Marker")]
    public class GoToTimeMarker : Marker, INotification//, INotificationOptionProvider 
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
}