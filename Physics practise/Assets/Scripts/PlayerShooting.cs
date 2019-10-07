using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bullet;
    public Rigidbody bulletRb;
    public float bulletSpeed = 10000.0f;
    public float damamge = 5f;


    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
        bulletRb = bullet.GetComponent<Rigidbody>();

        bulletRb.AddForce(transform.forward * bulletSpeed);

    }

}
