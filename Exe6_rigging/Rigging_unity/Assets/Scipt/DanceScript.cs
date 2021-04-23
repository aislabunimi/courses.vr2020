using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceScript : MonoBehaviour
{
    public Animator avatarAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            avatarAnimator.SetInteger("dance_type", 1);
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            avatarAnimator.SetInteger("dance_type", 2);
        } 
        
    }
}
