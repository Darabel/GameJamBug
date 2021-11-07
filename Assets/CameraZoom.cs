using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    
    public Camera cam;
    [SerializeField] public float maxZoom = 5;
    [SerializeField] public float minZoom = 20;
    [SerializeField] public float sensitivity = 1;
    [SerializeField] public float speed = 30;
    float targetZoom;
 
     void Update()
    {

        targetZoom -= Input.mouseScrollDelta.y * sensitivity;
        targetZoom = Mathf.Clamp(targetZoom, maxZoom, minZoom);
        float newSize = Mathf.MoveTowards(cam.orthographicSize, targetZoom, speed * Time.deltaTime);
        cam.orthographicSize = newSize;

    }
}
