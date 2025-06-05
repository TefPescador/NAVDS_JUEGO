using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Elevador : MonoBehaviour
{
    public GameObject elevatorUI; //panel con los botones
    public Transform pisoSuperior;
    public Transform pisoInferior;

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
            jugadorActual.transform.position = pisoSuperior.position;
    }

    public void Bajar()
    {
        if (jugadorActual != null)
            jugadorActual.transform.position = pisoInferior.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        elevatorUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
