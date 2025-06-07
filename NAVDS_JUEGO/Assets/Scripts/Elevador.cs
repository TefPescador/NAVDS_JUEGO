using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Elevador : MonoBehaviour
{
    public GameObject elevatorUI; // Panel con los botones
    public Transform pisoSuperior;
    public int pisoSuperiorNumero = 2;

    public Transform pisoInferior;
    public int pisoInferiorNumero = 1;

    private GameObject jugadorActual;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorActual = other.gameObject;
            elevatorUI.SetActive(true); // Mostrar botones
            PersonajeOficinista.isInElevator = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            elevatorUI.SetActive(false); // Ocultar botones
            PersonajeOficinista.isInElevator = false;
            jugadorActual = null;
        }
    }

    public void Subir()
    {
        if (jugadorActual != null)
        {
            jugadorActual.transform.position = pisoSuperior.position;

            // Actualiza pisoActual
            jugadorActual.GetComponent<PersonajeOficinista>().pisoActual = pisoSuperiorNumero;
        }
    }

    public void Bajar()
    {
        if (jugadorActual != null)
        {
            jugadorActual.transform.position = pisoInferior.position;

            // Actualiza pisoActual
            jugadorActual.GetComponent<PersonajeOficinista>().pisoActual = pisoInferiorNumero;
        }
    }

    void Start()
    {
        elevatorUI.SetActive(false);
    }
}
