using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [SerializeField] private GameObject soundPrefab;
    
    private void Awake()
    {
        Instance = this;
    }

    public void PlaySound(AudioClip clip, Vector3 position, float spatialBlend)
    {
        // To complete
    }
}
