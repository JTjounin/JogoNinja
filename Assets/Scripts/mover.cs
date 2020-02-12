using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{

    public float speed;
    public float x;
    public float y;
    public float timeToChange;
    private float tempTime;
    public bool mudarEixo;


    // Use this for initialization
    void Start()
    {



        x = transform.position.x;
        y = transform.position.y;


    }

    // Update is called once per frame
    void Update()
    {





        // Time.deltaTime calcula quanto tempo passou entre 1 frame e outro
        eixoX();



    }

    void eixoX() // muda a direção da plataforma em relação ao eixo
    {
        if (mudarEixo) // eixo X
        {

            tempTime += Time.deltaTime;
            if (tempTime >= timeToChange)
            {
                tempTime = 0;
                speed *= -1;
            }

            x += speed * Time.deltaTime;

            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }
        else // eixo y
        {
            tempTime += Time.deltaTime;
            if (tempTime >= timeToChange)
            {
                tempTime = 0;
                speed *= -1;
            }

            y += speed * Time.deltaTime;

            transform.position = new Vector3(transform.position.x, y, transform.position.z);
        }
    }
}
