using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NoteController : MonoBehaviour {

    GameObject playerTrack;
    AudioSource playerAudio;
    GameObject baseTrack;
    AudioSource baseAudio;
    AudioSource failClip;
    int delay = 1;

    // Use this for initialization
    void Start()
    {
        playerTrack = GameObject.Find("PlayerTrack");
        playerAudio = playerTrack.GetComponent<AudioSource>();
        baseTrack = GameObject.Find("BaseTrack");
        baseAudio = baseTrack.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FailCollider"))
        {
            StopMusic();
            Destroy(gameObject, 1);
            
        }
    }

    void StopMusic()
    {
        playerAudio.mute = true;
        baseAudio.mute = false;
    }
}
