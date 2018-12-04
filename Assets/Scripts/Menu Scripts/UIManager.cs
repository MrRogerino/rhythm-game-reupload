using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	public void PlayBaseGame()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        };
        SceneManager.LoadScene("Rhythm Game");
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        StopMusic();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PlayMusic();
    }

    public void RestartGame()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        };
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnToMain()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void PlayMusic()
    {
        GameObject.Find("PlayerTrack").GetComponent<AudioSource>().Play();
        GameObject.Find("BaseTrack").GetComponent<AudioSource>().Play();
        Debug.Log("playing music");
    }

    void StopMusic()
    {
        GameObject.Find("PlayerTrack").GetComponent<AudioSource>().Pause();
        GameObject.Find("BaseTrack").GetComponent<AudioSource>().Pause();
        Debug.Log("pausing music");
    }

    
}
