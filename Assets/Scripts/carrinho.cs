using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrinho : MonoBehaviour
{


    private jogo jogo; // chamando outro script
    public float forca;

    // Use this for initialization
    void Start()
    {
        jogo = FindObjectOfType(typeof(jogo)) as jogo; // instanciando nesse script como jogo
    }

    // Update is called once per frame
    void Update()
    {

    }

    void interacao()
    {
        if (jogo.FacingRight == true && forca < 0) // se o player estiver olhando para direita e a força vinher da esquerda, altera a direção da força para a direita
        {
            forca *= -1;
        }
        else if (jogo.FacingRight == false && forca > 0) // se o player estiver olhando para esquerda e a força vinher da direita, altera a direção da força para a esquerda
        {
            forca *= -1;
        }
        GetComponent<Rigidbody2D>().AddForce(new Vector2(forca, 0)); // add força ao objeto, e usando o eixo X como a variavel float
    }




    private void OnCollisionStay2D(Collision2D col)
    {

        if (Input.GetButton("Fire1") && col.gameObject.tag == "Player")
        {
            transform.SetParent(col.gameObject.transform);
        }

        else
        {
            transform.SetParent(null);
        }
    }
}
