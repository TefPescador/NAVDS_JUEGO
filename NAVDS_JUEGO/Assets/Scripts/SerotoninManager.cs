using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SerotoninManager : MonoBehaviour
{
    [SerializeField] private Slider serotoninBar;

    public int gameOverScene;

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
    }

    public void OnLevelWin()
    {
        Serotonin.Instance.currentSerotonin += 25f;
        Serotonin.Instance.currentSerotonin = Mathf.Clamp(Serotonin.Instance.currentSerotonin, 0, 100f);
        UpdateBar();
    }

    private void UpdateBar()
    {
        serotoninBar.value = Serotonin.Instance.currentSerotonin;
        if (Serotonin.Instance.currentSerotonin == 0)
        {
            SceneManager.LoadScene(gameOverScene);
        }
    }
}
