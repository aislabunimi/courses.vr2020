using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* code modified starting from https://forum.unity.com/threads/click-drag-camera-movement.39513/
and https://answers.unity.com/questions/488056/clamp-mouse-zoom-using-scroll-wheel.html */


public class CameraDragMove : MonoBehaviour
{
    public float dragSpeed = 0.0005f;
    private Vector3 dragOrigin;
    private Vector3 cameraOriginalPos;

    private Camera me;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
