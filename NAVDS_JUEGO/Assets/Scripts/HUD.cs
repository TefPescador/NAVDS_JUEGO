using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Video;

public class HUD : MonoBehaviour
{
    
    public TextMeshProUGUI notas;
    public GameObject[] suenos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //notas.text = GameManager.Instance.NotasTotales.ToString();
        //notas.text += "/5";
    }

    public void ActualizarNotas(int notasTotales)
    {
        notas.text = GameManager.Instance.NotasTotales.ToString();
        notas.text += "/5";
        Debug.Log(notas.text);
    }

    public void DesactivarSueno(int indice)
    {
        suenos[indice].SetActive(false);
    }
}
