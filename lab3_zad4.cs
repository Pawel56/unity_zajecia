using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab3_zad4 : MonoBehaviour
{
    public float speed = 5;
    float horizontalInput;
    float verticalInput;
    void Start()
    {

    }
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime);
    }
}
