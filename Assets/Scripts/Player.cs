using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject coracao1;
    public GameObject coracao2;
    public GameObject coracao3;

    private bool semCoracao1;
    private bool semCoracao2;
    private bool semCoracao3;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "danger")
        {
            coracao3.SetActive(false);

        }


        if (col.gameObject.tag == "danger" && semCoracao3)
        {
            coracao2.SetActive(false);

        }


        if (col.gameObject.tag == "danger" && semCoracao2)
        {
            coracao1.SetActive(false);

        }

    }


    private void OnTriggerEnter2D(Collider2D col) // quando entrar no trigger
    {
        switch (col.tag)
        {

            case "coracao":
                //ganha vida

                if (semCoracao1) // ganha a 1 vida
                {
                    col.gameObject.SetActive(false);
                    coracao1.SetActive(true);
                    semCoracao1 = false;
                }


                else if (semCoracao2) // ganha a 2 vidas
                {
                    col.gameObject.SetActive(false);
                    coracao2.SetActive(true);
                    semCoracao2 = false;
                }

                else if (semCoracao3) // ganha a 3 vidas
                {
                    col.gameObject.SetActive(false);
                    coracao3.SetActive(true);
                    semCoracao3 = false;
                }
                break;
        }

    }







    private void OnCollisionExit2D(Collision2D col) // para de ser filho do objeto
    {


        #region perde vida

        if (col.gameObject.tag == "danger" && semCoracao3 == false)
        {

            Invoke("Morrendo3", 5);
        }

        else if (col.gameObject.tag == "danger" && semCoracao2 == false)
        {
            Invoke("Morrendo2", 5);
        }

        else if (col.gameObject.tag == "danger" && semCoracao1 == false)
        {
            // SceneManager.LoadScene("GameOver");
        }


    }

    void Morrendo3()
    {
        // transform.GetComponent<Animator>().SetBool("Invulneravel", true);
        semCoracao3 = true;
    }


    void Morrendo2()
    {
        // transform.GetComponent<Animator>().SetBool("Invulneravel", true);
        semCoracao2 = true;
    }



    void Morrendo1()
    {
        // transform.GetComponent<Animator>().SetBool("Invulneravel", true);
       // SceneManager.LoadScene("GameOver");
    }


    void Vivendo()
    {
        transform.GetComponent<Animator>().SetBool("Invulneravel", false);
    }
    #endregion
}
