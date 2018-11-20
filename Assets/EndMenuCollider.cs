using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenuCollider : MonoBehaviour {

	void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "NoteBar")
        {
            SceneManager.LoadScene("End Screen");
        }
    }
}
