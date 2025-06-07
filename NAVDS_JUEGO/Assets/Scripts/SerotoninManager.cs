using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SerotoninManager : MonoBehaviour
{
    [SerializeField] private Slider serotoninBar;

    int sceneIndex = SceneManager.GetActiveScene().buildIndex;


    private bool gameOverTriggered = false;

    //public int gameOverScene;

    //public GameObject GameOver;

    void Start()
    {
        //GameOver.SetActive(false);
        if (serotoninBar != null)
        {
            serotoninBar.maxValue = 100f;
            serotoninBar.value = Serotonin.Instance.currentSerotonin;
        }
    }

    public void OnLevelFailed()
    {
        Serotonin.Instance.currentSerotonin -= 25f;
        Serotonin.Instance.currentSerotonin = Mathf.Clamp(Serotonin.Instance.currentSerotonin, 0, 100f);
        UpdateBar();
        CheckSerotonin();
    }

    public void OnLevelWin()
    {
        Serotonin.Instance.currentSerotonin += 25f;
        Serotonin.Instance.currentSerotonin = Mathf.Clamp(Serotonin.Instance.currentSerotonin, 0, 100f);
        UpdateBar();
        CheckSerotonin();
    }

    private void UpdateBar()
    {
        serotoninBar.value = Serotonin.Instance.currentSerotonin;
    }

    private void CheckSerotonin()
    {
        if (!gameOverTriggered && Serotonin.Instance.currentSerotonin <= 0)
        {
            gameOverTriggered = true;

            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            if (currentSceneIndex == 1 || currentSceneIndex == 2) // Suponiendo 0 = NivelNino
            {
                SceneManager.LoadScene(5);
            }
            else if (currentSceneIndex == 7 || currentSceneIndex == 4) // Suponiendo 1 = NivelNina
            {
                SceneManager.LoadScene(6);
            }
            else
            {
                Debug.LogWarning("Índice de escena no reconocido.");
            }
        }
    }
}
