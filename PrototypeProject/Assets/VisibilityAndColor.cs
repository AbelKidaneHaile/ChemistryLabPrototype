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

        if (buttonName == "H2SO4Button")
        {
            // Change the color of the target Renderer for Button 1
            GlassLiquid.material.color = Color.red;
        }
        else if (buttonName == "H2CrO4Button")
        {
            // Change the color of the target Renderer for Button 2
            GlassLiquid.material.color = Color.red;
        }
        else if(buttonName == "NaOHButton")
        {
            GlassLiquid.material.color = Color.white;
        }
        else if (buttonName == "CuSO4Button")
        {
            GlassLiquid.material.color = Color.blue;
        }
        
    }
}

