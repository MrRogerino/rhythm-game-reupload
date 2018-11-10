using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NoteController : MonoBehaviour {

    GameObject playerTrack;
    AudioSource playerAudio;
    GameObject baseTrack;
    AudioSource baseAudio;
    AudioSource failClip;

    // Use this for initialization
    void Start()
    {
        playerTrack = GameObject.Find("PlayerTrack");
        playerAudio = playerTrack.GetComponent<AudioSource>();
        baseTrack = GameObject.Find("BaseTrack");
        baseAudio = baseTrack.GetComponent<AudioSource>();
        failClip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FailCollider"))
        {
            failClip.Play(0);
            Destroy(gameObject);
            StopMusic();
            Debug.Log("hey");
        }
    }

    void StopMusic()
    {
        playerAudio.mute = true;
        baseAudio.mute = false;
        //Debug.Log("playerAudio playing: " + playerAudio.mute);
        //Debug.Log("base Audio playing: " + baseAudio.mute);
    }

}
