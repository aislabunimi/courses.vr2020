using UnityEngine;
using UnityEngine.Assertions;

public class ExplodingBullet : Bullet
{
    [SerializeField] private GameObject explosionPrefab;
    
    [SerializeField] private AudioClip explosionSound;
    
    private void Start()
    {
        Assert.IsNotNull(this.explosionPrefab);
    }

    protected override void OnCollision(Collision other)
    {
        base.OnCollision(other);
        // To complete
    }
}
