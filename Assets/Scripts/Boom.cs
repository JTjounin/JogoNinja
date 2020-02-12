using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Invoke("Explodir", 0.3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Explodir()
    {
        Destroy(gameObject);
    }

}
