using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoElevadorTeleport : MonoBehaviour
{
    public Transform jugador;

    public Transform piso1Position;
    public Transform piso2Position;
    public Transform piso3Position;
    public Transform piso4Position;

    public float velocidad = 2f;
    public int pisoActual = 4;

    private Animator animator;

    private GameManagerN2 gameManager;

    [System.Serializable]
    public class EnemigoInfo
    {
        public GameObject enemigo;
        public Transform puntoInicio; // marcador donde debe empezar
    }

    public EnemigoInfo[] enemigos;


    void Start()
    {
        animator = GetComponent<Animator>();
        // Coloca cada enemigo en su punto inicial y los desactiva
        foreach (var e in enemigos)
        {
            e.enemigo.transform.position = e.puntoInicio.position;
            e.enemigo.SetActive(false); // se activan solo cuando el jugador llega
        }

        gameManager = FindObjectOfType<GameManagerN2>();
    }

    void Update()
    {
        // Persigue al jugador horizontalmente
        Vector2 direccion = new Vector2(jugador.position.x - transform.position.x, 0);

        animator.SetBool("isMoving", true);

        // Voltear sprite
        if (direccion.x > 0) transform.localScale = new Vector3(57, 57, 57);
        else if (direccion.x < 0) transform.localScale = new Vector3(-57, 57, 57);

        transform.Translate(direccion.normalized * velocidad * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.PerderVida();
        }
    }

}
