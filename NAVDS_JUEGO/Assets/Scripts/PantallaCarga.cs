using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.UIElements;
using UnityEngine.Video;

public class PantallaCarga : MonoBehaviour
{
    public GameObject Introvideo;
    public VideoPlayer videoplayer;
    public GameObject Nivel;
    // Start is called before the first frame update
    void Start()
    {
        Nivel.SetActive(false);
        Introvideo.SetActive(true);
        videoplayer.loopPointReached += VideoTerminado;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void VideoTerminado(VideoPlayer vp)
    {
        Introvideo.SetActive(false);
        Nivel.SetActive(true);
    }

    public IEnumerator DesaparecerPantalla()
    {
        yield return new WaitForSeconds(8f);
    }
}
