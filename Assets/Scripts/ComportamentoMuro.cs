using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoMuro : MonoBehaviour
{
    public GameObject prefab;
    private bool ativo;
    public Transform SpawnPoit;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Player")
        {

            if (!ativo)
            {
                GameObject tempPrefab = Instantiate(prefab) as GameObject;
                tempPrefab.transform.position = SpawnPoit.position;
                ativo = true;
            }


        }
    }
}
