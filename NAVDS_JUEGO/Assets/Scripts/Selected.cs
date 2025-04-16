using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selected : MonoBehaviour
{
    LayerMask mask;
    public float distancia = 3f;

    public Texture2D puntero;
    public GameObject TextDetect;

    public GameObject Reloj;
    public GameObject Foto;
    public GameObject Baston;
    public GameObject Radio;
    public GameObject Libro;
    public GameObject Cepillo;
    public GameObject Medicamentos;
    public GameObject Zapatos;

    public GameObject CepilloDientes;
    public GameObject Perfume;
    public GameObject Toalla;

    public GameObject Taza;
    public GameObject Sarten;
    public GameObject Receta;
    public GameObject Frutas;

    public GameObject Revistas;
    public GameObject Carta;
    public GameObject Telefono;
    public GameObject Control;
    public GameObject Sillon;

    //public GameObject Canvas;
    GameObject ultimoReconocido = null;
    
    // Start is called before the first frame update
    void Start()
    {
        mask = LayerMask.GetMask("Raycast Detect");
        TextDetect.SetActive(false);
        Reloj.SetActive(false);
        Foto.SetActive(false);
        Baston.SetActive(false);
        Radio.SetActive(false);
        Libro.SetActive(false);
        Cepillo.SetActive(false);
        Medicamentos.SetActive(false);
        Zapatos.SetActive(false);

        CepilloDientes.SetActive(false);
        Perfume.SetActive(false);
        Toalla.SetActive(false);

        Taza.SetActive(false);
        Sarten.SetActive(false);
        Receta.SetActive(false);
        Frutas.SetActive(false);

        Revistas.SetActive(false);
        Carta.SetActive(false);
        Telefono.SetActive(false);
        Control.SetActive(false);
        Sillon.SetActive(false);
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
            
            if((hit.collider.CompareTag("ObjetoInteractivo")) || (hit.collider.CompareTag("Door")) || (hit.collider.CompareTag("Reloj")) || (hit.collider.CompareTag("Baston")) || (hit.collider.CompareTag("Medicamento")) || (hit.collider.CompareTag("Foto")) || (hit.collider.CompareTag("Radio")) || (hit.collider.CompareTag("Cepillo")) || (hit.collider.CompareTag("Libro")) || (hit.collider.CompareTag("Zapatos")) || (hit.collider.CompareTag("CepilloDientes")) || (hit.collider.CompareTag("Perfume")) || (hit.collider.CompareTag("Toalla")) || (hit.collider.CompareTag("Taza")) || (hit.collider.CompareTag("Sarten")) || (hit.collider.CompareTag("Receta")) || (hit.collider.CompareTag("Frutas")) || (hit.collider.CompareTag("Revistas")) || (hit.collider.CompareTag("Carta")) || (hit.collider.CompareTag("Telefono")) || (hit.collider.CompareTag("Control")) || (hit.collider.CompareTag("Sillon")))
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    if (hit.collider.CompareTag("Door"))
                    {

                        hit.collider.transform.GetComponent<SystemDoor>().ChangeDoorState();
                    }

                    if (hit.collider.CompareTag("Reloj"))
                    {
                        Reloj.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }
                    if (hit.collider.CompareTag("Baston"))
                    {
                        Baston.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }
                    if (hit.collider.CompareTag("Medicamento"))
                    {
                        Medicamentos.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }
                    if (hit.collider.CompareTag("Radio"))
                    {
                        Radio.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }
                    if (hit.collider.CompareTag("Foto"))
                    {
                        Foto.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }
                    if (hit.collider.CompareTag("Libro"))
                    {
                        Libro.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }
                    if (hit.collider.CompareTag("Zapatos"))
                    {
                        Zapatos.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }
                    if (hit.collider.CompareTag("Cepillo"))
                    {
                        Cepillo.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }

                    if (hit.collider.CompareTag("CepilloDientes"))
                    {
                        CepilloDientes.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }
                    if (hit.collider.CompareTag("Toalla"))
                    {
                        Toalla.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }
                    if (hit.collider.CompareTag("Perfume"))
                    {
                        Perfume.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }

                    if (hit.collider.CompareTag("Taza"))
                    {
                        Taza.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }
                    if (hit.collider.CompareTag("Receta"))
                    {
                        Receta.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }
                    if (hit.collider.CompareTag("Sarten"))
                    {
                        Sarten.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }
                    if (hit.collider.CompareTag("Frutas"))
                    {
                        Frutas.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }

                    if (hit.collider.CompareTag("Revistas"))
                    {
                        Revistas.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }
                    if (hit.collider.CompareTag("Carta"))
                    {
                        Carta.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }
                    if (hit.collider.CompareTag("Telefono"))
                    {
                        Telefono.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }
                    if (hit.collider.CompareTag("Control"))
                    {
                        Control.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
                    }
                    if (hit.collider.CompareTag("Sillon"))
                    {
                        Sillon.SetActive(true);
                        StartCoroutine("DesaparecerTexto");
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

    public IEnumerator DesaparecerTexto()
    {
        yield return new WaitForSeconds(2f);
        Reloj.SetActive(false);
        Foto.SetActive(false);
        Baston.SetActive(false);
        Radio.SetActive(false);
        Libro.SetActive(false);
        Cepillo.SetActive(false);
        Medicamentos.SetActive(false);
        Zapatos.SetActive(false);

        CepilloDientes.SetActive(false);
        Perfume.SetActive(false);
        Toalla.SetActive(false);

        Taza.SetActive(false);
        Sarten.SetActive(false);
        Receta.SetActive(false);
        Frutas.SetActive(false);

        Revistas.SetActive(false);
        Carta.SetActive(false);
        Telefono.SetActive(false);
        Control.SetActive(false);
        Sillon.SetActive(false);
    }
}
