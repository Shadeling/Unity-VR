using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject gameOverWinMenu;
    [SerializeField] Text text;
    void Start()
    {
        
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void ReloadScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ShowPauseMenu()
    {
        Time.timeScale = 0.01f;
        pauseMenu.SetActive(true);
    }

    public void HidePauseMenu()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    public void ShowGameOverMenu()
    {
        Time.timeScale = 0.01f;

        text.text = "Вы проиграли :(";
        gameOverWinMenu.SetActive(true);
    }

    public void ShowWinMenu()
    {
        Time.timeScale = 0.01f;

        text.text = "Поздравляем, вы победили!";
        gameOverWinMenu.SetActive(true);
    }

    public void HideGameOverWinMenu()
    {
        Time.timeScale = 1f;
        gameOverWinMenu.SetActive(false);
    }

}
