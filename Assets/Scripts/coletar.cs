using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coletar : MonoBehaviour
{
    private UIController UIController;

    private int cherry;
    private int dimound;

    // Use this for initialization
    void Start()
    {
        UIController = FindObjectOfType(typeof(UIController)) as UIController;

        cherry = 2;
        dimound = 5;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void interacaoCherry()
    {
        UIController.cherry += cherry;

        this.gameObject.SetActive(false);
    }

    public void interacaoDiamond()
    {
        SoundController.playSound(soundFX.MOEDA);

        UIController.dimound += dimound;

        this.gameObject.SetActive(false);
    }
}
