using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activator : MonoBehaviour {

    public KeyCode key;
    public string direction;
    bool active = false;
    GameObject note;
    GameObject playerTrack;
    AudioSource playerAudio;
    GameObject baseTrack;
    AudioSource baseAudio;
    AudioSource failClip;
    AudioSource successClip;
    GameObject dashboard;

	// Use this for initialization
	void Start () {
	    GameObject playerTrack = GameObject.Find("PlayerTrack");
        playerAudio = playerTrack.GetComponent<AudioSource>();
        GameObject baseTrack = GameObject.Find("BaseTrack");
        baseAudio = baseTrack.GetComponent<AudioSource>();
        List<AudioSource> audioclips = new List<AudioSource>();
        GetComponents(audioclips);
        failClip = audioclips[0];
        successClip = audioclips[1];
        dashboard = GameObject.Find("Dashboard");
    }
	
	// Update is called once per frame
	void Update () {
        // no note available
        if (Input.GetKeyDown(key) && !active)
        {
            failClip.Play();
        }
        // success event
		if (Input.GetKeyDown(key) && active)
        {
            successClip.Play();
            Destroy(note);
            PlayMusic();
            active = false;
            dashboard.GetComponent<DashboardDisplay>().ResetDashboard();
        }
	}

    void OnTriggerEnter(Collider col)
    {
        active = true;
        if (col.gameObject.CompareTag("Note"))
        {
            dashboard.GetComponent<DashboardDisplay>().ChangeDashboard(direction); 
            note = col.gameObject;
        }
    }

    void OnTriggerExit(Collider col)
    {
        active = false;
        dashboard.GetComponent<DashboardDisplay>().ResetDashboard();
    }

    void PlayMusic()
    {
        playerAudio.mute = false;
        baseAudio.mute = true;
    }
}
