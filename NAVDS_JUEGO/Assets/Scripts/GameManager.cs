using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public HUD hud;

    public int NotasTotales { get { return notasTotales; } }
    public int notasTotales;
    public int notasFinales = 5;

    private int suenos = 3;
    public Pared notasCom;

    public SerotoninManager serotoninManager;

    void Awake()
    {
       if(Instance == null)
       {
            Instance = this;
       }
       else
       {
            Debug.Log("Mas de un Game Manager en escena");
       }
    }

    public void SumarNotas(int notasASumar)
    {
        notasTotales += notasASumar;
        hud.ActualizarNotas(notasTotales);
        if(notasTotales == notasFinales)
        {
            notasCom.NotasCompletas();
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

    public void PerderSueno() 
    {
        suenos -= 1;

        if (suenos == 0)
        {
            SceneManager.LoadScene(1);
            serotoninManager.OnLevelFailed();
        }

        hud.DesactivarSueno(suenos);
    }

    public void GanarNivel()
    {
        serotoninManager.OnLevelWin();
    }
}
