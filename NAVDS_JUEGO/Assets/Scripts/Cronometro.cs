using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public float tiempoInicial = 130f;
    private float tiempoRestante;
    private bool enMarcha = true;

    public TextMeshProUGUI textoTimer;

    void Start()
    {
        tiempoRestante = tiempoInicial;
    }

    void Update()
    {
        if (enMarcha)
        {
            tiempoRestante -= Time.deltaTime;
            textoTimer.text = Mathf.FloorToInt(tiempoRestante / 60).ToString("00") + ":" + Mathf.FloorToInt(tiempoRestante % 60).ToString("00");

            if (tiempoRestante <= 0f)
            {
                tiempoRestante = 0f;
                enMarcha = false;

                // Aquí avisamos al GameManager
                GameManager.Instance.PerderSueno();
                GameManager.Instance.PerderSueno();
                GameManager.Instance.PerderSueno();// pierdes 3 sueños
            }
        }
    }

    public void DetenerCronometro()
    {
        enMarcha = false;
    }

    
}
