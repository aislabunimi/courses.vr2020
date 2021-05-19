using System.Collections;
using UnityEngine;

/// <summary>
/// Class that will spawn the targets
/// </summary>
public class TargetManager : MonoBehaviour
{
    private int MIN_TIME = 1, MAX_TIME = 4;
    private int MIN_LIFE = 5, MAX_LIFE = 12;

    private int MIN_X = -10, MAX_X = 10;
    private int MIN_Y = -10, MAX_Y = 10;
    private int MIN_Z = 12, MAX_Z = 20;

    private int MIN_SCALE = 5, MAX_SCALE = 10;

    [SerializeField] private GameObject[] targetsPrefabs;
    
    private void Start()
    {
        // To complete
    }
}
