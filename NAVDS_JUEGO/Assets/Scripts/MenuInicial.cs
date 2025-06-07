using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
   //Funcion para el botonInicio y empiece el juego
   public void Jugar()
    {
        SceneManager.LoadScene(1);
        Serotonin.Instance.currentSerotonin = 50f;
        
    }

    //Funcion para el botonSalir y salir del juego
    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}
