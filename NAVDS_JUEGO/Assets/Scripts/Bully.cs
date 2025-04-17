using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bully : MonoBehaviour
{

    public Transform puntoA;
    public Transform puntoB;
    public float velocidad = 500f;

    private Vector3 objetivoActual;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.PerderSueno();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        objetivoActual = puntoB.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, objetivoActual, velocidad * Time.deltaTime);

        if (Vector3.Distance(transform.position, objetivoActual) < 0.1f)
        {
            if (objetivoActual == puntoB.position)
            {
                objetivoActual = puntoA.position;
            }
            else
            {
                objetivoActual = puntoB.position;
            }
        }
    }
}
