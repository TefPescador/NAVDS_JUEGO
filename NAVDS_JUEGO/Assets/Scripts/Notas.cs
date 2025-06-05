using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.UIElements;

public class Notas : MonoBehaviour
{
    public GameObject nota;

    public int valor = 1;
    

    //public AudioManager audioManager;

    // Start is called before the first frame update
    void Start()
    {
        nota.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            nota.SetActive(true);
            GameManager.Instance.SumarNotas(valor);
            StartCoroutine(DesaparecerNota());
        }
    }

    IEnumerator DesaparecerNota()
    {
        yield return new WaitForSeconds(3f);
        nota.SetActive(false);
        Destroy(this.gameObject);
    }
}
