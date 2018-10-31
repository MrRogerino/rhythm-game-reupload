using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour {

    GameObject playerTrack;
    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        GameObject playerTrack = GameObject.Find("PlayerTrack");
        audioSource = playerTrack.GetComponent<AudioSource>();
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
        audioSource.mute = true;
        Debug.Log("track muted");
    }

}
