using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

[RequireComponent(typeof(AudioSource))]
public class GenericSoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource aSource;

    public bool DestroyAtTheEnd = false; 
    
    private void Awake()
    {
        this.aSource = this.GetComponent<AudioSource>();
        Assert.IsNotNull(this.aSource);
    }
    
    public void PlaySound(AudioClip clip, float spatialBlend)
    {
        // To complete
    }

}
