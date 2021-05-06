using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
//using ArtCom.ScriptableObjects.Events;

namespace ArtCom.TimelineUtilities
{
    // TODO: make it work on an signal track
    [Serializable, DisplayName("GameEvent Marker")]
    public class GameEventMarker : Marker, INotification, INotificationOptionProvider // , INotificationReceiver
    {
        //[SerializeField] public bool retroactive;
        //[SerializeField] public bool emitOnce;
        [SerializeField] public bool emitInEditor;

        //public string msg;
        public ScriptableObject gameEvent;

        // public PropertyName id { get { return new PropertyName(); } }

        /*
                NotificationFlags INotificationOptionProvider.flags
                {
                    get
                    {
                        return 
                            (retroactive ? NotificationFlags.Retroactive : default(NotificationFlags)) |
                            (emitOnce ? NotificationFlags.TriggerOnce : default(NotificationFlags)) |
                            (emitInEditor ? NotificationFlags.TriggerInEditMode : default(NotificationFlags)); 
                    }
                }
                */

        public PropertyName id { get; }

        NotificationFlags INotificationOptionProvider.flags
        {
            get
            {
                return
                    (emitInEditor ? NotificationFlags.TriggerInEditMode : default(NotificationFlags));
            }
        }
    }
}