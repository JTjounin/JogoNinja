using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public Transform Player;
    private float x;
    private float y;
    public float transition;
    public bool comLerp;
    public bool segueX;
    public bool segueY;

    public float ajusteX;
    public float ajusteY;

    private Transform LL;
    private Transform LR;
    // Use this for initialization
    void Start()
    {
        //LL = GameObject.Find("LL").transform;
        //LR = GameObject.Find("LR").transform;
    }

    // Update is called once per frame
    void Update()
    {
        x = Player.position.x; // pega a posição X do player


        if (segueX) // se segueY for verdadeiro, pega o eixo x do player
        {
            x = Player.position.x + ajusteX;
        }

        else // se não mantem o eixo x
        {
            x = transform.position.x;
        }


        if (segueY) // se segueY for verdadeiro, pega o eixo y do player
        {
            y = Player.position.y + ajusteY;
        }
        else // se não mantem o eixo y
        {
            y = transform.position.y;
        }

        // if( x > LL.position.x && Player.position.x < LR.position.x)
        // {



        if (comLerp)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(x, y, transform.position.z), transition);
        }
        //transform.position = new Vector3(x, transform.position.y, transform.position.z);
        else
        {
            transform.position = new Vector3(x, y, transform.position.z);
        }

        //  }
    }
}
