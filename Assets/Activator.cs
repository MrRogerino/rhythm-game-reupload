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
    

	// Use this for initialization
	void Start () {
	    GameObject playerTrack = GameObject.Find("PlayerTrack");
        playerAudio = playerTrack.GetComponent<AudioSource>();
        GameObject baseTrack = GameObject.Find("BaseTrack");
        baseAudio = baseTrack.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(key))
        {
            //play fail sound
        }
		if (Input.GetKeyDown(key) && active)
        {
            Destroy(note);
            //play success sound
            Debug.Log("note hit");
            PlayMusic();
            active = false;
        }
	}

    void OnTriggerEnter(Collider col)
    {
        active = true;
        //Debug.Log("note active:" + active);
        if (col.gameObject.CompareTag("Note"))
        {
            note = col.gameObject;
        }
    }

    void OnTriggerExit(Collider col)
    {
        active = false;
        //Debug.Log("note active:" + active);
    }

    void PlayMusic()
    {
        playerAudio.mute = false;
        baseAudio.mute = true;
        //Debug.Log("playerAudio playing" + playerAudio.mute);
        //Debug.Log("base Audio playing" + baseAudio.mute);
    }
}
