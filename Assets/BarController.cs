using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour {
    Material baseMaterial;
    public Material pressedMaterial;

	// Use this for initialization
	void Start () {
        baseMaterial = GetComponent < Renderer >().material;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           StartCoroutine(Pressed());
            Debug.Log("hey");
        }
	}

    IEnumerator Pressed()
    {
        Material old = baseMaterial;
        GetComponent<Renderer>().material = pressedMaterial;
        yield return new WaitForSeconds(0.2f);
        GetComponent<Renderer>().material = baseMaterial;
    }
}
