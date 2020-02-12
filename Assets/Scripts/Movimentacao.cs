using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimentacao : MonoBehaviour
{

    public float speed;
    public float posInicial;
    public float posFinal;
    private float initialY;
    private float initialZ;

    // Use this for initialization
    void Start()
    {
        initialY = transform.GetComponent<RectTransform>().position.y;
        initialZ = transform.GetComponent<RectTransform>().position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);

        if (transform.GetComponent<RectTransform>().position.x < posFinal)
        {
            transform.GetComponent<RectTransform>().position = new Vector3(posInicial, initialY, initialZ);
        }


        // print(transform.GetComponent<RectTransform>().position);
    }


}
