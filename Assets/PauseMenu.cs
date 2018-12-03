using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    AudioSource playerAudio;
    AudioSource baseAudio;

    void Start()
    {
        playerAudio = GameObject.Find("PlayerTrack").GetComponent<AudioSource>();
        baseAudio = GameObject.Find("BaseTrack").GetComponent<AudioSource>();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        playerAudio.Pause();
        baseAudio.Pause();
        Debug.Log("paused!");
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        playerAudio.Play();
        baseAudio.Play();
        Debug.Log("resume!");
    }

}
