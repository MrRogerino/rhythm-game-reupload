using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChange : MonoBehaviour {

    public Material skyboxMaterial;

    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.CompareTag("NoteBar")){
            RenderSettings.skybox = skyboxMaterial;
        }
    }
}