using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverTime : MonoBehaviour
{
    public float lifeTime = 10f; // How long the bullet stays in the world before being destroyed
    float time;

    private void Awake()
    {
        time = Time.time;

        if (lifeTime - time < 0)
        {
            Destroy(this);
        }
    }
   
}
