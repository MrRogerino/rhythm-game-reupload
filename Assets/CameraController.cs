using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public int movespeed = 2;
    GameObject noteBar;
    GameObject cameraShake;

	// Use this for initialization
	void Start () {
        noteBar = GameObject.Find("NoteBar");
        cameraEffects = GetComponent < CameraShake() >;
	}

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * movespeed * Time.deltaTime;
    }
}
