using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroMove : MonoBehaviour
{
    private void Start() {
    #if UNITY_ANDROID
        QualitySettings.vSyncCount = 0; 
        Application.targetFrameRate = 60; 
        QualitySettings.antiAliasing = 0; 
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    #endif
    }
     private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
            Vector2 touchDelta = Input.GetTouch(0).deltaPosition;
            transform.Translate(-touchDelta.x,-touchDelta.y,0);
        }
            
    }
}
