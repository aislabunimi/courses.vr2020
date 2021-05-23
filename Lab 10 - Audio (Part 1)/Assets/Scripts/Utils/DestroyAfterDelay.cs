using UnityEngine;

public class DestroyAfterDelay : MonoBehaviour
{
    [SerializeField] private int delay = 3;
    
    private void Awake()
    {
        Destroy(this.gameObject, this.delay);
    }
}
