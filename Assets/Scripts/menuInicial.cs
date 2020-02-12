using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menuInicial : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Submit"))
        {
            Invoke("scene", 1f);
        }
    }

    public void startGame()
    {

    }


    void scene()
    {
        SceneManager.LoadScene("floresta");
    }


}
