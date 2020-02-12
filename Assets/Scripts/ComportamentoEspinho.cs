using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoEspinho : MonoBehaviour
{

    public float timeLife;
    // private float tempTime;


    // Use this for initialization
    void Start()
    {
        Invoke("DestroyShuriken", timeLife);
    }

    // Update is called once per frame
    void Update() // Tempo de vida do objeto
    {
        /* tempTime += Time.deltaTime;
         if(tempTime >= timeLife)
         {
             Destroy(this.gameObject);

         }*/
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "bloco" || col.gameObject.tag == "Explosion")
        {
            Destroy(this.gameObject);
        }


    }

    void DestroyShuriken()
    {
        Destroy(this.gameObject);
    }

}
