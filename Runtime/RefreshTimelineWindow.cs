#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

[ExecuteInEditMode]
public class RefreshTimelineWindow : MonoBehaviour
{
    static public void Refresh()
    {
        TimelineEditorWindow thewindow = (TimelineEditorWindow)EditorWindow.GetWindow(typeof(TimelineEditorWindow), true, "Timeline", true);
        thewindow.Focus();
        thewindow.Repaint();
    }
}

#endif