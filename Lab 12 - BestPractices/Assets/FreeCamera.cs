using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class FreeCamera : MonoBehaviour
 {
     public float sensitivity = 10f;

     private GameObject target;
     
     void Update ()
     {
         var c = this.transform;
         c.Rotate(0, Input.GetAxis("Mouse X")* sensitivity, 0);
         c.Rotate(-Input.GetAxis("Mouse Y")* sensitivity, 0, 0);
         //c.Rotate(0, 0, -Input.GetAxis("QandE")*90 * Time.deltaTime);
         c.transform.rotation =
             Quaternion.Euler(c.transform.rotation.eulerAngles.x, c.transform.rotation.eulerAngles.y, 0);
     }
 }