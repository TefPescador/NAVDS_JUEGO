using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaVolumen : MonoBehaviour
{
    //Crear variables
    public Slider slider;
    public float sliderValue;

    // En la variable guardar el valor del slider
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 1.0f);
        AudioListener.volume = sliderValue;
    }

    public void ChangeSlider(float valor)
    {
        slider.value = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        AudioListener.volume = slider.value;
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
