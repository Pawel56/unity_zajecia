using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyProjectile : MonoBehaviour
{
    float czas;
    public float delaySeconds = 2;
    void Start()
    {
        czas = Time.time;
    }

    void FixedUpdate()
    {
        if (Time.time > czas + delaySeconds)
        {
            Destroy(gameObject);
        }
    }
}
