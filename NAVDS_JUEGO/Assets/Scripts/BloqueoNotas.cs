using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueoNotas : MonoBehaviour
{
    public NotaController notaController;
    public GameObject cartelFaltanNotas;
    private float cartelTimer = 0f;
    private float tiempoMostrar = 2f;

    private void Update()
    {
        // Ocultar cartel después de un tiempo
        if (cartelFaltanNotas.activeSelf)
        {
            cartelTimer += Time.deltaTime;
            if (cartelTimer >= tiempoMostrar)
            {
                cartelFaltanNotas.SetActive(false);
                cartelTimer = 0f;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            if (notaController.Recogidas < notaController.TotalNotas)
            {
                cartelFaltanNotas.SetActive(true);
            }
            else
            {
                // Ya tiene todas las notas, destruye la pared
                Destroy(gameObject);
            }
        }
    }
}
