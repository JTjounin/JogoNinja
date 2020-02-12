using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explodir : MonoBehaviour
{

    public Transform SpawnPoint;
    // public GameObject prefab;
    public GameObject tempPrefab;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerEnter2D(Collider2D col)
    {

        switch (col.gameObject.name)
        {
            case "GroundCheck":

                Invoke("Spawn", 0);
                break;
        }

        switch (col.gameObject.tag)
        {
            case "fire":

                Invoke("Spawn", 0);
                break;
        }


    }


    void Spawn()
    {
        Destroy(this.gameObject);
        tempPrefab = Instantiate(tempPrefab) as GameObject;
        tempPrefab.transform.position = SpawnPoint.position;


        //  Invoke("DestroyBoom", 2);
    }

    /* void DestroyBoom()
     {
         Destroy(this.tempPrefab);
     }*/


}
