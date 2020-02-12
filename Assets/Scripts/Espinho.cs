using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espinho : MonoBehaviour
{
    private Rigidbody2D espinhoRb;

    public int atrito;
    public Vector3 posicao;
    public GameObject espinhoPrefab;

    public bool ativo;
    // Use this for initialization
    void Start()
    {
        espinhoRb = GetComponent<Rigidbody2D>();

        espinhoRb.drag = atrito;

        posicao = transform.position;

        espinhoPrefab.SetActive(true);

        Invoke("Repitir", 2);
    }


    void Update() // Tempo de vida do objeto
    {

    }

    void Repitir()
    {
        Instantiate(espinhoPrefab, posicao, transform.localRotation);
        Destroy(this.gameObject);
    }


}