using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {

    public KeyCode key;
    bool active = false;
    GameObject note;
    GameObject playerTrack;
    AudioSource playerAudio;
    GameObject baseTrack;
    AudioSource baseAudio;
    AudioSource failClip;
    

	// Use this for initialization
	void Start () {
	    GameObject playerTrack = GameObject.Find("PlayerTrack");
        playerAudio = playerTrack.GetComponent<AudioSource>();
        GameObject baseTrack = GameObject.Find("BaseTrack");
        baseAudio = baseTrack.GetComponent<AudioSource>();
        failClip = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(key) && !active)
        {
            failClip.Play();
        }
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
        if (col.gameObject.CompareTag("Note"))
        {
            note = col.gameObject;
        }
    }

    void OnTriggerExit(Collider col)
    {
        active = false;
    }

    void PlayMusic()
    {
        playerAudio.mute = false;
        baseAudio.mute = true;
    }
}
