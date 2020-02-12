using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public jogo scriptJogo;
    public GameObject Demo;
    public bool Desativado;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Submit"))
        {
            Demo.SetActive(false);
            Desativado = true;
            SoundController.playSound(soundFX.START);
            scriptJogo.enabled = true;
        }
    }
}