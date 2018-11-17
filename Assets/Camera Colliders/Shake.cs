using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour {

    public int shakeAmount;
    public int shakeDuration;
    GameObject gameCamera;

    void Start ()
    {
        gameCamera = GameObject.Find("Main Camera");
    }
	
	void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("NoteBar"))
        {
            gameCamera.GetComponent<CameraShake>().ShakeCamera(shakeAmount, shakeDuration);
        }
    }
}
