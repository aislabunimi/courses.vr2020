using UnityEngine;
using UnityEngine.Assertions;

[RequireComponent(typeof(AudioSource))]
public class PlayerController : MonoBehaviour
{
    [Range(1,10)]
    public float sensitivity;

    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject specialBullet;

    [SerializeField] private AudioClip shootingClip;

    private void Awake()
    {
        Assert.IsNotNull(this.bullet);
        Assert.IsNotNull(this.specialBullet);
        Assert.IsNotNull(this.shootingClip);
    }

    private void Update()
    {
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = Input.GetAxis("Mouse Y");
        transform.RotateAround(this.transform.position, Vector3.up, rotateHorizontal * sensitivity);
        transform.RotateAround(this.transform.position, -Vector3.right, rotateVertical * sensitivity);
        this.transform.rotation = Quaternion.Euler(this.transform.rotation.eulerAngles.x, this.transform.rotation.eulerAngles.y, 0);
    }
}
