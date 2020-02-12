using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum soundFX
{
    JUMP, OPEN, MOEDA, FIRE, MORRI, START, GO, BOOM, MUSICA
}

public class SoundController : MonoBehaviour
{


    public AudioClip jump;
    public AudioClip open;
    public AudioClip moeda;
    public AudioClip fire;
    public AudioClip morri;
    public AudioClip start;
    public AudioClip go;
    public AudioClip boom;
    public AudioClip musica;


    private AudioSource Audio;

    private static SoundController instance;

    // Use this for initialization
    void Start()
    {
        Audio = GetComponent<AudioSource>();

        instance = this;

    }

    public static void playSound(soundFX currentSount)
    {
        switch (currentSount)
        {
            case soundFX.JUMP:
                instance.Audio.PlayOneShot(instance.jump);
                break;



            case soundFX.OPEN:
                instance.Audio.PlayOneShot(instance.open);
                break;



            case soundFX.MOEDA:
                instance.Audio.PlayOneShot(instance.moeda);
                break;



            case soundFX.FIRE:
                instance.Audio.PlayOneShot(instance.fire);
                break;


            case soundFX.MORRI:
                instance.Audio.PlayOneShot(instance.morri);
                break;


            case soundFX.START:
                instance.Audio.PlayOneShot(instance.start);
                break;


            case soundFX.GO:
                instance.Audio.PlayOneShot(instance.go);
                break;


            case soundFX.BOOM:
                instance.Audio.PlayOneShot(instance.boom);
                break;


            case soundFX.MUSICA:
                instance.Audio.PlayOneShot(instance.musica);
                break;


        }
    }
}
