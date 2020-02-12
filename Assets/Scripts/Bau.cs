using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bau : MonoBehaviour
{

    public GameObject bauAberto;
    public GameObject bauFechado;
    public GameObject armadilhaBau;
    private bool aberto;


    // Use this for initialization
    void Start()
    {
        bauAberto.SetActive(false);// desativa o GameObject
        bauFechado.SetActive(true);// ativa o Gameobject


    }

    // Update is called once per frame
    void Update()
    {

    }

    void interacao() // ao apertar o ctrl, e o aberto estiver falço/verdadeiro , faz a animação do bau
    {
        if (!aberto)
        {
            bauAberto.SetActive(true);
            bauFechado.SetActive(false);
            SoundController.playSound(soundFX.OPEN);
            aberto = true;
            armadilhaBau.SetActive(false);

        }
        /* else
         {
             bauAberto.SetActive(false);
             bauFechado.SetActive(true);
             SoundController.playSound(soundFX.OPEN);
             aberto = false;
         }*/
    }
}



































