using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pared : MonoBehaviour
{
    public GameObject FaltanNotas;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FaltanNotas.SetActive(true);
            StartCoroutine(DesaparecerNota());
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FaltanNotas.SetActive(false);
            StartCoroutine(DesaparecerNota());
        }
    }

    public void NotasCompletas()
    {
        this.gameObject.SetActive(false);
        Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        FaltanNotas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DesaparecerNota()
    {
        yield return new WaitForSeconds(1.5f);
        FaltanNotas.SetActive(false);
    }
}
