using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapSceneSign : MonoBehaviour {

	public string sceneToLoad;

	public void LoadOtherScene(){
		SceneManager.LoadScene(sceneToLoad);
	}
}
