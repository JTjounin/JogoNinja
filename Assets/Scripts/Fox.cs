using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    public float Speed;
    public bool Facing;
    private Rigidbody2D RbFox;
    public LayerMask WhatIsGround;
    public bool GroundFox;
    public Transform VirarCheck;

    // Use this for initialization
    void Start()
    {
        RbFox = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GroundFox = Physics2D.OverlapCircle(VirarCheck.position, 0.2f, WhatIsGround);

        RbFox.velocity = new Vector2(Speed, RbFox.velocity.y);

        if (GroundFox)
        {
            Speed *= -1;
            Flip();
        }
    }


    void Flip() // virar o player
    {
        Facing = !Facing; // FacingRight = false
        Vector3 theScale = transform.localScale;  // posição do eixo X,Y,Z
        theScale.x *= -1; // mutiplica ele mesmo por -1, inverte o eixo X
        transform.localScale = theScale; // atribui a ssnova posição ao X
    }

}
