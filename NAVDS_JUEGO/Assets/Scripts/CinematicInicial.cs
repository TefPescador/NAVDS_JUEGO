using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CinematicInicial : MonoBehaviour
{
    public GameObject Introvideo;
    public VideoPlayer videoplayer;

    public GameObject Barra;
    public GameObject Mision;
    //public GameObject Escenario;

    // Start is called before the first frame update
    void Start()
    {
        //Escenario.SetActive(false);
        Introvideo.SetActive(true);
        Barra.SetActive(false);
        Mision.SetActive(false);
        videoplayer.loopPointReached += VideoTerminado;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void VideoTerminado(VideoPlayer vp)
    {
        Barra.SetActive(true);
        Mision.SetActive(true);
        Introvideo.SetActive(false);
        //Escenario.SetActive(true);
    }

    public IEnumerator DesaparecerPantalla()
    {
        yield return new WaitForSeconds(8f);
    }
}
