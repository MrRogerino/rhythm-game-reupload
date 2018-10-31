using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour {

    GameObject playerTrack;
    AudioSource playerAudio;
    GameObject baseTrack;
    AudioSource baseAudio;

    // Use this for initialization
    void Start()
    {
        GameObject playerTrack = GameObject.Find("PlayerTrack");
        playerAudio = playerTrack.GetComponent<AudioSource>();
        GameObject baseTrack = GameObject.Find("BaseTrack");
        baseAudio = baseTrack.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("failCollider"))
        {
            Debug.Log("note fail");
            Destroy(gameObject);
            StopMusic();
        }
    }

    void StopMusic()
    {
        playerAudio.mute = true;
        baseAudio.mute = false;
        Debug.Log("playerAudio playing: " + playerAudio.mute);
        Debug.Log("base Audio playing: " + baseAudio.mute);
    }

}
