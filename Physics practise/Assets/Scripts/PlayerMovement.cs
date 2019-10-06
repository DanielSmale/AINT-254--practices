using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 10.0f;
    public float rotationSpeed = 5000f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.velocity = transform.forward * speed;
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up * -speed * Time.deltaTime);

        }

        if (Input.GetKey("s"))
        {
            rb.velocity = -transform.forward * speed;
        }
    }

}
