using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoCubo : MonoBehaviour
{
    public Rigidbody RbCubo;
    public float movimentoX;
    public float maxSpeed;
    public bool walk;
    private bool theScale;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /* 
         using System.Collections;
        using System.Collections.Generic;
        using UnityEngine;

        public class jogo : MonoBehaviour
        {

            public Transform gameobjeto;
            public GameObject jogador;
            private GameObject[] transformacao;
            public transformacao scriptTransform;
            public  int indice;
            private camera cam;


            public bool madeira;
            public Animator anime;
            public Rigidbody2D RbPlayer;
            public bool walk;
            public float movimentoX;  // Recebe o valor de entrada (esquerda e direita)
            public float movimentoY;
            private float maxSpeed;
            public bool FacingRight;
            public int JumpForce;
            private bool DoubleJump;
            public int JumpGhost;
            public static int contagemTransform;


            public bool wallCheck;


            public Transform GroundCheck;
            public bool Grounded;
            public LayerMask WhatIsGround;

            public GameObject ObjetoInteracao;

            public float turbo;
            public float velocidade;

            // Use this for initialization
            void Start()
            {
                cam = FindObjectOfType(typeof(camera)) as camera;
                // anime = GetComponent<Animator>(); // pegar o componente se ele estiver no mesmo objeto que o script
                // anime = GameObject.Find("Player").GetComponent<Animator>(); // busca o objeto e pega o componente.

                transformacao = scriptTransform.transformar; // pega o arrey de outro script e coloca dentro desse arrey

                jogador.SetActive(true); // ativa a visualizaçao do gameobjeto

                if (indice >= transformacao.Length) // se indice for maior que o numero de transformaçao diminui 1 indice
                {
                    indice = transformacao.Length - 1;
                }




                contagemTransform = 0;

            }

            // Update is called once per frame
            void Update()
            {

                // Botões de controle e interação do personagem
                #region movimentaçao
                movimentoX = Input.GetAxis("Horizontal"); // OBS: Horizontal: -1 = esquerda ; 1 = direita
                if (movimentoX != 0)
                {
                    transform.SetParent(null);
                }


                // apertando Z seta a velocidade do maxSpeed de acordo com o turbo
                if (Input.GetButton("Z"))
                {
                    maxSpeed = turbo;
                }
                else
                {
                    maxSpeed = velocidade;
                }


                // se o player não estiver encostando em nada, ele se movimenta
                if (!wallCheck)
                {
                    RbPlayer.velocity = new Vector2(movimentoX * maxSpeed, RbPlayer.velocity.y);
                }


                // verifica se o movimento X é diferente de zero, entao seta walk para verdadeiro
                if (movimentoX != 0)
                {
                    walk = true;
                }
                else
                {
                    walk = false;
                }


                // Troca a direção do personagem
                if (movimentoX > 0 && !FacingRight)
                {
                    Flip();
                }

                else if (movimentoX < 0 && FacingRight)
                {
                    Flip();
                }

                #endregion




                // se apertar o pulo e estiver no chão ou não estiver no segundo pulo e não estiver na parede
                #region Botões especiais
                if (Input.GetButtonDown("Jump") && (Grounded || !DoubleJump) && !wallCheck)
                {
                    // SoundController.playSound(soundFx.JUMP);
                    RbPlayer.velocity = new Vector2(0, 0); // o player não tem velocidade
                    RbPlayer.AddForce(new Vector2(0, JumpForce)); // add a força do Jumpforce(a força que voce definir) no eixo Y

                    if (!Grounded && !DoubleJump) // se não tiver no chão e nao estiver com 2 pulos, executa o segundo pulo !
                    {
                        DoubleJump = true;
                    }
                }

                if (Input.GetButton("Jump") && madeira)
                {
                    RbPlayer.AddForce(new Vector2(0, JumpGhost)); // add a força do Jumpforce(a força que voce definir) no eixo Y
                    RbPlayer.velocity = new Vector2(0, 0); // o player não tem velocidade
                }



                // pega o botão Ctrl, trás pra esse input uma função de outro script com o nome de "interação"
                if (Input.GetButtonDown("Fire1") && ObjetoInteracao != null)
                {
                    ObjetoInteracao.SendMessage("interacao", SendMessageOptions.DontRequireReceiver);
                }



                // ao apertar o Shift desativa o jogador e ativa as transformaçoes
                if (Input.GetButton("Fire3"))
                {

                    jogador.SetActive(false);
                    transformacao[indice].SetActive(true);
                    madeira = true;
                }
                else
                {
                    jogador.SetActive(true);
                    transformacao[indice].SetActive(false);
                    madeira = false;
                }
                #endregion


                // pega a posiçao do GC para fazer a verificação, determina o tamanho da área, define a layer para verifcar
                Grounded = Physics2D.OverlapCircle(GroundCheck.position, 0.2f, WhatIsGround);

                if (Grounded) // enquanto estiver no chao nao tem DoubleJump
                {

                }


                ///                             ///                             ///


                if (madeira == false && tag == "Player")
                {
                    // atribui as funções criadas dentro dos parametros do Animator
                    anime.SetBool("walk", walk);
                    anime.SetBool("Grounded", Grounded);
                    anime.SetFloat("speedY", RbPlayer.velocity.y);
                    //GetComponent<Animator>().SetBool("walk", walk);
                }

            }

            void Flip() // virar o player
            {
                FacingRight = !FacingRight; // FacingRight = false
                Vector3 theScale = transform.localScale;  // posição do eixo X,Y,Z
                theScale.x *= -1; // mutiplica ele mesmo por -1, inverte o eixo X
                transform.localScale = theScale; // atribui a ssnova posição ao X
            }


            // Colisões e interacão com Objetos
            #region Colisores
            private void OnTriggerEnter2D(Collider2D col) // quando entrar no trigger
            {
                switch (col.tag)
                {
                    case "moeda":
                        col.gameObject.SetActive(false);

                        break;



                    case "ajusteCamera":
                        cam.ajusteY = 0;
                        cam.comLerp = true;

                        break;



                    case "interacao":
                        ObjetoInteracao = col.gameObject;

                        break;

                }

            }


            private void OnTriggerStay2D(Collider2D col) // quando estiver no Trigger
            {
                if (col.tag != "gatilhos" && col.tag != "objeto" && col.tag != "ajusteCamera" && col.tag != "interacao")
                {
                    wallCheck = true;
                }
            }


            private void OnTriggerExit2D(Collider2D col) // quando sair de um Trigger
            {
                wallCheck = false;
                if (col.tag == "interacao")
                {
                    ObjetoInteracao = null;
                }
            }



            private void OnCollisionStay2D(Collision2D col)
            {

                if (col.gameObject.tag == "plataformaMovel" && movimentoX == 0) // se entrar na plataforma e estiver parado, objeto vira filho desse objeto
                {
                    transform.SetParent(col.gameObject.transform);
                }
            }


            private void OnCollisionExit2D(Collision2D col) // para de ser filho do objeto
            {
                if (col.gameObject.tag == "plataformaMovel")
                {
                    transform.SetParent(null);
                }
            }

            #endregion
        }
                 */

    }


}
