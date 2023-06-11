using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    public GameObject gameObject;

    public void ChangeVisibility()
    {
        if (gameObject.GetComponent<Renderer>().isVisible)
        {
            gameObject.SetActive(false);
        }
        else 
        {
            gameObject.SetActive(true);
        }
    }

}
