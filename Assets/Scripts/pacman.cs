using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacman : MonoBehaviour
{
    public float Speed;
    public bool Facing;
    private Rigidbody2D RbPacman;
    public Transform Player;

    public LayerMask WhatIsGround;
    public bool GroundPac;
    public bool Grounded;
    public Transform VirarCheck;
    public Transform GroundCheck;

    public Transform pontoCentro;
    public Transform A;
    public Transform B;

    // Use this for initialization
    void Start()
    {
        RbPacman = GetComponent<Rigidbody2D>();
        //  pontoCentro = GameObject.Find("A").transform;
        //  A = GameObject.Find("A").transform;
        //  B = GameObject.Find("B").transform;
    }

    // Update is called once per frame
    void Update()
    {

        GroundPac = Physics2D.OverlapCircle(VirarCheck.position, 0.2f, WhatIsGround);
        Grounded = Physics2D.OverlapCircle(GroundCheck.position, 0.2f, WhatIsGround); // pega a posiçao do GC para fazer a verificação, determina o tamanho da área, define a layer para verifcar


        RbPacman.velocity = new Vector2(Speed, RbPacman.velocity.y);


        if (GroundPac)
        {
            Speed *= -1;
            Flip();
        }


        if ((Player.position.x > A.position.x && Player.position.x < pontoCentro.position.x) && (!Facing && Grounded))
        {
            Speed = -6;
        }

        else if ((Player.position.x < B.position.x && Player.position.x > pontoCentro.position.x) && (Facing && Grounded))
        {
            Speed = 6;
        }

        if (Speed == -6 && !Grounded)
        {
            Speed = -2;
        }
        else if (Speed == 6 && !Grounded)
        {
            Speed = 2;
        }







    }


    /*private void OnCollisionEnter2D(Collision2D col)
    {
        switch (col.gameObject.tag)
        {
            case "virar":
                

                break;
        }
    }
     */


    void Flip() // virar o player
    {
        Facing = !Facing; // FacingRight = false
        Vector3 theScale = transform.localScale;  // posição do eixo X,Y,Z
        theScale.x *= -1; // mutiplica ele mesmo por -1, inverte o eixo X
        transform.localScale = theScale; // atribui a ssnova posição ao X
    }
}

