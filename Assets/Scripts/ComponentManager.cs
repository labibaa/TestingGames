using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComponentManager : MonoBehaviour
{
    public static ComponentManager instance;

    public Image[] componentImages; // UI Images to show collected components
    public Sprite collectedSprite; // Sprite to show when a component is collected
    private int collectedCount = 0;

    public GameObject startMenuPanel;
    public GameObject pauseMenuPanel;
    public GameObject gameUIPanel; 
    public GameObject winningPanel;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CollectComponent(GameObject component)
    {
        component.SetActive(false); // Hide the collected component
        componentImages[collectedCount].sprite = collectedSprite; // Update UI
        collectedCount++;

        if (collectedCount == componentImages.Length)
        {
            // All components collected
            Time.timeScale = 0f;
            winningPanel.SetActive(true);
            startMenuPanel.SetActive(false);
            pauseMenuPanel.SetActive(false);
            gameUIPanel.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Debug.Log("All components collected!");
        }
    }
}

