using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NotaController : MonoBehaviour
{
    public GameObject[] notas;            // Notas físicas en el mundo
    public Sprite[] imagenesNotas;        // Sprites para mostrar en pantalla
    public GameObject panelNota;          // Panel del UI (el que contiene la imagen)
    public Image imagenNota;              // Componente Image del panel UI

    private int notaActual = 0;
    private bool mostrandoNota = false;

    public TextMeshProUGUI textoContador;

    public int Recogidas => notaActual;
    public int TotalNotas => notas.Length;

    void Start()
    {
        // Solo activar la primera nota
        for (int i = 0; i < notas.Length; i++)
        {
            notas[i].SetActive(i == 0);
        }

        panelNota.SetActive(false);
        ActualizarContador();
    }

    public void RecogerNota()
    {
        if (notaActual < notas.Length)
        {
            // Oculta nota del mundo
            notas[notaActual].SetActive(false);

            // Mostrar imagen de la nota
            imagenNota.sprite = imagenesNotas[notaActual];
            panelNota.SetActive(true);
            mostrandoNota = true;

            // Pausar el juego si quieres (opcional)
            // Time.timeScale = 0f;
        }
    }

    void Update()
    {
        if (mostrandoNota && Input.GetKeyDown(KeyCode.E)) // o cualquier otra tecla
        {
            panelNota.SetActive(false);
            mostrandoNota = false;

            // Time.timeScale = 1f; // si lo pausaste antes

            notaActual++;
            ActualizarContador();

            if (notaActual < notas.Length)
            {
                notas[notaActual].SetActive(true);
            }
            else
            {
                Debug.Log("¡Todas las notas recogidas!");
                // Aquí puedes activar algo final (puerta, cinemática, etc.)
            }
        }
    }

    void ActualizarContador()
    {
        textoContador.text = notaActual + "/" + notas.Length;
    }
}
