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
        me = GetComponent<Camera>();
        cameraOriginalPos = transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        
       if (Input.GetMouseButtonDown(0))
       {
                dragOrigin = Input.mousePosition;
                return;
        }

        if (!Input.GetMouseButton(0)) return;

        Vector3 pos = me.ScreenToViewportPoint(dragOrigin - Input.mousePosition);
        Vector3 move = new Vector3(pos.x * dragSpeed, pos.y * dragSpeed, 0);

        transform.Translate(move, Space.World);
        
        

    }


    public void Zoom(float f)
    {
        transform.Translate(0, 0, f);
    }

    public void Reset()
    {
        transform.position = cameraOriginalPos;
    }
}
