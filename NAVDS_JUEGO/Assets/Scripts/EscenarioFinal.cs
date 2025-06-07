using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscenarioFinal : MonoBehaviour
{
    public GameObject Agradecimiento;

    private GameManagerN2 gameManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Agradecimiento.SetActive(true);
            gameManager.GanarNivel();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Agradecimiento.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
