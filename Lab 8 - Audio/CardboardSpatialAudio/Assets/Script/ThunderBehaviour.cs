using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderBehaviour : MonoBehaviour {

	public Transform target;

	public float targetMaxDistance = 100f;

	public float minPlayFreq = 2f;
	public float maxPlayFreq = 10f;

	public AudioClip[] clips;

	AudioSource audioSrc;


	// Use this for initialization
	void Start () {
		audioSrc = GetComponent<AudioSource>();
		Invoke("MoveAndPlaySound", Random.Range(minPlayFreq, maxPlayFreq));
	}

	void MoveAndPlaySound(){
		if(!audioSrc.isPlaying){
			audioSrc.clip = clips[Random.Range(0, clips.Length)];
			transform.position = new Vector3(Random.Range(-(targetMaxDistance / 2f), targetMaxDistance),
								transform.position.y,
								Random.Range(-(targetMaxDistance / 2f), targetMaxDistance));
			audioSrc.Play();
		}
		Invoke("MoveAndPlaySound", Random.Range(minPlayFreq, maxPlayFreq));
	}
}
