using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour
{
    private jogo jogo;
    public GameObject[] prefab; // o objeto que queremos instanciar na cena, em formato de arrey !
    public bool ativo;
    public Transform SpawnPoint;

    public int indice; // qual prefab será instanciado


    // Use this for initialization
    void Start()
    {
        if (indice >= prefab.Length)
        {
            indice = prefab.Length - 1;
        }

        jogo = FindObjectOfType(typeof(jogo)) as jogo; // instanciando nesse script como jogo

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("X"))
        {
            SoundController.playSound(soundFX.FIRE);
            Spawn();
        }
    }

    void Spawn()
    {
        GameObject tempPrefab = Instantiate(prefab[indice]) as GameObject;
        tempPrefab.transform.position = SpawnPoint.position;

        if (jogo.FacingRight == false)
        {
            tempPrefab.GetComponent<Rigidbody2D>().gravityScale = 0;
            tempPrefab.GetComponent<Rigidbody2D>().AddForce(new Vector2(-300, 0));
        }
        else if (jogo.FacingRight == true)
        {
            tempPrefab.GetComponent<Rigidbody2D>().gravityScale = 0;
            tempPrefab.GetComponent<Rigidbody2D>().AddForce(new Vector2(300, 0));
        }

    }


}
