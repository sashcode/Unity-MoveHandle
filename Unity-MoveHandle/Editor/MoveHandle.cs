using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor( typeof(LookAtPoint) )] 
public class MoveHandle  : Editor
{

	void OnSceneGUI ()
	{
		LookAtPoint t = target as LookAtPoint;
		t.lookAtPoint = Handles.PositionHandle (t.lookAtPoint, Quaternion.identity);
		if (GUI.changed) {
			EditorUtility.SetDirty (t);
		}
	}
}
