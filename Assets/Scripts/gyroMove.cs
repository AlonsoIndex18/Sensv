using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroMove : MonoBehaviour
{
    private void Start() {
    
    }
     private void Update()
    {
        if (Input.touchCount > 0 ) {
            Debug.Log("Hay touch");
            if(Input.GetTouch(0).phase == TouchPhase.Moved){
                Debug.Log("Funciona");
                
                Debug.Log(transform.position);
                Vector2 touchDelta = Input.GetTouch(0).deltaPosition;
                transform.Translate(-touchDelta.x,-touchDelta.y,0);
            }
        }else{
            Debug.Log("No hay touch");
        }
            
    }
}
