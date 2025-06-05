using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CineEsc : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private int nextSceneName;
    public GameObject Barra;
    public GameObject Mision;
    
    [SerializeField] private Selected camaraScript;

    private bool videoStarted = false;

    void Start()
    {
        videoPlayer.time = 0;
        videoPlayer.frame = 0;
        videoPlayer.Stop();

        videoPlayer.gameObject.SetActive(false);
        videoPlayer.loopPointReached += OnVideoFinished;
        videoPlayer.targetTexture.Release();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!videoStarted && other.CompareTag("Player"))
        {
            videoStarted = true;
            Barra.SetActive(false);
            Mision.SetActive(false);
            camaraScript.mostrarPuntero = false;
            videoPlayer.gameObject.SetActive(true);  // por si estaba desactivado
            videoPlayer.Play();
        }
    }

    private void OnVideoFinished(VideoPlayer vp)
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
