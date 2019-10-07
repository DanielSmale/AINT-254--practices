using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    Rigidbody rb;
    public float bulletSpeed = 30;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();

        rb.velocity = transform.forward * bulletSpeed;
    }

}
