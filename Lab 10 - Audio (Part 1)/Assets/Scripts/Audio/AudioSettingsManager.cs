using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Audio;

public class AudioSettingsManager : MonoBehaviour
{
    [Header("Volumes")] 
    [SerializeField] [Range(-80, 20)] private int globalVolume = 0;
    public int GlobalVolume
    {
        get => globalVolume;
        set { globalVolume = value;
            UpdateVolumes();
        }
    }

    [SerializeField] [Range(-80, 20)] private int backgroundVolume = 0;
    public int BackgroundVolume
    {
        get => backgroundVolume;
        set { backgroundVolume = value;
            UpdateVolumes();
        }
    }

    [SerializeField] [Range(-80, 20)] private int soundEffectsVolume = 0;
    public int SoundEffectsVolume
    {
        get => soundEffectsVolume;
        set { soundEffectsVolume = value;
            UpdateVolumes();
        }
    }

    [SerializeField] private AudioMixer audioMixer;

    private void Awake()
    {
        Assert.IsNotNull(this.audioMixer);
    }

    private void Start()
    {
        UpdateVolumes();
    }

    public void UpdateVolumes()
    {
        // To complete   
    }

    public void OnValidate()
    {
        // To complete
    }
}
