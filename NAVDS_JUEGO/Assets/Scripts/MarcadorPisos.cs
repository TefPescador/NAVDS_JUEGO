using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarcadorPisos : MonoBehaviour
{
    public int pisoAsignado; // Piso de este marcador
    public GameObject[] enemigosPorPiso; // Enemigos en orden: 0 = Piso 1, 1 = Piso 2, etc.

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ActivarEnemigoTrasRetraso(pisoAsignado));
        }
    }

    IEnumerator ActivarEnemigoTrasRetraso(int piso)
    {
        yield return new WaitForSeconds(1.5f); // Esperar 1 segundo

        for (int i = 0; i < enemigosPorPiso.Length; i++)
        {
            enemigosPorPiso[i].SetActive(i == piso - 1); // Solo activar el del piso correcto
        }
    }
}
