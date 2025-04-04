using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selected : MonoBehaviour
{
    LayerMask mask;
    public float distancia = 3f;

    public Texture2D puntero;
    public GameObject TextDetect;
    //public GameObject Canvas;
    GameObject ultimoReconocido = null;
    
    // Start is called before the first frame update
    void Start()
    {
        mask = LayerMask.GetMask("Raycast Detect");
        TextDetect.SetActive(false);
        //Canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distancia, mask))
        {
            Deselect();
            SelectedObject(hit.transform);
            
            if((hit.collider.CompareTag("ObjetoInteractivo")) || (hit.collider.CompareTag("Door")))
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    if (hit.collider.CompareTag("Door"))
                    {

                        hit.collider.transform.GetComponent<SystemDoor>().ChangeDoorState();
                    }
                    //hit.collider.transform.GetComponent<ObjetoInterac>().ActivarObjeto();
                }
            }
        }
        else
        {
            Deselect();
        }
    }

    void SelectedObject(Transform transform)
    {
        transform.GetComponent<MeshRenderer>().material.color = Color.green;
        ultimoReconocido = transform.gameObject;
    }

    void Deselect()
    {
        if (ultimoReconocido)
        {
            ultimoReconocido.GetComponent<Renderer>().material.color = Color.white;
            ultimoReconocido = null;
        }
    }

    void OnGUI()
    {
        Rect rect = new Rect(Screen.width / 2 - puntero.width / 2, Screen.height / 2 - puntero.height / 2, puntero.width, puntero.height);
        GUI.DrawTexture(rect, puntero);

        if (ultimoReconocido)
        {
            TextDetect.SetActive(true);
            //Canvas.SetActive(true);
        }
        else
        {
            TextDetect.SetActive(false);
            //Canvas.SetActive(false);
        }
    }
}
