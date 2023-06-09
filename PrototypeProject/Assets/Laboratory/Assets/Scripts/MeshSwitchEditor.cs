using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(MeshSwitchScript))]
public class MeshSwitchEditor : Editor
{
    private int tmpSave;
    private int selected;

	public override void OnInspectorGUI()
	{
        DrawDefaultInspector();

        MeshSwitchScript myScript = (MeshSwitchScript)target;

        if (myScript == null || myScript.PrefabList == null ||
            myScript.PrefabList.Count <= 0) return;
        
        string[] options = new string[myScript.PrefabList.Count];

        for(int i = 0; i < myScript.PrefabList.Count; i++)
        {
            if(myScript.PrefabList[i] != null)
                options[i] = myScript.PrefabList[i].name;
        }
        
        int prevSelected = tmpSave;

        selected = tmpSave;

        selected = EditorGUILayout.Popup("Current Prefab", selected, options);

        if (prevSelected != selected)
        {
            myScript.SetPrefab(selected);
            tmpSave = selected;
        }
    }
}