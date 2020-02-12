using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armadilha : MonoBehaviour
{
    public GameObject[] prefab; // o objeto que queremos instanciar na cena, em formato de arrey !
    public bool ativo;
    public Transform SpawnPoit;

    public int indice; // qual prefab será instanciado
    public bool atirar; // define como será instanciado o objeto
    public bool tempo;
    public float timerToSpawn;
    private float tempTime;

    public int perAtivar;



    // Use this for initialization
    void Start()
    {
        if (indice >= prefab.Length)
        {
            indice = prefab.Length - 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (tempo == true)
        {
            tempTime += Time.deltaTime;
            if (tempTime >= timerToSpawn)
            {
                int temp = Random.Range(1, 100);
                if (temp <= perAtivar)
                {
                    Spawn();
                }

                tempTime = 0;
            }


            

        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Player" && tempo == false)
        {

            if (!ativo)
            {
                //itens aleatorios     // indice = Random.Range(0, prefab.Length - 1);

                Spawn();

                ativo = true;
            }

        }// if(gameObject.name == "muro"){}

    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
            ativo = false;
    }

    void Spawn()
    {
        GameObject tempPrefab = Instantiate(prefab[indice]) as GameObject;
        tempPrefab.transform.position = SpawnPoit.position;

        if (atirar)
        {
            tempPrefab.GetComponent<Rigidbody2D>().gravityScale = 0;
            tempPrefab.GetComponent<Rigidbody2D>().AddForce(new Vector2(-300, 0));
        }
        else
        {
            tempPrefab.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }

}