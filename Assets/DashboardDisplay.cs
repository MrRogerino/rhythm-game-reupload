using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DashboardDisplay : MonoBehaviour {

    Image defaultImage;
    public Sprite defaultDashboard;
    public Sprite leftDashboard;
    public Sprite middleDashboard;
    public Sprite rightDashboard;
    public enum Direction { left, middle, right }

	// Use this for initialization
	void Start () {
        defaultImage = GetComponent<Image>();
	}

    void Update()
    {
        
    }
	
    public void ResetDashboard ()
    {
        defaultImage.sprite = defaultDashboard;
    }

    public void ChangeDashboard(string direction)
    {
        if (direction == "left")
        {
            defaultImage.sprite = leftDashboard;
        }
        if (direction == "middle")
        {
            defaultImage.sprite = middleDashboard;
        }
        if (direction == "right")
        {
            defaultImage.sprite = rightDashboard;
        }
    }
}
