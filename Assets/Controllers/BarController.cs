using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour {
    Material baseMaterial;
    public Material pressedMaterial;
    public Material availableMaterial;
    bool active = false;
    GameObject note;
    public int movespeed = 2;

	// Use this for initialization
	void Start () {
        baseMaterial = GetComponent < Renderer >().material;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.forward * movespeed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
           StartCoroutine(Pressed());
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Note"))
        {
            StartCoroutine(NoteAvailable());
        }
    }

    IEnumerator Pressed()
    {
        Material old = baseMaterial;
        GetComponent<Renderer>().material = pressedMaterial;
        yield return new WaitForSeconds(0.2f);
        GetComponent<Renderer>().material = baseMaterial;
    }

    IEnumerator NoteAvailable()
    {
        Material odl = baseMaterial;
        GetComponent<Renderer>().material = availableMaterial;
        yield return new WaitForSeconds(0.2f);
        GetComponent<Renderer>().material = baseMaterial;
    }
}
