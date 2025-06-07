using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotaInterac : MonoBehaviour
{
    public NotaController controlador;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            controlador.RecogerNota();
        }
    }
}
