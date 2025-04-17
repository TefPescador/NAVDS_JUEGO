using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacio : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.PerderSueno();
            GameManager.Instance.PerderSueno();
            GameManager.Instance.PerderSueno();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
