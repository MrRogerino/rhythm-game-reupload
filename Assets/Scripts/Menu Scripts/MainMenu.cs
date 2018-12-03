using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        };
        SceneManager.LoadScene("Rhythm Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
