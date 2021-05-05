using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGameObjectSign : MonoBehaviour {

	public GameObject targetGameObject;

	public void ToogleGameObject(){
		targetGameObject.SetActive(!targetGameObject.activeInHierarchy);
	}
}
