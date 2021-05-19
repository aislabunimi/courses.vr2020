using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GazeClickable : MonoBehaviour {

	public float requiredStareTime = 1.0f;
	public Color clickSuccessColor = Color.green;
	public UnityEvent onGazeClicked;

	float gazeStartTime = 0.0f;
	bool staringAtMe = false;
	Color clickNeutralColor = Color.white;
	GameObject pointer;

	// Use this for initialization
	void Start () {

		pointer = FindObjectOfType<GvrReticlePointer>().gameObject;
		if (pointer){
			clickNeutralColor = pointer.GetComponent<Renderer>().material.color;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(staringAtMe){
			if(Time.time - gazeStartTime >= requiredStareTime){
				if(pointer){
					pointer.GetComponent<Renderer>().material.color = clickSuccessColor;
				}

				onGazeClicked.Invoke();
				staringAtMe = false;
			}
		}
	}

	public void OnPointerEnter(){
		gazeStartTime = Time.time;
		staringAtMe = true;
	}

	public void OnPointerExit(){
		staringAtMe = false;
		if(pointer){
			pointer.GetComponent<Renderer>().material.color = clickNeutralColor;
		}
	}
}
