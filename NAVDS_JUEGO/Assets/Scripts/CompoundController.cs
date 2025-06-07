using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CompoundController : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color colorCompuesto = Color.green;
    public Color colorDescompuesto = Color.red;

    private float tiempoParaComponer = 15f;
    private float timer = 0f;

    public bool estaDescompuesto = false;
    private GameManagerN2 gameManager;

    public TextMeshProUGUI cronometroTexto;


    public AudioSource sonidoDescompuesto;


    void Start()
    {
        spriteRenderer.color = colorCompuesto;
        gameManager = FindObjectOfType<GameManagerN2>();
        if (cronometroTexto != null)
        {
            cronometroTexto.gameObject.SetActive(false); // ocultar al inicio
        }
    }

    void Update()
    {
        if (estaDescompuesto)
        {
            timer += Time.deltaTime;
            float tiempoRestante = Mathf.Max(0f, tiempoParaComponer - timer);

            if (cronometroTexto != null)
            {
                cronometroTexto.text = tiempoRestante.ToString("F1"); // 1 decimal
            }

            if (timer >= tiempoParaComponer)
            {
                estaDescompuesto = false;
                timer = 0f;
                if (cronometroTexto != null)
                {
                    cronometroTexto.gameObject.SetActive(false);
                }

                if (sonidoDescompuesto != null && sonidoDescompuesto.isPlaying)
                {
                    sonidoDescompuesto.Stop();
                }
                spriteRenderer.color = colorCompuesto;
                gameManager.PerderVida();
            }
        }
    }

    public void Descomponer()
    {
        if (!estaDescompuesto)
        {
            estaDescompuesto = true;
            timer = 0f;
            if (cronometroTexto != null)
            {
                cronometroTexto.gameObject.SetActive(true);
                cronometroTexto.text = tiempoParaComponer.ToString("F1");
            }

            if (sonidoDescompuesto != null)
            {
                sonidoDescompuesto.Play();
            }

            spriteRenderer.color = colorDescompuesto;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && estaDescompuesto)
        {
            estaDescompuesto = false;
            timer = 0f;
            if (cronometroTexto != null)
            {
                cronometroTexto.gameObject.SetActive(false);
            }
            if (sonidoDescompuesto != null && sonidoDescompuesto.isPlaying)
            {
                sonidoDescompuesto.Stop();
            }
            spriteRenderer.color = colorCompuesto;
        }
    }
}
