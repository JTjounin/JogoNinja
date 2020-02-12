using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rato : MonoBehaviour
{
    public float Speed;
    public bool Facing;
    private Rigidbody2D RbFox;
    public LayerMask WhatIsGround;
    public bool GroundFox;
    public Transform VirarCheck;


    public Transform Player;
    public bool Grounded;
    public Transform GroundCheck;

    public Transform pontoCentro;
    public Transform A;
    public Transform B;


    // Use this for initialization
    void Start()
    {
        RbFox = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GroundFox = Physics2D.OverlapCircle(VirarCheck.position, 0.2f, WhatIsGround);

        Grounded = Physics2D.OverlapCircle(GroundCheck.position, 0.2f, WhatIsGround); // pega a posiçao do GC para fazer a verificação, determina o tamanho da área, define a layer para verifcar



        RbFox.velocity = new Vector2(Speed, RbFox.velocity.y);

        if (GroundFox)
        {
            Speed *= -1;
            Flip();
        }



        if ((Player.position.x > A.position.x && Player.position.x < pontoCentro.position.x) && (!Facing && Grounded))
        {
            Speed = -4;
        }

        if (Speed == -4 && !Grounded)
        {
            Speed = -2;
        }


        if ((Player.position.x < B.position.x && Player.position.x > pontoCentro.position.x) && (Facing && Grounded))
        {
            Speed = 4;
        }

        if (Speed == 4 && !Grounded)
        {
            Speed = 2;
        }


        // pegar a posição do inimigo ao inves do personagem

    }


    void Flip() // virar o player
    {
        Facing = !Facing; // FacingRight = false
        Vector3 theScale = transform.localScale;  // posição do eixo X,Y,Z
        theScale.x *= -1; // mutiplica ele mesmo por -1, inverte o eixo X
        transform.localScale = theScale; // atribui a ssnova posição ao X
    }

}
