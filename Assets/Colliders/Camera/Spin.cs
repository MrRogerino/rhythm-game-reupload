using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

    public int spinAmount;
    public int spinDuration;
    GameObject gameCamera;

    void Start()
    {
        gameCamera = GameObject.Find("Main Camera");
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("NoteBar"))
        {
            gameCamera.GetComponent<CameraSpin>().SpinCamera(spinAmount, spinDuration);
        }
    }
}
