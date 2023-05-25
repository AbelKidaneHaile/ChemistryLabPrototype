using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public Transform HandMenu;

    public void Spawn_Main_Menu()
    {
        MainMenu.transform.position = HandMenu.position;
        MainMenu.transform.rotation = HandMenu.rotation;
        MainMenu.SetActive(true);
        
    }

}
