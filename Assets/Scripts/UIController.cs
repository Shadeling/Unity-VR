using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
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

}
