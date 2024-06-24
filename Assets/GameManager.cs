using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject startMenuPanel;
    public GameObject pauseMenuPanel;
    public GameObject gameUIPanel;
    public GameObject playerCamera; // Reference to the player camera or camera controller

    private enum GameState { MainMenu, Playing, Paused, Back, PlayAgain }
    private GameState currentGameState;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        SetGameState(GameState.MainMenu);
    }

    private void Update()
    {
        if (currentGameState == GameState.Playing && Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void StartGame()
    {
        SetGameState(GameState.Playing);
    }

    public void TogglePause()
    {
        if (currentGameState == GameState.Playing)
        {
            SetGameState(GameState.Paused);
        }
        else if (currentGameState == GameState.Paused)
        {
            SetGameState(GameState.Playing);
        }
    }
    public void PlayAgain()
    {
        SetGameState(GameState.PlayAgain);
    }

    public void BackToMenu()
    {
        SetGameState(GameState.Back);
    }

    private void SetGameState(GameState newState)
    {
        currentGameState = newState;

        switch (newState)
        {
            case GameState.MainMenu:
                Time.timeScale = 0f;
                startMenuPanel.SetActive(true);
                pauseMenuPanel.SetActive(false);
                gameUIPanel.SetActive(false);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                playerCamera.GetComponent<CameraController>().enabled = false; // Disable camera control
                break;
            case GameState.Playing:
                Time.timeScale = 1f;
                startMenuPanel.SetActive(false);
                pauseMenuPanel.SetActive(false);
                gameUIPanel.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                playerCamera.GetComponent<CameraController>().enabled = true; // Enable camera control
                break;
            case GameState.Paused:
                Time.timeScale = 0f;
                startMenuPanel.SetActive(false);
                pauseMenuPanel.SetActive(true);
                gameUIPanel.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                playerCamera.GetComponent<CameraController>().enabled = false; // Disable camera control
                break;
            case GameState.PlayAgain:
                Time.timeScale = 1f;
                startMenuPanel.SetActive(false);
                pauseMenuPanel.SetActive(false);
                gameUIPanel.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                playerCamera.GetComponent<CameraController>().enabled = true; // Enable camera control
                break;
            case GameState.Back:
                Time.timeScale = 0f;
                startMenuPanel.SetActive(true);
                pauseMenuPanel.SetActive(false);
                gameUIPanel.SetActive(false);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                playerCamera.GetComponent<CameraController>().enabled = false; // Disable camera control
                break;

        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}





