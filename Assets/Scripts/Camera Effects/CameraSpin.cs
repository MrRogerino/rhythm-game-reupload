using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpin : MonoBehaviour {

    public bool debugMode = false;

    public float spinAmount; //how many degrees to rotate
    public float spinDuration; //how long the rotation should last for

    //Readonly values...
    float shakePercentage;//A percentage (0-1) representing the amount of shake to be applied when setting rotation.
    float startAmount;//The initial shake amount (to determine percentage), set when ShakeCamera is called.
    float startDuration;//The initial shake duration, set when ShakeCamera is called.

    bool isRunning = false; //Is the coroutine running right now?

    public bool smooth;//Smooth rotation?
    public float smoothAmount = 5f;//Amount to smooth

    void Start()
    {

        if (debugMode) SpinCamera();
    }


    void SpinCamera()
    {

        startAmount = spinAmount;//Set default (start) values
        startDuration = spinDuration;//Set default (start) values

        if (!isRunning) StartCoroutine(Spin());//Only call the coroutine if it isn't currently running. Otherwise, just set the variables.
    }

    public void SpinCamera(float amount, float duration)
    {

        spinAmount += amount;//Add to the current amount.
        startAmount = spinAmount;//Reset the start amount, to determine percentage.
        spinDuration += duration;//Add to the current time.
        startDuration = spinDuration;//Reset the start time.

        if (!isRunning) StartCoroutine(Spin());//Only call the coroutine if it isn't currently running. Otherwise, just set the variables.
    }


    IEnumerator Spin()
    {
        isRunning = true;

        while (spinDuration > 0.01f)
        {
            Vector3 rotationAmount = new Vector3(0f, spinAmount, 0f);//A Vector3 to add to the Local Rotation
            rotationAmount.z = 0;//Don't change the Z; it looks funny.

            spinDuration = Mathf.Lerp(spinDuration, 0, Time.deltaTime);//Lerp the time, so it is less and tapers off towards the end.

            if (smooth)
                transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(rotationAmount), Time.deltaTime * smoothAmount);
            else
                transform.localRotation = Quaternion.Euler(rotationAmount);//Set the local rotation the be the rotation amount.

            yield return null;
        }

        if (spinDuration == 0.0f)
        {
            transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.identity, Time.deltaTime * smoothAmount);
        }
        //transform.localRotation = Quaternion.identity;//Set the local rotation to 0 when done, just to get rid of any fudging stuff.
        isRunning = false;
    }
}

