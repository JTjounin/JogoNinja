using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onWay : MonoBehaviour
{

    public Transform superficie; // posicao da superficies
    private Collider2D colisor;// colisor da plataforma
    private float y; // vai armazenar a posicai y do pe do persongem

    // Use this for initialization
    void Start()
    {
        colisor = GetComponent<Collider2D>(); // pega o colisor daquele objeto
    }

    // Update is called once per frame
    void Update()
    {
        y = GameObject.Find("GroundCheck").transform.position.y; // pega a posição do eixo y do GroundCheck
        if (y < superficie.position.y) // se GroundCheck tiver abaixo da superficie, desliga o collider ; 
        {
            colisor.enabled = false;
        }
        else
        {
            colisor.enabled = true;
        }
    }
}
