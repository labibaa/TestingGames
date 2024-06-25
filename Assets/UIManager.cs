using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject pausePanel;
    public GameObject winningPanel;
    public GameObject gameUIPanel;

    public GameObject[] quest;
    public static UIManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void StartGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        startPanel.SetActive(false);
        gameUIPanel.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit button clicked");
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}
