using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

	// Use this for initialization
	void Start () {
        transform.position = target.position + offset;
	}

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
