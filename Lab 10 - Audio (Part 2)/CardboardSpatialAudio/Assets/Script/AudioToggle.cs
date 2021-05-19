using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioToggle : MonoBehaviour {

    AudioSource audioSrc;

	// Use this for initialization
	void Start () {
		audioSrc = GetComponent<AudioSource>();
	}

	public void ToogleAudioSource(){
		if(!audioSrc.isPlaying){
			audioSrc.Play();
		}
		else{
			audioSrc.Stop();
		}
	}


}
