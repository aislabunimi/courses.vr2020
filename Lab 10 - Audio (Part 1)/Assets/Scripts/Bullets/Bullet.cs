using UnityEngine;
using UnityEngine.Assertions;

public class Bullet : MonoBehaviour
{
    [SerializeField] private AudioClip collisionSound;
    
    private void Awake()
    {
        Assert.IsNotNull(this.collisionSound);
        Destroy(this.gameObject, 3);
    }
    
    public void OnCollisionEnter(Collision other)
    {
        this.OnCollision(other);
    }

    protected virtual void OnCollision(Collision other)
    {
        // To complete
    }
}
