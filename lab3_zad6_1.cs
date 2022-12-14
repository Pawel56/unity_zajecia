using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab3_zad6_1 : MonoBehaviour
{
    public Transform target;
    public float smoothTime;
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        smoothTime = 0.3f;
        velocity = 0.1f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float newPositionX = Mathf.SmoothDamp(transform.position.x, target.position.x, ref velocity, smoothTime);
        float newPositionY = Mathf.SmoothDamp(transform.position.y, target.position.y, ref velocity, smoothTime);
        float newPositionZ = Mathf.SmoothDamp(transform.position.z, target.position.z, ref velocity, smoothTime);
        transform.position = new Vector3(newPositionX, newPositionY, newPositionZ);
    }
}
