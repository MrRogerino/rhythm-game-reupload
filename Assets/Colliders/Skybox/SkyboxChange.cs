using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChange : MonoBehaviour {

    public Material skyboxMaterial;
    public float intensity;
    Light lighting;

    void Start()
    {
        lighting = GameObject.Find("Directional Light").GetComponent<Light>();
        Debug.Log(lighting.intensity);
    }

    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.CompareTag("NoteBar")){
            RenderSettings.skybox = skyboxMaterial;
            lighting.intensity = intensity;
            Debug.Log(lighting.intensity);
        }
    }
}