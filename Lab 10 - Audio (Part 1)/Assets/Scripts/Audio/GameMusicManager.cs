using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

[RequireComponent((typeof(AudioSource)))]
public class GameMusicManager : MonoBehaviour
{
    /// <summary>
    /// Reference to all the available background music
    /// </summary>
    [SerializeField] private List<AudioClip> musics;

    /// <summary>
    /// Audio source
    /// </summary>
    private AudioSource audioSource;

    /// <summary>
    /// List of the reproduced musics in this match (used to avoid repetition)
    /// </summary>
    private List<AudioClip> reproducedMusics;
    
    /// <summary>
    /// Awake
    /// </summary>
    private void Awake()
    {
        audioSource = this.GetComponent<AudioSource>();
        reproducedMusics = new List<AudioClip>();
        Assert.IsNotNull(audioSource);
        Assert.IsTrue(musics.Count > 0);

        // To complete
    }
}