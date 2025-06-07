using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerN2 : MonoBehaviour
{
    public CompoundController[] compuestos;
    private float tiempoEntreDescomposiciones = 15f;

    private float tiempoActual = 0f;

    public int vidas = 3;
    public Image[] corazones; // Asigna aquí Corazon1, Corazon2, Corazon3 en el Inspector

    public SerotoninManager serotoninManager;

    void Start()
    {
        ActualizarCorazones();
        tiempoActual = tiempoEntreDescomposiciones;
    }

    void Update()
    {
        tiempoActual -= Time.deltaTime;

        if (tiempoActual <= 0f)
        {
            DescomponerAlAzar();
            tiempoActual = tiempoEntreDescomposiciones;
        }
    }

    void DescomponerAlAzar()
    {
        int intentos = 0;

        while (intentos < compuestos.Length)
        {
            int index = Random.Range(0, compuestos.Length);
            if (!compuestos[index].estaDescompuesto)
            {
                compuestos[index].Descomponer();
                break;
            }

            intentos++;
        }
    }

    public void PerderVida()
    {
        vidas--;
        ActualizarCorazones();

        if (vidas <= 0)
        {
            Debug.Log("¡Game Over!");
            // Aquí puedes cargar escena, mostrar menú, etc.
            SceneManager.LoadScene("SiguienteCasa");
            serotoninManager.OnLevelFailed();
        }
    }

    void ActualizarCorazones()
    {
        for (int i = 0; i < corazones.Length; i++)
        {
            corazones[i].gameObject.SetActive(i < vidas);
        }
    }

    public void GanarNivel()
    {
        serotoninManager.OnLevelWin();
    }
}
