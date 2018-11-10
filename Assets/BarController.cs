using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour {
    Material baseMaterial;
    public Material pressedMaterial;
    public Material availableMaterial;
    bool active = false;
    GameObject note;

	// Use this for initialization
	void Start () {
        baseMaterial = GetComponent < Renderer >().material;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space))
        {
           StartCoroutine(Pressed());
        }
	}

    void OnTriggerEnter(Collider col)
    {
        active = true;
        //Debug.Log("note active:" + active);
        if (col.gameObject.CompareTag("Note"))
        {
            StartCoroutine(NoteAvailable());
        }
    }

    void OnTriggerExit(Collider col)
    {
        active = false;
        //Debug.Log("note active:" + active);
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
