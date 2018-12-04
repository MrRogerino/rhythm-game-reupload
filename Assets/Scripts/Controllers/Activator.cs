using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activator : MonoBehaviour {

    public KeyCode key;
    public bool autoPlay;
    public string direction;
    bool active = false;
    GameObject note;
    AudioSource playerAudio;
    AudioSource baseAudio;
    AudioSource failClip;
    AudioSource successClip;
    GameObject dashboard;

	// Use this for initialization
	void Start () {
        playerAudio = GameObject.Find("PlayerTrack").GetComponent<AudioSource>();
        baseAudio = GameObject.Find("BaseTrack").GetComponent<AudioSource>();
        List<AudioSource> audioclips = new List<AudioSource>();
        GetComponents(audioclips);
        failClip = audioclips[0];
        successClip = audioclips[1];
        dashboard = GameObject.Find("Dashboard");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(key) && !active)
        {
            failClip.Play();
        }
		if ((Input.GetKeyDown(key) && active) || (autoPlay && active))
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
