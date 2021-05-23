using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

[RequireComponent(typeof(AudioSource))]
public class DebugPlay : MonoBehaviour
{
    private AudioSource aSource;
    private AudioReverbZone reverb;
    
    private void Awake()
    {
        this.aSource = this.GetComponent<AudioSource>();
        this.reverb = this.GetComponent<AudioReverbZone>();
        Assert.IsNotNull(this.aSource);
    }

    public void Play()
    {
        this.aSource.Play();
    }

    public void PlayWithoutReverb()
    {
        reverb.enabled = false;
        this.Play();
    }

    public void PlayWithReverb()
    {
        reverb.enabled = true;
        this.Play();
    }
}
