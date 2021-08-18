/*

using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
//using UnityUtils.ScriptableObjects.Events;

namespace ƒx.UnityUtils.Timeline
{
    
    //[ExecuteInEditMode]
    public class GameEventMarkerReceiver : MonoBehaviour, INotificationReceiver
{
    public void OnNotify(Playable origin, INotification notification, object context)
    {
            var marker = notification as GameEventMarker;
            if (marker == null)
                return;

            //Debug.Log(marker.msg);
            Debug.Log(marker.gameEvent);
            marker.gameEvent.Raise();
            
        }
    }
    
}
*/