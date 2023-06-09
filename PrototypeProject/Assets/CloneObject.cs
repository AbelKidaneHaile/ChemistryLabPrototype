using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObject : MonoBehaviour
{
    public GameObject originalObject; // assign the original game object in the Inspector
    public Transform MainMenu;
    // Start is called before the first frame update
    public void ClonemyObject()
    {
        GameObject clone = Instantiate(originalObject);
        clone.transform.position = MainMenu.position;
        clone.transform.rotation = Quaternion.identity;// set the rotation of the clone
        clone.SetActive(true);

    }

}
