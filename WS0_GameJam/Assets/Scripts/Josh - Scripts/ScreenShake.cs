using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenShake : MonoBehaviour
{
    private Transform camTransform;
    private float screenShakeDuration;
    private float shakeMagnitude;
    private float speedConstraint; 
    Vector3 intitalPosition; 

    void Start()
    {
        screenShakeDuration = 0f;
        shakeMagnitude = 0.7f;
}

    void Update()
    {
        
    }
}
