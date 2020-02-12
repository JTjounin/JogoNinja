using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    
    public Text cherryText;
    public Text dimoundText;


    public int dimound;
    public int cherry;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dimoundText.text = dimound.ToString();
        cherryText.text = cherry.ToString();
    }
}
