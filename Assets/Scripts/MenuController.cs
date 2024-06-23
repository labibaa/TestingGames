using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuPanel; // Drag your menu panel GameObject here in the Inspector

    public void StartGame()
    {
        // Perform actions to start the game (load scene, enable player control, etc.)

        // Close the menu panel
        menuPanel.SetActive(false); // Deactivate the menu panel
        Debug.Log("Menu Panel Active: " + menuPanel.activeSelf);
    }

    
}

