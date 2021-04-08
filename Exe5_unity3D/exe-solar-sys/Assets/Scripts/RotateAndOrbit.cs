using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAndOrbit : MonoBehaviour
{
    public Transform sunTransform;

    private float _rotationSpeed = 0.1f;

    public bool startMovement = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startMovement)
        {
            transform.RotateAround(sunTransform.transform.position, Vector3.up, 5 * Time.deltaTime);
            transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
        }
        
    }


    public void StartMovement(Vector3 startingPoint, float rotationSpeed, float scale)
    {
        Transform me = transform;
        me.position = startingPoint;
        me.localScale *= scale;
        _rotationSpeed = rotationSpeed;
    }
        
}
