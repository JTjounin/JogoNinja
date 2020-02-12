using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerp : MonoBehaviour
{

    public Transform posicaoInicial;
    public Transform posA;
    public Transform posB;
    public Transform posC;
    public Transform posD;

    public float speed;

    private float startTime; // hora de inicio do movimento
    private float journeyLength; // distancia da jornada
    public Transform Objeto; // objeto a ser movido

    private int idMovimento;

    // Use this for initialization
    void Start()
    {
        Objeto.position = posicaoInicial.position; // Coloca o objeto na posiçao inicial
        PosiçãoA();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float dist = (Time.time - startTime) * speed;
        float journey = dist / journeyLength;


        switch (idMovimento)
        {
            // A para B
            case 1:
                Objeto.position = Vector3.Lerp(posA.position, posB.position, journey);
                if (Objeto.position == posB.position) { PosiçãoB(); }
                break;

            // B para C
            case 2:
                Objeto.position = Vector3.Lerp(posB.position, posC.position, journey);
                if (Objeto.position == posC.position) { PosiçãoC(); }
                break;

            // C para D
            case 3:
                Objeto.position = Vector3.Lerp(posC.position, posD.position, journey);
                if (Objeto.position == posD.position) { PosiçãoD(); }
                break;

            // D para A
            case 4:
                Objeto.position = Vector3.Lerp(posD.position, posA.position, journey);
                if (Objeto.position == posA.position) { PosiçãoA(); }
                break;


            // 2- Parte ******************************----************************************


            // A para D
            case 5:
                Objeto.position = Vector3.Lerp(posA.position, posD.position, journey);
                if (Objeto.position == posD.position) { PosiçãoD(); }
                break;

            // D para C
            case 6:
                Objeto.position = Vector3.Lerp(posD.position, posC.position, journey);
                if (Objeto.position == posC.position) { PosiçãoC(); }
                break;

            // C para B
            case 7:
                Objeto.position = Vector3.Lerp(posC.position, posB.position, journey);
                if (Objeto.position == posB.position) { PosiçãoB(); }
                break;

            // B para A
            case 8:
                Objeto.position = Vector3.Lerp(posB.position, posA.position, journey);
                if (Objeto.position == posA.position) { PosiçãoA(); }
                break;

        }
        /*
        if (idMovimento == 1) // A para B
        {
            Objeto.position = Vector3.Lerp(posA.position, posB.position, journey);
            if(Objeto.position== posB.position)
            {
                Movimento2();
            }
        }
        else if(idMovimento == 2) // B para C
        {
            Objeto.position = Vector3.Lerp(posB.position, posC.position, journey);
            if(Objeto.position == posC.position)
            {
                Movimento3();
            }
        }

        else if (idMovimento == 3) // C para A
        {
            Objeto.position = Vector3.Lerp(posC.position, posA.position, journey);
            if (Objeto.position == posA.position)
            {
                Movimento1();
            }
        }

    */
    }


    // Posição A
    void PosiçãoA() // Quando Está Em B
    {
        int rand = Random.Range(0, 2); // O Resultado Sempre Será de 0 ou 1
        if (rand == 0)
        {
            idMovimento = 1;
        }

        else if (rand == 1)
        {
            idMovimento = 5;
        }

        startTime = Time.time; // Armazena o horario inicial do movimento
        journeyLength = Vector3.Distance(posA.position, posB.position); // calcula a distancia entre o ponto A e o ponto B

    }


    // Posição B
    void PosiçãoB() // Quando Está Em A
    {
        int rand = Random.Range(0, 2); // O Resultado Sempre Será de 0 ou 1
        if (rand == 0)
        {
            idMovimento = 2;
        }

        else if (rand == 1)
        {
            idMovimento = 8;
        }

        startTime = Time.time; // Armazena o horario inicial do movimento
        journeyLength = Vector3.Distance(posB.position, posC.position); // calcula a distancia entre o ponto A e o ponto B

    }


    // Posição C
    void PosiçãoC() // Quando Está Em C
    {
        int rand = Random.Range(0, 2); // O Resultado Sempre Será de 0 ou 1
        if (rand == 0)
        {
            idMovimento = 3;
        }

        else if (rand == 1)
        {
            idMovimento = 7;
        }

        startTime = Time.time; // Armazena o horario inicial do movimento
        journeyLength = Vector3.Distance(posC.position, posD.position); // calcula a distancia entre o ponto A e o ponto B

    }


    // Posiçao D
    void PosiçãoD() // Quando Está Em C
    {
        int rand = Random.Range(0, 2); // O Resultado Sempre Será de 0 ou 1
        if (rand == 0)
        {
            idMovimento = 4;
        }

        else if (rand == 1)
        {
            idMovimento = 6;
        }

        startTime = Time.time; // Armazena o horario inicial do movimento
        journeyLength = Vector3.Distance(posD.position, posA.position); // calcula a distancia entre o ponto A e o ponto B

    }



}

