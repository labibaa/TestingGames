using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject menuPanel;  // Reference to the menu UI Panel
    public GameObject gamePanel;  // Reference to the game UI Panel
    public Button playButton;     // Reference to the Play button

    public static bool gameStarted = false;  // Static variable to indicate if the game has started

    void Start()
    {
        // Show the menu UI and hide the game UI at the start
        menuPanel.SetActive(true);
        gamePanel.SetActive(false);

        // Add listener to the Play button
        playButton.onClick.AddListener(StartGame);

        // Ensure the game is not running at start
        gameStarted = false;
    }

    void Update()
    {
        if (gameStarted)
        {
            // Game logic goes here
        }
    }

    public void StartGame()
    {
        gameStarted = true;

        // Hide the menu UI and show the game UI
        menuPanel.SetActive(false);
        gamePanel.SetActive(true);

        // Initialize game components
        InitializeGame();
    }

    void InitializeGame()
    {
        // Put your game initialization logic here
        Debug.Log("Game Started");
    }
}



