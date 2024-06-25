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
            UIManager.instance.GameWon();
            Debug.Log("All components collected!");
        }
    }
  
}

