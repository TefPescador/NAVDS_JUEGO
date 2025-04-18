using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SerotoninManager : MonoBehaviour
{
    [SerializeField] private Slider serotoninBar;

    void Start()
    {
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

    private void UpdateBar()
    {
        serotoninBar.value = Serotonin.Instance.currentSerotonin;
    }
}
