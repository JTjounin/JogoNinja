using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {

    public Transform backGround;
    public float parallaxScale;
    public float smoothing;

    public Transform cam;
    private Vector3 previewsCamPos;


	// Use this for initialization
	void Start () {
        previewsCamPos = cam.position;
	}
	
	// Update is called once per frame
	void Update () {
		float parallax = (previewsCamPos.x - cam.position.x) * parallaxScale;
        float bgTargetX = backGround.position.x + parallax;
        Vector3 bgPos = new Vector3(bgTargetX, backGround.position.y, backGround.position.z);

        backGround.position = Vector3.Lerp(backGround.position, bgPos, smoothing * Time.deltaTime);

        previewsCamPos = cam.position;
	}
}
