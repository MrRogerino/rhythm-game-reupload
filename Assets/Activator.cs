using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {

    public KeyCode key;
    bool active = false;
    GameObject note;
    GameObject playerTrack;
    AudioSource audioSource;

	// Use this for initialization
	void Start () {
	    GameObject playerTrack = GameObject.Find("PlayerTrack");
        audioSource = playerTrack.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(key) && active)
        {
            Destroy(note);
            PlayMusic();
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

    void PlayMusic()
    {
        audioSource.mute = false;
    }
}
