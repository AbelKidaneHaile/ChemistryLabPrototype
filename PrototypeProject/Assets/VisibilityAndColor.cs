using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityAndColor : MonoBehaviour
{
    public MeshRenderer GlassLiquid;
    // Start is called before the first frame update
    public void HandleButtonClick()
    {
        string buttonName = gameObject.name;

        if (buttonName == "Button1")
        {
            // Change the color of the target Renderer for Button 1
            targetRenderer.material.color = Color.red;
        }
        else if (buttonName == "Button2")
        {
            // Change the color of the target Renderer for Button 2
            targetRenderer.material.color = Color.blue;
        }
        // Add more conditions for other buttons
    }
}

