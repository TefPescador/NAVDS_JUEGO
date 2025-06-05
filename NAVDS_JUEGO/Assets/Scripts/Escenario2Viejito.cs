using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Escenario2Viejito : MonoBehaviour
{
    public GameObject Agradecimiento;

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Agradecimiento.SetActive(true);
            GameManager.Instance.GanarNivel();
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
