using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    

    public void Hide_Main_Menu()
    {
        MainMenu.SetActive(false);
    }

}
