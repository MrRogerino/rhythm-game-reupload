using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {

    public KeyCode key;
    bool active = false;
    GameObject note;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(key) && active)
        {
            Destroy(note);
            active = false;
        }
	}

    void OnTriggerEnter(Collider col)
    {
        active = true;
        Debug.Log("note active:" + active);
        if (col.gameObject.CompareTag("Note"))
        {
            note = col.gameObject;
        }
    }

    void OnTriggerExit(Collider col)
    {
        active = false;
        Debug.Log("note active:" + active);
    }
}
