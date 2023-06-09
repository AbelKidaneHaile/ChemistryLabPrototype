using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MeshSwitchScript : MonoBehaviour 
{
    private GameObject CurrentPrefab;
    //[HideInInspector]
    public List<GameObject> PrefabList;

    public void SetPrefab(int selected)
    {
        if (CurrentPrefab != null)
            GameObject.DestroyImmediate(CurrentPrefab);
        
        if(selected < PrefabList.Count)
        {
            CurrentPrefab = Instantiate(PrefabList[selected]);
            CurrentPrefab.transform.SetParent(this.transform, false);
        }
    }
}