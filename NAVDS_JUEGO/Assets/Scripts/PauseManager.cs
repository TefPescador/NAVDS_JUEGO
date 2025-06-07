using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pausePanel;
    //public Button resumeButton;
    //public Button restartButton;
    private bool isPaused = false;

    void Start()
    {
        pausePanel.SetActive(false);

        // Asignar funciones a botones
        //resumeButton.onClick.AddListener(ResumeGame);
        //restartButton.onClick.AddListener(RestartGame);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f;
            pausePanel.SetActive(true);
        }
        else
        {
            ResumeGame();
        }
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Asegúrate de reanudar antes de reiniciar
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
