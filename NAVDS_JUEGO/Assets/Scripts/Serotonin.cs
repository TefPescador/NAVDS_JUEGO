using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Serotonin : MonoBehaviour
{
    public static Serotonin Instance;
    public float currentSerotonin = 50f; // Empieza al 50%
    //[SerializeField] private VideoPlayer videoPlayer;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Sobrevive entre escenas
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //videoPlayer.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
