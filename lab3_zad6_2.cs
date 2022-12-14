using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab3_zad6_2 : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float newPositionX = Mathf.Lerp(transform.position.x, target.position.x, 0.5f);
        float newPositionY = Mathf.Lerp(transform.position.y, target.position.y, 0.5f);
        float newPositionZ = Mathf.Lerp(transform.position.z, target.position.z, 0.5f);
        transform.position = new Vector3(newPositionX, newPositionY, newPositionZ);
    }
}
