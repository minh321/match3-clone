using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject pauseButton;
    public GameObject endGameUI;
    public static UIManager instance;
    private void Awake()
    {
        instance = this;
    }
    public void OnPauseGame()
    {
        pauseMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
    }
    public void OnResumeGame()
    {
        pauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
    }
    public void OnRestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnEndGame()
    {
        endGameUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
